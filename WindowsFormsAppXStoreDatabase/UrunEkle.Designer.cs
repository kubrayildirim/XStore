
namespace WindowsFormsAppXStoreDatabase
{
	partial class UrunEkle
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cb_Kategori = new System.Windows.Forms.ComboBox();
			this.categoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.xStoreDatabaseDataSet = new WindowsFormsAppXStoreDatabase.XStoreDatabaseDataSet();
			this.label2 = new System.Windows.Forms.Label();
			this.btn_Ekle = new System.Windows.Forms.Button();
			this.txt_StisFiyati = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_AlisFiyati = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Miktar = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_UrunAdi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_BarkodNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.categoriesTableAdapter = new WindowsFormsAppXStoreDatabase.XStoreDatabaseDataSetTableAdapters.CategoriesTableAdapter();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.xStoreDatabaseDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cb_Kategori);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btn_Ekle);
			this.groupBox1.Controls.Add(this.txt_StisFiyati);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txt_AlisFiyati);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txt_Miktar);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_UrunAdi);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txt_BarkodNo);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(34, 70);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 247);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Urun  Ekle";
			// 
			// cb_Kategori
			// 
			this.cb_Kategori.DataSource = this.categoriesBindingSource;
			this.cb_Kategori.DisplayMember = "CategoryName";
			this.cb_Kategori.FormattingEnabled = true;
			this.cb_Kategori.Location = new System.Drawing.Point(83, 58);
			this.cb_Kategori.Name = "cb_Kategori";
			this.cb_Kategori.Size = new System.Drawing.Size(100, 21);
			this.cb_Kategori.TabIndex = 17;
			this.cb_Kategori.ValueMember = "CategoryID";
			// 
			// categoriesBindingSource
			// 
			this.categoriesBindingSource.DataMember = "Categories";
			this.categoriesBindingSource.DataSource = this.xStoreDatabaseDataSet;
			// 
			// xStoreDatabaseDataSet
			// 
			this.xStoreDatabaseDataSet.DataSetName = "XStoreDatabaseDataSet";
			this.xStoreDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(31, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 16;
			this.label2.Text = "Kategori";
			// 
			// btn_Ekle
			// 
			this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_Ekle.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_Ekle.Location = new System.Drawing.Point(84, 198);
			this.btn_Ekle.Name = "btn_Ekle";
			this.btn_Ekle.Size = new System.Drawing.Size(93, 30);
			this.btn_Ekle.TabIndex = 15;
			this.btn_Ekle.Text = "Ekle";
			this.btn_Ekle.UseVisualStyleBackColor = false;
			this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
			// 
			// txt_StisFiyati
			// 
			this.txt_StisFiyati.Location = new System.Drawing.Point(84, 160);
			this.txt_StisFiyati.Name = "txt_StisFiyati";
			this.txt_StisFiyati.Size = new System.Drawing.Size(100, 20);
			this.txt_StisFiyati.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Satiş Fiyatı";
			// 
			// txt_AlisFiyati
			// 
			this.txt_AlisFiyati.Location = new System.Drawing.Point(84, 134);
			this.txt_AlisFiyati.Name = "txt_AlisFiyati";
			this.txt_AlisFiyati.Size = new System.Drawing.Size(100, 20);
			this.txt_AlisFiyati.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 137);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Alış Fiyatı";
			// 
			// txt_Miktar
			// 
			this.txt_Miktar.Location = new System.Drawing.Point(84, 108);
			this.txt_Miktar.Name = "txt_Miktar";
			this.txt_Miktar.Size = new System.Drawing.Size(100, 20);
			this.txt_Miktar.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Miktarı";
			// 
			// txt_UrunAdi
			// 
			this.txt_UrunAdi.Location = new System.Drawing.Point(84, 82);
			this.txt_UrunAdi.Name = "txt_UrunAdi";
			this.txt_UrunAdi.Size = new System.Drawing.Size(100, 20);
			this.txt_UrunAdi.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 85);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Urun Adı";
			// 
			// txt_BarkodNo
			// 
			this.txt_BarkodNo.Location = new System.Drawing.Point(84, 35);
			this.txt_BarkodNo.Name = "txt_BarkodNo";
			this.txt_BarkodNo.Size = new System.Drawing.Size(100, 20);
			this.txt_BarkodNo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Barkod No";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(250, 74);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(482, 243);
			this.dataGridView1.TabIndex = 5;
			// 
			// categoriesTableAdapter
			// 
			this.categoriesTableAdapter.ClearBeforeFill = true;
			// 
			// UrunEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(778, 367);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "UrunEkle";
			this.Text = "UrunEkle";
			this.Load += new System.EventHandler(this.UrunEkle_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.categoriesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.xStoreDatabaseDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ComboBox cb_Kategori;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_Ekle;
		private System.Windows.Forms.TextBox txt_StisFiyati;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_AlisFiyati;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_Miktar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_UrunAdi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_BarkodNo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private XStoreDatabaseDataSet xStoreDatabaseDataSet;
		private System.Windows.Forms.BindingSource categoriesBindingSource;
		private XStoreDatabaseDataSetTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
	}
}