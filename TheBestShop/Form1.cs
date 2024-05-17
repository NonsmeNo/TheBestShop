using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
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

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите ячейку для изменения.");
                return;
            }

            DataGridViewCell selectedCell = dataGridView1.SelectedCells[0];
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedCell.RowIndex];
            FormCustomersChange f = new FormCustomersChange();
            f.SelectedRow = selectedRow;
            f.ShowDialog();
            loadCustomers();

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void Customers_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd1_Click(object sender, EventArgs e)
        {
            FormCustomers f = new FormCustomers();
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
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            FormProducts f = new FormProducts();
            f.ShowDialog();
            loadProducts();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
