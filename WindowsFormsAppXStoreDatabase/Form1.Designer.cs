
namespace WindowsFormsAppXStoreDatabase
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label6 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lbl_GenelToplam = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.btn_SatisIptal = new System.Windows.Forms.Button();
			this.btn_Sil = new System.Windows.Forms.Button();
			this.btn_SatisYap = new System.Windows.Forms.Button();
			this.btn_Ekle = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_ToplamFiyat = new System.Windows.Forms.TextBox();
			this.txt_Miktari = new System.Windows.Forms.TextBox();
			this.txt_UrunAdi = new System.Windows.Forms.TextBox();
			this.txt_Barkod = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_Telefon = new System.Windows.Forms.TextBox();
			this.txt_SatisFiyati = new System.Windows.Forms.TextBox();
			this.txt_TC = new System.Windows.Forms.TextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txt_pId = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Txt_AdSoyad = new System.Windows.Forms.TextBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_Cid = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_MusteriListele = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_SatıslarıListele = new System.Windows.Forms.Button();
			this.btn_UrunListele = new System.Windows.Forms.Button();
			this.btn_UrunEkle = new System.Windows.Forms.Button();
			this.panelMenu = new System.Windows.Forms.Panel();
			this.btn_MusteriEkle = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panelMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 95);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(38, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Miktarı";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(15, 26);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Barkod No";
			// 
			// lbl_GenelToplam
			// 
			this.lbl_GenelToplam.AutoSize = true;
			this.lbl_GenelToplam.Location = new System.Drawing.Point(548, 257);
			this.lbl_GenelToplam.Name = "lbl_GenelToplam";
			this.lbl_GenelToplam.Size = new System.Drawing.Size(10, 13);
			this.lbl_GenelToplam.TabIndex = 17;
			this.lbl_GenelToplam.Text = "-";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(440, 257);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(102, 13);
			this.label9.TabIndex = 16;
			this.label9.Text = "GENEL TOPLAM";
			// 
			// btn_SatisIptal
			// 
			this.btn_SatisIptal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_SatisIptal.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_SatisIptal.Location = new System.Drawing.Point(641, 284);
			this.btn_SatisIptal.Name = "btn_SatisIptal";
			this.btn_SatisIptal.Size = new System.Drawing.Size(95, 33);
			this.btn_SatisIptal.TabIndex = 15;
			this.btn_SatisIptal.Text = "Satış iptal";
			this.btn_SatisIptal.UseVisualStyleBackColor = false;
			this.btn_SatisIptal.Click += new System.EventHandler(this.btn_SatisIptal_Click);
			// 
			// btn_Sil
			// 
			this.btn_Sil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_Sil.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_Sil.Location = new System.Drawing.Point(277, 279);
			this.btn_Sil.Name = "btn_Sil";
			this.btn_Sil.Size = new System.Drawing.Size(101, 36);
			this.btn_Sil.TabIndex = 14;
			this.btn_Sil.Text = "Sil";
			this.btn_Sil.UseVisualStyleBackColor = false;
			this.btn_Sil.Click += new System.EventHandler(this.btn_Sil_Click);
			// 
			// btn_SatisYap
			// 
			this.btn_SatisYap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_SatisYap.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_SatisYap.Location = new System.Drawing.Point(641, 248);
			this.btn_SatisYap.Name = "btn_SatisYap";
			this.btn_SatisYap.Size = new System.Drawing.Size(95, 36);
			this.btn_SatisYap.TabIndex = 13;
			this.btn_SatisYap.Text = "Satış Yap";
			this.btn_SatisYap.UseVisualStyleBackColor = false;
			this.btn_SatisYap.Click += new System.EventHandler(this.btn_SatisYap_Click);
			// 
			// btn_Ekle
			// 
			this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_Ekle.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_Ekle.Location = new System.Drawing.Point(277, 246);
			this.btn_Ekle.Name = "btn_Ekle";
			this.btn_Ekle.Size = new System.Drawing.Size(101, 34);
			this.btn_Ekle.TabIndex = 12;
			this.btn_Ekle.Text = "Ekle";
			this.btn_Ekle.UseVisualStyleBackColor = false;
			this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(253, 21);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(483, 219);
			this.dataGridView1.TabIndex = 11;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(25, 69);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 7;
			this.label5.Text = "Urun Adı";
			// 
			// txt_ToplamFiyat
			// 
			this.txt_ToplamFiyat.Location = new System.Drawing.Point(83, 143);
			this.txt_ToplamFiyat.Name = "txt_ToplamFiyat";
			this.txt_ToplamFiyat.Size = new System.Drawing.Size(95, 20);
			this.txt_ToplamFiyat.TabIndex = 5;
			// 
			// txt_Miktari
			// 
			this.txt_Miktari.Location = new System.Drawing.Point(83, 92);
			this.txt_Miktari.Name = "txt_Miktari";
			this.txt_Miktari.Size = new System.Drawing.Size(95, 20);
			this.txt_Miktari.TabIndex = 3;
			this.txt_Miktari.TextChanged += new System.EventHandler(this.txt_Miktari_TextChanged);
			// 
			// txt_UrunAdi
			// 
			this.txt_UrunAdi.Location = new System.Drawing.Point(83, 66);
			this.txt_UrunAdi.Name = "txt_UrunAdi";
			this.txt_UrunAdi.Size = new System.Drawing.Size(95, 20);
			this.txt_UrunAdi.TabIndex = 2;
			// 
			// txt_Barkod
			// 
			this.txt_Barkod.Location = new System.Drawing.Point(83, 19);
			this.txt_Barkod.Name = "txt_Barkod";
			this.txt_Barkod.Size = new System.Drawing.Size(95, 20);
			this.txt_Barkod.TabIndex = 1;
			this.txt_Barkod.TextChanged += new System.EventHandler(this.txt_Barkod_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Telefon";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(22, 69);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Ad Soyad";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(54, 26);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(21, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "TC";
			// 
			// txt_Telefon
			// 
			this.txt_Telefon.Location = new System.Drawing.Point(85, 88);
			this.txt_Telefon.Name = "txt_Telefon";
			this.txt_Telefon.Size = new System.Drawing.Size(95, 20);
			this.txt_Telefon.TabIndex = 2;
			// 
			// txt_SatisFiyati
			// 
			this.txt_SatisFiyati.Location = new System.Drawing.Point(83, 120);
			this.txt_SatisFiyati.Name = "txt_SatisFiyati";
			this.txt_SatisFiyati.Size = new System.Drawing.Size(95, 20);
			this.txt_SatisFiyati.TabIndex = 4;
			// 
			// txt_TC
			// 
			this.txt_TC.Location = new System.Drawing.Point(85, 13);
			this.txt_TC.Name = "txt_TC";
			this.txt_TC.Size = new System.Drawing.Size(95, 20);
			this.txt_TC.TabIndex = 0;
			this.txt_TC.TextChanged += new System.EventHandler(this.txt_TC_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txt_pId);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.txt_ToplamFiyat);
			this.groupBox2.Controls.Add(this.txt_SatisFiyati);
			this.groupBox2.Controls.Add(this.txt_Miktari);
			this.groupBox2.Controls.Add(this.txt_UrunAdi);
			this.groupBox2.Controls.Add(this.txt_Barkod);
			this.groupBox2.Location = new System.Drawing.Point(21, 141);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 197);
			this.groupBox2.TabIndex = 10;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Urun";
			// 
			// txt_pId
			// 
			this.txt_pId.Location = new System.Drawing.Point(83, 40);
			this.txt_pId.Name = "txt_pId";
			this.txt_pId.Size = new System.Drawing.Size(95, 20);
			this.txt_pId.TabIndex = 12;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(15, 47);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(58, 13);
			this.label12.TabIndex = 11;
			this.label12.Text = "Ürün Kodu";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(4, 150);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(69, 13);
			this.label8.TabIndex = 10;
			this.label8.Text = "Toplam Fiyatı";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(16, 123);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(57, 13);
			this.label7.TabIndex = 9;
			this.label7.Text = "Satış Fiyatı";
			// 
			// Txt_AdSoyad
			// 
			this.Txt_AdSoyad.Location = new System.Drawing.Point(85, 62);
			this.Txt_AdSoyad.Name = "Txt_AdSoyad";
			this.Txt_AdSoyad.Size = new System.Drawing.Size(95, 20);
			this.Txt_AdSoyad.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.lbl_GenelToplam);
			this.panel3.Controls.Add(this.label9);
			this.panel3.Controls.Add(this.btn_SatisIptal);
			this.panel3.Controls.Add(this.btn_Sil);
			this.panel3.Controls.Add(this.btn_SatisYap);
			this.panel3.Controls.Add(this.btn_Ekle);
			this.panel3.Controls.Add(this.dataGridView1);
			this.panel3.Controls.Add(this.groupBox2);
			this.panel3.Controls.Add(this.groupBox1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(186, 80);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(847, 415);
			this.panel3.TabIndex = 5;
		
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_Cid);
			this.groupBox1.Controls.Add(this.label11);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label10);
			this.groupBox1.Controls.Add(this.txt_Telefon);
			this.groupBox1.Controls.Add(this.Txt_AdSoyad);
			this.groupBox1.Controls.Add(this.txt_TC);
			this.groupBox1.Location = new System.Drawing.Point(19, 21);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 114);
			this.groupBox1.TabIndex = 9;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Musteri";
			// 
			// txt_Cid
			// 
			this.txt_Cid.Location = new System.Drawing.Point(85, 36);
			this.txt_Cid.Name = "txt_Cid";
			this.txt_Cid.Size = new System.Drawing.Size(95, 20);
			this.txt_Cid.TabIndex = 7;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(60, 47);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(15, 13);
			this.label11.TabIndex = 6;
			this.label11.Text = "id";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(60)))));
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(186, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(847, 80);
			this.panel2.TabIndex = 4;
			this.panel2.Click += new System.EventHandler(this.panel2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.Gainsboro;
			this.label1.Location = new System.Drawing.Point(47, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "XSTORE";
			// 
			// btn_MusteriListele
			// 
			this.btn_MusteriListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_MusteriListele.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_MusteriListele.FlatAppearance.BorderSize = 0;
			this.btn_MusteriListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_MusteriListele.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_MusteriListele.Image = ((System.Drawing.Image)(resources.GetObject("btn_MusteriListele.Image")));
			this.btn_MusteriListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_MusteriListele.Location = new System.Drawing.Point(0, 140);
			this.btn_MusteriListele.Name = "btn_MusteriListele";
			this.btn_MusteriListele.Size = new System.Drawing.Size(186, 60);
			this.btn_MusteriListele.TabIndex = 3;
			this.btn_MusteriListele.Text = "    MÜŞTERİ LİSTELE";
			this.btn_MusteriListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_MusteriListele.UseVisualStyleBackColor = false;
			this.btn_MusteriListele.Click += new System.EventHandler(this.btn_MusteriListele_Click);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(186, 80);
			this.panel1.TabIndex = 0;
			// 
			// btn_SatıslarıListele
			// 
			this.btn_SatıslarıListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_SatıslarıListele.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_SatıslarıListele.FlatAppearance.BorderSize = 0;
			this.btn_SatıslarıListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_SatıslarıListele.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_SatıslarıListele.Image = ((System.Drawing.Image)(resources.GetObject("btn_SatıslarıListele.Image")));
			this.btn_SatıslarıListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_SatıslarıListele.Location = new System.Drawing.Point(0, 320);
			this.btn_SatıslarıListele.Name = "btn_SatıslarıListele";
			this.btn_SatıslarıListele.Size = new System.Drawing.Size(186, 60);
			this.btn_SatıslarıListele.TabIndex = 6;
			this.btn_SatıslarıListele.Text = "    SİPARİŞLERİ LİSTELE";
			this.btn_SatıslarıListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_SatıslarıListele.UseVisualStyleBackColor = false;
			this.btn_SatıslarıListele.Click += new System.EventHandler(this.btn_SatıslarıListele_Click);
			// 
			// btn_UrunListele
			// 
			this.btn_UrunListele.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_UrunListele.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_UrunListele.FlatAppearance.BorderSize = 0;
			this.btn_UrunListele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_UrunListele.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_UrunListele.Image = ((System.Drawing.Image)(resources.GetObject("btn_UrunListele.Image")));
			this.btn_UrunListele.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_UrunListele.Location = new System.Drawing.Point(0, 260);
			this.btn_UrunListele.Name = "btn_UrunListele";
			this.btn_UrunListele.Size = new System.Drawing.Size(186, 60);
			this.btn_UrunListele.TabIndex = 5;
			this.btn_UrunListele.Text = "    ÜRÜN LİSTELE";
			this.btn_UrunListele.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_UrunListele.UseVisualStyleBackColor = false;
			this.btn_UrunListele.Click += new System.EventHandler(this.btn_UrunListele_Click);
			// 
			// btn_UrunEkle
			// 
			this.btn_UrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_UrunEkle.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_UrunEkle.FlatAppearance.BorderSize = 0;
			this.btn_UrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_UrunEkle.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_UrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_UrunEkle.Image")));
			this.btn_UrunEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_UrunEkle.Location = new System.Drawing.Point(0, 200);
			this.btn_UrunEkle.Name = "btn_UrunEkle";
			this.btn_UrunEkle.Size = new System.Drawing.Size(186, 60);
			this.btn_UrunEkle.TabIndex = 4;
			this.btn_UrunEkle.Text = "    ÜRÜN EKLE";
			this.btn_UrunEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_UrunEkle.UseVisualStyleBackColor = false;
			this.btn_UrunEkle.Click += new System.EventHandler(this.btn_UrunEkle_Click);
			// 
			// panelMenu
			// 
			this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.panelMenu.Controls.Add(this.btn_SatıslarıListele);
			this.panelMenu.Controls.Add(this.btn_UrunListele);
			this.panelMenu.Controls.Add(this.btn_UrunEkle);
			this.panelMenu.Controls.Add(this.btn_MusteriListele);
			this.panelMenu.Controls.Add(this.btn_MusteriEkle);
			this.panelMenu.Controls.Add(this.panel1);
			this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
			this.panelMenu.Location = new System.Drawing.Point(0, 0);
			this.panelMenu.Name = "panelMenu";
			this.panelMenu.Size = new System.Drawing.Size(186, 495);
			this.panelMenu.TabIndex = 3;
			// 
			// btn_MusteriEkle
			// 
			this.btn_MusteriEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_MusteriEkle.Dock = System.Windows.Forms.DockStyle.Top;
			this.btn_MusteriEkle.FlatAppearance.BorderSize = 0;
			this.btn_MusteriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btn_MusteriEkle.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_MusteriEkle.Image = ((System.Drawing.Image)(resources.GetObject("btn_MusteriEkle.Image")));
			this.btn_MusteriEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_MusteriEkle.Location = new System.Drawing.Point(0, 80);
			this.btn_MusteriEkle.Name = "btn_MusteriEkle";
			this.btn_MusteriEkle.Size = new System.Drawing.Size(186, 60);
			this.btn_MusteriEkle.TabIndex = 2;
			this.btn_MusteriEkle.Text = "    MÜŞTERİ EKLE";
			this.btn_MusteriEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btn_MusteriEkle.UseVisualStyleBackColor = false;
			this.btn_MusteriEkle.Click += new System.EventHandler(this.btn_MusteriEkle_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1033, 495);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelMenu);
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panelMenu.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lbl_GenelToplam;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Button btn_SatisIptal;
		private System.Windows.Forms.Button btn_Sil;
		private System.Windows.Forms.Button btn_SatisYap;
		private System.Windows.Forms.Button btn_Ekle;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_ToplamFiyat;
		private System.Windows.Forms.TextBox txt_Miktari;
		private System.Windows.Forms.TextBox txt_UrunAdi;
		private System.Windows.Forms.TextBox txt_Barkod;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txt_Telefon;
		private System.Windows.Forms.TextBox txt_SatisFiyati;
		private System.Windows.Forms.TextBox txt_TC;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Txt_AdSoyad;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_MusteriListele;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_SatıslarıListele;
		private System.Windows.Forms.Button btn_UrunListele;
		private System.Windows.Forms.Button btn_UrunEkle;
		private System.Windows.Forms.Panel panelMenu;
		private System.Windows.Forms.Button btn_MusteriEkle;
		private System.Windows.Forms.TextBox txt_Cid;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txt_pId;
		private System.Windows.Forms.Label label12;
	}
}

