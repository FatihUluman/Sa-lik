using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class KAYIT_ARA : Form
    {

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Data.mdb");
        OleDbCommand komut = new OleDbCommand();
    
       
       

        public KAYIT_ARA()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void KAYIT_ARA_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'dataDataSet.hastalar' table. You can move, or remove it, as needed.
            this.hastalarTableAdapter.Fill(this.dataDataSet.hastalar);
            string sql = "SELECT *FROM hastalar";
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Data.mdb");
            OleDbDataAdapter da = new OleDbDataAdapter(sql, baglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button1_Click(object sender, EventArgs e)
        {
                     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçiniz.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f = new Form2();
            f.Show();
            f.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            long sayi = long.Parse(textBox1.Text);
            int i = 0;

            while (sayi > 0)
            {
                sayi /= 10;
                i++;
                if (i > 11)
                {
                    MessageBox.Show("lütfen 11 basamaklı bir sayı giriniz");
                    
                }            
            }
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string tckimlik = textBox1.Text;

            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == tckimlik)
                            {
                                cell.Style.BackColor = Color.DarkTurquoise; 
                                break;
                            }
                        }
                    }
                }
            }
           

        }

    

    
    }
}
