using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestShop
{
    public partial class FormInvoicesChange : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = TheShop";
        public FormInvoicesChange()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();

            string sql = "SELECT lastname, firstname, patronym FROM Customers";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            cbCustomer.Items.Clear();
            while (reader.Read())
            {
                cbCustomer.Items.Add(reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2));
            }
            reader.Close();

            string sql1 = "SELECT name_prod FROM products";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            NpgsqlDataReader reader1 = cmd1.ExecuteReader();
            cbProd.Items.Clear();
            while (reader1.Read())
            {
                cbProd.Items.Add(reader1.GetString(0));
            }
            reader1.Close();
        }



        public DataGridViewRow SelectedRow { get; set; }

        private void FormInvoicesChange_Load(object sender, EventArgs e)
        {
            if (SelectedRow != null)
            {
                // Заполнить поля данными из выбранной строки
                labelid.Text = SelectedRow.Cells["id"].Value.ToString();
                int customer_id = Convert.ToInt32(SelectedRow.Cells["customer_id"].Value);
                int product_id = Convert.ToInt32(SelectedRow.Cells["product_id"].Value);


                string sql = "SELECT id, lastname, firstname, patronym FROM Customers";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    if (customer_id == Convert.ToInt32(reader.GetValue(0)))
                    {
                        string itemToSelect = reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3);
                        cbCustomer.SelectedItem = itemToSelect;
                        break; // прерываем цикл после выбора нужного элемента 
                    }
                }
                reader.Close();

                string sql1 = "SELECT id, name_prod FROM Products";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
                NpgsqlDataReader reader1 = cmd1.ExecuteReader();
                while (reader1.Read())
                {
                    if (product_id == Convert.ToInt32(reader1.GetValue(0)))
                    {
                        string itemToSelect = reader1.GetString(1);
                        cbProd.SelectedItem = itemToSelect;
                        break; // прерываем цикл после выбора нужного элемента 
                    }
                }
                reader1.Close();

                this.dtpInv.Text = SelectedRow.Cells["invoice_date"].Value.ToString();
                this.nudQuan.Value = int.Parse(SelectedRow.Cells["quantity"].Value.ToString());
                this.tbPaid.Text = SelectedRow.Cells["paid"].Value.ToString();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT id, lastname, firstname, patronym FROM Customers";
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            int customer_id = 0;
            while (reader.Read())
                if (cbCustomer.SelectedItem.ToString() == reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3))
                    customer_id = Convert.ToInt32(reader.GetValue(0));
            reader.Close();

            string sql1 = "SELECT id, name_prod FROM products";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            NpgsqlDataReader reader1 = cmd1.ExecuteReader();
            int product_id = 0;
            while (reader1.Read())
                if (cbProd.SelectedItem.ToString() == reader1.GetString(1))
                    product_id = Convert.ToInt32(reader1.GetValue(0));
            reader1.Close();

            string sql2 = "UPDATE Invoices SET invoice_date=@invoice_date, payment_date=@payment_date, " +
                "paid=@paid, quantity=@quantity, customer_id=@customer_id, product_id=@product_id WHERE id = @id";
            NpgsqlCommand cmd2 = new NpgsqlCommand(sql2, con);

            DateTime invoiceDate = this.dtpInv.Value;
            DateTime paymentDate = invoiceDate.AddDays(20);
            cmd2.Parameters.AddWithValue("invoice_date", invoiceDate);
            cmd2.Parameters.AddWithValue("payment_date", paymentDate);
            cmd2.Parameters.AddWithValue("quantity", int.Parse(this.nudQuan.Value.ToString()));
            cmd2.Parameters.AddWithValue("paid", float.Parse(this.tbPaid.Text));
            cmd2.Parameters.AddWithValue("customer_id", customer_id);
            cmd2.Parameters.AddWithValue("product_id", product_id);
            int id = int.Parse(this.labelid.Text);
            Console.WriteLine(id);
            cmd2.Parameters.AddWithValue("id", id);
            cmd2.Prepare();
            cmd2.ExecuteNonQuery();
            this.Close();
        }
    }
}
