using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project
{
    public partial class Orrder3 : Form
    {
        public Orrder3()
        {
            InitializeComponent();
            getinfo();

        }

        private void getinfo()
        {
            string query = "SELECT id_order, id_sender, id_recipient, or_dateor, or_deliverydate, id_courier, id_transport from orrder";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.ClearSelection();
                //dataGridView1.Columns[0].Visible = false;
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Произошла непредвиденая ошибка!" + Environment.NewLine + ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
