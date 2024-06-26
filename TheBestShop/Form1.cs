﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms.VisualStyles;
using Microsoft.Office.Interop.Excel;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DataTable = System.Data.DataTable;
using Excel = Microsoft.Office.Interop.Excel;
using Series = System.Windows.Forms.DataVisualization.Charting.Series;


namespace TheBestShop
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = TheShop";
        public Form1()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();

            loadCustomers();
            loadProducts();
            loadInvoices();
        }

        private void loadCustomers()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Customers", con);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void loadProducts()
        {

            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Products", con);
            adap.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void loadInvoices()
        {

            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Invoices", con);
            adap.Fill(dt);
            dataGridView3.DataSource = dt;
        }



        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            FormCustomers f = new FormCustomers();
            f.ShowDialog();
            loadCustomers();
        }

        private void buttonChange1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите покупателя для изменения.");
                return;
            }

            DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedCell.RowIndex];
            FormCustomersChange f = new FormCustomersChange();
            f.SelectedRow = selectedRow;
            f.ShowDialog();
            loadCustomers();
        }

        private void buttonDel1_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Customers WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadCustomers();
            loadInvoices();
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            FormProducts f = new FormProducts();
            f.ShowDialog();
            loadProducts();
        }


        private void buttonСhange2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите товар для изменения.");
                return;
            }

            DataGridViewCell selectedCell = dataGridView2.SelectedCells[0];
            DataGridViewRow selectedRow = dataGridView2.Rows[selectedCell.RowIndex];
            FormProductsChange f = new FormProductsChange();
            f.SelectedRow = selectedRow;
            f.ShowDialog();
            loadProducts();
        }

        private void buttonDel2_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Products WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadProducts();
            loadInvoices();
        }

        private void buttonAdd3_Click(object sender, EventArgs e)
        {
            FormInvoices f = new FormInvoices();
            f.ShowDialog();
            loadInvoices();
        }

        private void buttonChange3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите счет-фактуру для изменения.");
                return;
            }

            DataGridViewCell selectedCell = dataGridView3.SelectedCells[0];
            DataGridViewRow selectedRow = dataGridView3.Rows[selectedCell.RowIndex];
            FormInvoicesChange f = new FormInvoicesChange();
            f.SelectedRow = selectedRow;
            f.ShowDialog();
            loadInvoices();
        }

        private void buttonDel3_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM Invoices WHERE id=(@id)";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            int id = int.Parse(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            cmd.Parameters.AddWithValue("id", id);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            loadInvoices();
        }

        private void buttonReport1_Click(object sender, EventArgs e)
        {

            Excel.Application ex = new Excel.Application();
            Excel.Workbook wb = ex.Workbooks.Add();
            Excel.Worksheet sheet = wb.Sheets[1];

            try
            {
                // SQL-запрос для объединения данных
                string sql = @"
            SELECT 
                inv.id AS InvoiceId, 
                CONCAT(c.firstname, ' ', c.lastname, ' ', c.patronym) AS FullName,
                p.name_prod AS ProductName, 
                inv.quantity AS Quantity, 
                inv.invoice_date AS InvoiceDate, 
                inv.payment_date AS PaymentDate,
                p.cost_prod*inv.quantity*(100+p.nds)/100 AS Total,
                inv.paid AS Paid,
                (p.cost_prod*inv.quantity*(100+p.nds)/100 - inv.paid) AS Debt
            FROM 
                Invoices AS inv
            JOIN Customers AS c ON inv.customer_id = c.id
            JOIN Products AS p ON inv.product_id = p.id
            WHERE inv.payment_date < @curDate and @curDate > inv.invoice_date and p.cost_prod > inv.paid
                ";
                int row = 2;
                object[,] dataArray = new object[100, 2];
                // Создание и настройка команды для выполнения SQL-запроса
                using (var command = new NpgsqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@curDate", dtpCur.Value.Date);

                    // Заголовки столбцов в Excel
                    sheet.Cells[1, 1].Value = "Номер счета-фактуры";
                    sheet.Cells[1, 2].Value = "ФИО";
                    sheet.Cells[1, 3].Value = "Наименование товара";
                    sheet.Cells[1, 4].Value = "Количество товара";
                    sheet.Cells[1, 5].Value = "Дата выписки счета-фактуры";
                    sheet.Cells[1, 6].Value = "Дата ожидаемого платежа";
                    sheet.Cells[1, 7].Value = "Общая стоимость";
                    sheet.Cells[1, 8].Value = "Оплачено";
                    sheet.Cells[1, 9].Value = "ЗАДОЛЖЕННОСТЬ";

                    // Выполнение SQL-запроса и заполнение данными в Excel
                     // Начинаем со второй строки, так как первую уже заполнили заголовками
                    
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int col = 1; col <= 9; col++)
                            {
                                sheet.Cells[row, col].Value = reader[col - 1];
                            }
                            dataArray[row, 0] = reader[0]; // Столбец 1
                            dataArray[row, 1] = reader[8];

                            row++;
                        }
                    }

                    // Настройка внешнего вида ячеек
                    sheet.Rows[1].Style.HorizontalAlignment = HorizontalAlignment.Center;
                    sheet.Rows[1].Style.VerticalAlignment = VerticalAlignment.Center;
                    sheet.Cells.WrapText = true;
                    sheet.Cells[1, 1].Style.WrapText = true;
                    sheet.StandardWidth = 12;


                    ex.Visible = true; // Открытие Excel
                }
                
                // Очистить существующие серии диаграммы
                chart1.Series.Clear();

                // Создать новую серию для диаграммы
                var series = new Series();
                series.ChartType = SeriesChartType.Pie;

                // Добавить точки в диаграмму на основе данных из массива dataArray
                for (int i = 2; i < row; i++) // Начинаем с 2, так как первая строка - заголовки
                {
                    var id = dataArray[i, 0];
                    var amount = Convert.ToDouble(dataArray[i, 1]);
                    series.Points.AddXY(id.ToString(), amount);
                }
                
                // Добавить серию в диаграмму
                chart1.Series.Add(series);
                chart1.Series[0]["PieLabelStyle"] = "Disabled";
            }
            catch (Exception err)
            {
                MessageBox.Show("Произошла ошибка при работе с Excel: " + err.Message);
            }  
        }

        private void buttonReport2_Click(object sender, EventArgs e)
        {
            Excel.Application ex = new Excel.Application();
            Excel.Workbook wb = ex.Workbooks.Add();
            Excel.Worksheet sheet = wb.Sheets[1];

            try
            {
                // SQL-запрос для объединения данных
                string sql = @"
            SELECT 
                p.id AS ProductId, 
                p.name_prod AS ProductName,
                p.nds AS Nds,
                SUM(inv.paid) AS Total,
                SUM(inv.paid*(100-p.nds)/100) AS MinusNDS
            FROM 
                Invoices AS inv
            JOIN 
                Customers AS c ON inv.customer_id = c.id
            JOIN 
                Products AS p ON inv.product_id = p.id
            WHERE 
                inv.invoice_date <= @curDate2 and inv.invoice_date >= @curDate1
            GROUP BY 
                p.id, p.name_prod, p.nds
                ";

                int row = 2;
                object[,] dataArray = new object[100, 2];
                // Создание и настройка команды для выполнения SQL-запроса
                using (var command = new NpgsqlCommand(sql, con))
                {
                    command.Parameters.AddWithValue("@curDate1", dateStart.Value.Date);
                    command.Parameters.AddWithValue("@curDate2", dateEnd.Value.Date);

                    // Заголовки столбцов в Excel
                    sheet.Cells[1, 1].Value = "Номер товара";
                    sheet.Cells[1, 2].Value = "Название товара";
                    sheet.Cells[1, 3].Value = "НДС %";
                    sheet.Cells[1, 4].Value = "Выручка";
                    sheet.Cells[1, 5].Value = "Соотношение выручка/НДС";


                    // Выполнение SQL-запроса и заполнение данными в Excel
                    // Начинаем со второй строки, так как первую уже заполнили заголовками

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int col = 1; col <= 5; col++)
                            {
                                sheet.Cells[row, col].Value = reader[col - 1];
                            }
                            dataArray[row, 0] = reader[1]; // Столбец 1
                            dataArray[row, 1] = reader[4];

                            row++;
                        }
                    }

                    // Настройка внешнего вида ячеек
                    sheet.Rows[1].Style.HorizontalAlignment = HorizontalAlignment.Center;
                    sheet.Rows[1].Style.VerticalAlignment = VerticalAlignment.Center;
                    sheet.Cells.WrapText = true;
                    sheet.Cells[1, 1].Style.WrapText = true;
                    sheet.StandardWidth = 12;


                    ex.Visible = true; // Открытие Excel

                    // Очистить существующие серии диаграммы
                    chart2.Series.Clear();

                    // Создать новую серию для диаграммы
                    var series = new Series();
                    series.ChartType = SeriesChartType.Pie;

                    // Добавить точки в диаграмму на основе данных из массива dataArray
                    for (int i = 2; i < row; i++) // Начинаем с 2, так как первая строка - заголовки
                    {
                        var name = dataArray[i, 0];
                        var amount = Convert.ToDouble(dataArray[i, 1]);
                        series.Points.AddXY(name.ToString(), amount);
                    }

                    // Добавить серию в диаграмму
                    chart2.Series.Add(series);
                    chart2.Series[0]["PieLabelStyle"] = "Disabled";
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Произошла ошибка при работе с Excel: " + err.Message);
            }
        }
    }
}
