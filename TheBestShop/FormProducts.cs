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
using System.Windows.Forms.DataVisualization.Charting;

namespace TheBestShop
{
    public partial class FormProducts : Form
    {
        private NpgsqlConnection con;
        private string conString =
            "Host = 127.0.0.1; Username = postgres; Password = melman; Database = TheShop";
        public FormProducts()
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
            string sql1 = "INSERT INTO Products(name_prod, cost_prod, nds) VALUES(@name, @cost, @nds)";
            NpgsqlCommand cmd1 = new NpgsqlCommand(sql1, con);
            cmd1.Parameters.AddWithValue("name", this.tbnameProd.Text);

            string costString = this.tbCost.Text;
            float costValue;
            if (float.TryParse(costString, out costValue))
            {
                cmd1.Parameters.AddWithValue("cost", costValue);
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
                cmd1.Parameters.AddWithValue("nds", ndsValue);
            }
            else
            {
                Console.WriteLine("Ошибка преобразования строки в число.");
            }


            cmd1.Prepare();
            cmd1.ExecuteNonQuery();

            this.Close();
        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {

        }
    }
}
