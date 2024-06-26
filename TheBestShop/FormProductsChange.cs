﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TheBestShop
{
    public partial class FormProductsChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = TheShop";
        public FormProductsChange()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
            loadProducts();

        }

        

        public DataGridViewRow SelectedRow { get; set; }


        private void FormProductsChange_Load(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                // Заполнить поля данными из выбранной строки
                labelid.Text = SelectedRow.Cells["id"].Value.ToString();
                tbnameProd.Text = SelectedRow.Cells["name_prod"].Value.ToString();
                tbCost.Text = SelectedRow.Cells["cost_prod"].Value.ToString();

                float ndsValue = float.Parse(SelectedRow.Cells["nds"].Value.ToString());

                if (ndsValue == 10)
                {
                    cbNDS.SelectedIndex = 0;
                }
                else if (ndsValue == 15)
                {
                    cbNDS.SelectedIndex = 1;
                }
                else if (ndsValue == 20)
                {
                    cbNDS.SelectedIndex = 2;
                }
            }
        }

        private void btnChage_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Products SET name_prod=@name, cost_prod=@cost, nds=@nds WHERE id = @id";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sql, con);
            cmd2.Parameters.AddWithValue("name", this.tbnameProd.Text);

            string costString = this.tbCost.Text;
            float costValue;
            if (float.TryParse(costString, out costValue))
            {
                cmd2.Parameters.AddWithValue("cost", costValue);
            }
            else
            {
                MessageBox.Show("Неверный формат ввода стоимости. Пожалуйста, введите число.");

            }
            string ndsString = this.cbNDS.Text;
            string ndsValueString = ndsString.Replace("%", "");
            float ndsValue;
            if (float.TryParse(ndsValueString, out ndsValue))
            {
                cmd2.Parameters.AddWithValue("nds", ndsValue);
            }
            else
            {
                Console.WriteLine("Ошибка преобразования строки в число.");
            }

            int id = int.Parse(this.labelid.Text);
            Console.WriteLine(id);
            cmd2.Parameters.AddWithValue("id", id);
            cmd2.Prepare();
            cmd2.ExecuteNonQuery();
            this.Close();
        }
        private void loadProducts()
        {
            DataTable dt = new DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter("SELECT * FROM Products", con);
            adap.Fill(dt);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
