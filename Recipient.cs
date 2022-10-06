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
    public partial class Recipient : Form
    {
        public Recipient()
        {
            InitializeComponent();
            getinfo();

        }

        private void getinfo()
        {
            string query = "SELECT id_rec, rec_fio, rec_birth, rec_address, rec_telephone from recipient";
            MySqlConnection conn = DBUtils.GetDBConnection();
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            try
            {
                conn.Open();
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
                dataGridView2.ClearSelection();
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

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
