using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBestShop
{
    public partial class FormInvoices : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = TheShop";
        public FormInvoices()
        {
            InitializeComponent();
            con = new NpgsqlConnection(conString);
            con.Open();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private DataTable GetProductsData()
        {
            DataTable productsData = new DataTable();

            // Выполнение SQL-запроса для получения данных о товарах
            using (NpgsqlCommand command = new NpgsqlCommand("SELECT name_prod FROM Products", con))
            {
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                adapter.Fill(productsData);
            }

            return productsData;
        }

        

        private void FormInvoices_Load(object sender, EventArgs e)
        {
            DataTable productsData = GetProductsData();

            // Проверяем, что данные получены
            if (productsData != null && productsData.Rows.Count > 0)
            {
                cbProd.Items.Clear();
                foreach (DataRow row in productsData.Rows)
                {
                    string productName = row["name_prod"].ToString();
                    cbProd.Items.Add(productName);
                }
                cbProd.SelectedIndex = 0;
            }
        }
    }
}
