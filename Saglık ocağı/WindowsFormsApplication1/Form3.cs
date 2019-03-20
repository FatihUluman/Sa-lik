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
    public partial class Form3 : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\\Data.mdb");
        OleDbCommand kulekle = new OleDbCommand();
        OleDbDataAdapter adap = new OleDbDataAdapter();
        DataTable dt = new DataTable();
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text !=""&&textBox4.Text !=""&&textBox5.Text!=""&&comboBox1.Text!=""&&comboBox2.Text!=""&&comboBox3.Text!=""&&textBox6.Text!="")
            {
                baglan.Open();
                string kekle = "INSERT INTO kullan(kad,ksifre,adi,soyadi,ünvani,alani,numara,mail) VALUES (@kad,@ksifre,@adi,@soyadi,@ünvani,@alani,@numara,@mail)";
                OleDbCommand kulekle = new OleDbCommand(kekle, baglan);
                kulekle.Parameters.AddWithValue("@kad", textBox1.Text);
                kulekle.Parameters.AddWithValue("@ksifre", textBox2.Text);
                kulekle.Parameters.AddWithValue("@adi", textBox3.Text);
                kulekle.Parameters.AddWithValue("@soyadi", textBox4.Text);
                kulekle.Parameters.AddWithValue("@ünvani",comboBox1.Text);
                kulekle.Parameters.AddWithValue("@alani", comboBox2.Text);
                kulekle.Parameters.AddWithValue("@numara", Convert.ToDouble(textBox5.Text));
                kulekle.Parameters.AddWithValue("@mail", textBox6.Text+comboBox3.Text);
                kulekle.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("kayıt başarılı");
            }
            else
            {
                MessageBox.Show("boş alan bırakmayınız");
            }
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();     
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            comboBox2.Items.RemoveAt(comboBox2.SelectedIndex);
            comboBox3.Items.RemoveAt(comboBox3.SelectedIndex);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 ac = new Form2();
            ac.Show();
            this.Hide();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataDataSet.kullan' table. You can move, or remove it, as needed.
            this.kullanTableAdapter.Fill(this.dataDataSet.kullan);

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void kullanBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {        

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
          

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillBy1ToolStripButton_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
