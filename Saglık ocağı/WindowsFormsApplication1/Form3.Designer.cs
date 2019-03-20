namespace WindowsFormsApplication1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.kullanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new WindowsFormsApplication1.DataDataSet();
            this.kullanTableAdapter = new WindowsFormsApplication1.DataDataSetTableAdapters.kullanTableAdapter();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ünvaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alaniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.kullanBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.kullanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(685, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(429, 125);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox2.Location = new System.Drawing.Point(429, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 2;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(288, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "KULLANICI ADI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(299, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "ŞİFRE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(685, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(362, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "YENİ KULLANICI EKLEMEK İÇİN AŞAĞIDA BULUNAN BOŞ ALANLARI DOLDURUNUZ.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox3.Location = new System.Drawing.Point(133, 31);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "ADI";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "SOYADI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(133, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cambria", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "ÜNVANI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Cambria", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "ALANI";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "hemşir",
            "hemşire",
            "uzman dr.",
            "yrd.doç.dr",
            "doç.dr",
            "prof.dr"});
            this.comboBox1.Location = new System.Drawing.Point(133, 129);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Kardiyoloji",
            "Nöroloji",
            "Dahiliye",
            "Ortopedi",
            "Üroloji",
            "Kbb"});
            this.comboBox2.Location = new System.Drawing.Point(133, 178);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Cambria", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(278, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 22);
            this.label8.TabIndex = 16;
            this.label8.Text = "İLETİŞİM NUMARASI";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(288, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "E-POSTA";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox5.Location = new System.Drawing.Point(429, 30);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 18;
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "@gmail.com",
            "@hotmail.com"});
            this.comboBox3.Location = new System.Drawing.Point(548, 78);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(52, 21);
            this.comboBox3.TabIndex = 19;
            // 
            // kullanBindingSource
            // 
            this.kullanBindingSource.DataMember = "kullan";
            this.kullanBindingSource.DataSource = this.dataDataSetBindingSource;
            this.kullanBindingSource.CurrentChanged += new System.EventHandler(this.kullanBindingSource_CurrentChanged);
            // 
            // dataDataSetBindingSource
            // 
            this.dataDataSetBindingSource.DataSource = this.dataDataSet;
            this.dataDataSetBindingSource.Position = 0;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kullanTableAdapter
            // 
            this.kullanTableAdapter.ClearBeforeFill = true;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Cambria", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox6.Location = new System.Drawing.Point(429, 78);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 21;
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kadDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.ünvaniDataGridViewTextBoxColumn,
            this.alaniDataGridViewTextBoxColumn,
            this.numara,
            this.mail});
            this.dataGridView1.DataSource = this.kullanBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(27, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(745, 180);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_2);
            // 
            // kadDataGridViewTextBoxColumn
            // 
            this.kadDataGridViewTextBoxColumn.DataPropertyName = "kad";
            this.kadDataGridViewTextBoxColumn.HeaderText = "kad";
            this.kadDataGridViewTextBoxColumn.Name = "kadDataGridViewTextBoxColumn";
            // 
            // adiDataGridViewTextBoxColumn
            // 
            this.adiDataGridViewTextBoxColumn.DataPropertyName = "adi";
            this.adiDataGridViewTextBoxColumn.HeaderText = "adi";
            this.adiDataGridViewTextBoxColumn.Name = "adiDataGridViewTextBoxColumn";
            // 
            // soyadiDataGridViewTextBoxColumn
            // 
            this.soyadiDataGridViewTextBoxColumn.DataPropertyName = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.HeaderText = "soyadi";
            this.soyadiDataGridViewTextBoxColumn.Name = "soyadiDataGridViewTextBoxColumn";
            // 
            // ünvaniDataGridViewTextBoxColumn
            // 
            this.ünvaniDataGridViewTextBoxColumn.DataPropertyName = "ünvani";
            this.ünvaniDataGridViewTextBoxColumn.HeaderText = "ünvani";
            this.ünvaniDataGridViewTextBoxColumn.Name = "ünvaniDataGridViewTextBoxColumn";
            // 
            // alaniDataGridViewTextBoxColumn
            // 
            this.alaniDataGridViewTextBoxColumn.DataPropertyName = "alani";
            this.alaniDataGridViewTextBoxColumn.HeaderText = "alani";
            this.alaniDataGridViewTextBoxColumn.Name = "alaniDataGridViewTextBoxColumn";
            // 
            // numara
            // 
            this.numara.DataPropertyName = "numara";
            this.numara.HeaderText = "numara";
            this.numara.Name = "numara";
            // 
            // mail
            // 
            this.mail.DataPropertyName = "mail";
            this.mail.HeaderText = "mail";
            this.mail.Name = "mail";
            // 
            // kullanBindingSource2
            // 
            this.kullanBindingSource2.DataMember = "kullan";
            this.kullanBindingSource2.DataSource = this.dataDataSetBindingSource;
            // 
            // kullanBindingSource1
            // 
            this.kullanBindingSource1.DataMember = "kullan";
            this.kullanBindingSource1.DataSource = this.dataDataSet;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.Location = new System.Drawing.Point(685, 78);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 32);
            this.button3.TabIndex = 25;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ımageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(801, 417);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form3";
            this.Text = "KULLANICI EKLE";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kullanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullanBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource dataDataSetBindingSource;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource kullanBindingSource;
        private DataDataSetTableAdapters.kullanTableAdapter kullanTableAdapter;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource kullanBindingSource1;
        private System.Windows.Forms.BindingSource kullanBindingSource2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn kadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ünvaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alaniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numara;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.ImageList ımageList1;
    }
}