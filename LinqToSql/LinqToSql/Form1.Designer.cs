namespace LinqToSQL
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.cmbTedarikci = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numFiyat = new System.Windows.Forms.NumericUpDown();
            this.numStok = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdbUrunAdi = new System.Windows.Forms.RadioButton();
            this.rdbFiyat = new System.Windows.Forms.RadioButton();
            this.rdbStok = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(937, 356);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(37, 28);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(100, 23);
            this.txtUrunAdi.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategori";
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(149, 27);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 23);
            this.cmbKategori.TabIndex = 4;
            // 
            // cmbTedarikci
            // 
            this.cmbTedarikci.FormattingEnabled = true;
            this.cmbTedarikci.Location = new System.Drawing.Point(286, 28);
            this.cmbTedarikci.Name = "cmbTedarikci";
            this.cmbTedarikci.Size = new System.Drawing.Size(121, 23);
            this.cmbTedarikci.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tedarikçi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Fiyat";
            // 
            // numFiyat
            // 
            this.numFiyat.Location = new System.Drawing.Point(424, 27);
            this.numFiyat.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numFiyat.Name = "numFiyat";
            this.numFiyat.Size = new System.Drawing.Size(89, 23);
            this.numFiyat.TabIndex = 8;
            // 
            // numStok
            // 
            this.numStok.Location = new System.Drawing.Point(531, 27);
            this.numStok.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numStok.Name = "numStok";
            this.numStok.Size = new System.Drawing.Size(89, 23);
            this.numStok.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(531, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Stok";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(644, 28);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(725, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(806, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Güncelle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(65, 447);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 451);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filtre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hizala";
            // 
            // rdbUrunAdi
            // 
            this.rdbUrunAdi.AutoSize = true;
            this.rdbUrunAdi.Location = new System.Drawing.Point(71, 57);
            this.rdbUrunAdi.Name = "rdbUrunAdi";
            this.rdbUrunAdi.Size = new System.Drawing.Size(72, 19);
            this.rdbUrunAdi.TabIndex = 17;
            this.rdbUrunAdi.TabStop = true;
            this.rdbUrunAdi.Text = "Ürün Adı";
            this.rdbUrunAdi.UseVisualStyleBackColor = true;
            this.rdbUrunAdi.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbFiyat
            // 
            this.rdbFiyat.AutoSize = true;
            this.rdbFiyat.Location = new System.Drawing.Point(150, 56);
            this.rdbFiyat.Name = "rdbFiyat";
            this.rdbFiyat.Size = new System.Drawing.Size(50, 19);
            this.rdbFiyat.TabIndex = 18;
            this.rdbFiyat.TabStop = true;
            this.rdbFiyat.Text = "Fiyat";
            this.rdbFiyat.UseVisualStyleBackColor = true;
            this.rdbFiyat.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdbStok
            // 
            this.rdbStok.AutoSize = true;
            this.rdbStok.Location = new System.Drawing.Point(206, 56);
            this.rdbStok.Name = "rdbStok";
            this.rdbStok.Size = new System.Drawing.Size(48, 19);
            this.rdbStok.TabIndex = 19;
            this.rdbStok.TabStop = true;
            this.rdbStok.Text = "Stok";
            this.rdbStok.UseVisualStyleBackColor = true;
            this.rdbStok.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 482);
            this.Controls.Add(this.rdbStok);
            this.Controls.Add(this.rdbFiyat);
            this.Controls.Add(this.rdbUrunAdi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.numStok);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numFiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbTedarikci);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbKategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtUrunAdi;
        private Label label2;
        private ComboBox cmbKategori;
        private ComboBox cmbTedarikci;
        private Label label3;
        private Label label4;
        private NumericUpDown numFiyat;
        private NumericUpDown numStok;
        private Label label5;
        private Button btnEkle;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private Label label6;
        private Label label7;
        private RadioButton rdbUrunAdi;
        private RadioButton rdbFiyat;
        private RadioButton rdbStok;
    }
}