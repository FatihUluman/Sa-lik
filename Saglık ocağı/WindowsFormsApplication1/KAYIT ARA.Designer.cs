namespace WindowsFormsApplication1
{
    partial class KAYIT_ARA
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tckimlikDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.babaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saglikgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doktorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hastalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataDataSet = new WindowsFormsApplication1.DataDataSet();
            this.button2 = new System.Windows.Forms.Button();
            this.hastalarTableAdapter = new WindowsFormsApplication1.DataDataSetTableAdapters.hastalarTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(214, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "TcKimlik";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tckimlikDataGridViewTextBoxColumn,
            this.adiDataGridViewTextBoxColumn,
            this.soyadiDataGridViewTextBoxColumn,
            this.babaDataGridViewTextBoxColumn,
            this.saglikgDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.dogumtDataGridViewTextBoxColumn,
            this.dogumyDataGridViewTextBoxColumn,
            this.kanDataGridViewTextBoxColumn,
            this.doktorDataGridViewTextBoxColumn,
            this.personel});
            this.dataGridView1.DataSource = this.hastalarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 62);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 287);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // tckimlikDataGridViewTextBoxColumn
            // 
            this.tckimlikDataGridViewTextBoxColumn.DataPropertyName = "tckimlik";
            this.tckimlikDataGridViewTextBoxColumn.HeaderText = "tckimlik";
            this.tckimlikDataGridViewTextBoxColumn.Name = "tckimlikDataGridViewTextBoxColumn";
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
            // babaDataGridViewTextBoxColumn
            // 
            this.babaDataGridViewTextBoxColumn.DataPropertyName = "baba";
            this.babaDataGridViewTextBoxColumn.HeaderText = "baba";
            this.babaDataGridViewTextBoxColumn.Name = "babaDataGridViewTextBoxColumn";
            // 
            // saglikgDataGridViewTextBoxColumn
            // 
            this.saglikgDataGridViewTextBoxColumn.DataPropertyName = "saglikg";
            this.saglikgDataGridViewTextBoxColumn.HeaderText = "saglikg";
            this.saglikgDataGridViewTextBoxColumn.Name = "saglikgDataGridViewTextBoxColumn";
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            // 
            // dogumtDataGridViewTextBoxColumn
            // 
            this.dogumtDataGridViewTextBoxColumn.DataPropertyName = "dogumt";
            this.dogumtDataGridViewTextBoxColumn.HeaderText = "dogumt";
            this.dogumtDataGridViewTextBoxColumn.Name = "dogumtDataGridViewTextBoxColumn";
            // 
            // dogumyDataGridViewTextBoxColumn
            // 
            this.dogumyDataGridViewTextBoxColumn.DataPropertyName = "dogumy";
            this.dogumyDataGridViewTextBoxColumn.HeaderText = "dogumy";
            this.dogumyDataGridViewTextBoxColumn.Name = "dogumyDataGridViewTextBoxColumn";
            // 
            // kanDataGridViewTextBoxColumn
            // 
            this.kanDataGridViewTextBoxColumn.DataPropertyName = "kan";
            this.kanDataGridViewTextBoxColumn.HeaderText = "kan";
            this.kanDataGridViewTextBoxColumn.Name = "kanDataGridViewTextBoxColumn";
            // 
            // doktorDataGridViewTextBoxColumn
            // 
            this.doktorDataGridViewTextBoxColumn.DataPropertyName = "doktor";
            this.doktorDataGridViewTextBoxColumn.HeaderText = "doktor";
            this.doktorDataGridViewTextBoxColumn.Name = "doktorDataGridViewTextBoxColumn";
            // 
            // personel
            // 
            this.personel.DataPropertyName = "personel";
            this.personel.HeaderText = "personel";
            this.personel.Name = "personel";
            // 
            // hastalarBindingSource
            // 
            this.hastalarBindingSource.DataMember = "hastalar";
            this.hastalarBindingSource.DataSource = this.dataDataSet;
            // 
            // dataDataSet
            // 
            this.dataDataSet.DataSetName = "DataDataSet";
            this.dataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(469, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 38);
            this.button2.TabIndex = 8;
            this.button2.Text = "SİL";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hastalarTableAdapter
            // 
            this.hastalarTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(557, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 38);
            this.button3.TabIndex = 9;
            this.button3.Text = "GERİ";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Blue;
            this.button1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(143, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 38);
            this.button1.TabIndex = 10;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // KAYIT_ARA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(851, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "KAYIT_ARA";
            this.Text = "KAYIT_ARA";
            this.Load += new System.EventHandler(this.KAYIT_ARA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hastalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private DataDataSet dataDataSet;
        private System.Windows.Forms.BindingSource hastalarBindingSource;
        private DataDataSetTableAdapters.hastalarTableAdapter hastalarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tckimlikDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn babaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saglikgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doktorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}