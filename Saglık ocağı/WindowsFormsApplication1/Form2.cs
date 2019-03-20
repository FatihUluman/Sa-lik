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
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KAYIT_EKLE a = new KAYIT_EKLE();
            a.Show();

         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            KAYIT_ARA b = new KAYIT_ARA();
            b.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 c = new Form3();
            c.Show();
            this.Hide();
        }
    }
}
