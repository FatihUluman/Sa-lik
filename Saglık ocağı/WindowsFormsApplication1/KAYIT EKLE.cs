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
    public partial class KAYIT_EKLE : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Data.mdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adap = new OleDbDataAdapter();
        DataTable tablo = new DataTable();
        public KAYIT_EKLE()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {

                baglan.Open();

                String doktor1 = "Prof.Dr.Fatih ULUMAN", doktor2 = "Prof.Dr.Kübra ÖZER", doktor3 = "Prof.Dr.Nisanur AĞCA", doktor4 = "Prof.Dr.Müptezel HASTA";
                if (comboBox1.SelectedIndex == 0)
                {
                    textBox6.Text = doktor1.ToString();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    textBox6.Text = doktor2.ToString();
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    textBox6.Text = doktor3.ToString();
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    textBox6.Text = doktor4.ToString();
                }
                string ekle ="INSERT INTO hastalar(tckimlik,adi,soyadi,baba,saglikg,cinsiyet,dogumt,dogumy,kan,doktor,personel) VALUES ('"+textBox1.Text+"',@adi,@soyadi,@baba,@saglikg,@cinsiyet,@dogumt,@dogumy,@kan,@doktor,@personel)";
                OleDbCommand komut = new OleDbCommand(ekle, baglan);
                komut.Parameters.AddWithValue("@tckimlik",long.Parse(textBox1.Text));
                komut.Parameters.AddWithValue("@adı", textBox2.Text);
                komut.Parameters.AddWithValue("@soyadı", textBox3.Text);
                komut.Parameters.AddWithValue("@baba", textBox4.Text);
                komut.Parameters.AddWithValue("@saglikg", comboBox1.Text);
                if (radioButton1.Checked)
                {
                    komut.Parameters.AddWithValue("@cinsiyet", radioButton1.Text);
                }
                else if (radioButton2.Checked)
                {
                    komut.Parameters.AddWithValue("@cinsiyet", radioButton2.Text);
                }
                komut.Parameters.AddWithValue("dogumt", dateTimePicker1.Text);
                komut.Parameters.AddWithValue("@dogumy", textBox5.Text);
                komut.Parameters.AddWithValue("@kan", comboBox2.Text);
                komut.Parameters.AddWithValue("@doktor", textBox6.Text);
                komut.Parameters.AddWithValue("@personel", Form1.personel.kad);
                komut.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("kayıt başarılı");
                
               

            }

            else
            {
                MessageBox.Show("lütfen bütün alanları doldurunuz!!!");
            }
           
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            comboBox1.Text = "";
            dateTimePicker1.ResetText();
            textBox5.Clear();
            comboBox2.Text = "";
            textBox6.Clear();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void KAYIT_EKLE_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 n = new Form2();
            n.Show();
            n.Hide();



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            long sayi = long.Parse(textBox1.Text);
             int i = 0;
            
                 while (sayi > 0)
                 {
                     sayi /= 10;
                     i++;
                     if (i >11)
                     {
                         MessageBox.Show("lütfen 11 basamaklı bir sayı giriniz");
                     }
                 }
        
        }
    }
}
