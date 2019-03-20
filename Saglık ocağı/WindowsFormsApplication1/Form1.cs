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

    public partial class Form1 : Form
    {

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Data.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataReader oku;
        DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();

        }
        public class personel
        {
            public static string kad;
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                personel.kad = textBox1.Text;
                string ksifre = textBox2.Text;
                baglan.Open();
                komut.Connection = baglan;
                komut.CommandText = "SELECT*FROM kullan WHERE kad='" + textBox1.Text + "' AND ksifre='" + textBox2.Text + "'";
                oku = komut.ExecuteReader();
                if (oku.Read())
                {
                    Form2 ac = new Form2();
                    ac.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("kullanıcı adı veya şifre yanlış");
                }
            }
            else
            {
                MessageBox.Show("lütfen boş alan bırakmayınız");
            }
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
