
namespace WindowsFormsAppXStoreDatabase
{
	partial class UrunListele
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
			this.btn_Ara = new System.Windows.Forms.Button();
			this.txtBarkodAra = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Guncelle = new System.Windows.Forms.Button();
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
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Ara
			// 
			this.btn_Ara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_Ara.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_Ara.Location = new System.Drawing.Point(135, 31);
			this.btn_Ara.Name = "btn_Ara";
			this.btn_Ara.Size = new System.Drawing.Size(88, 25);
			this.btn_Ara.TabIndex = 9;
			this.btn_Ara.Text = "Barkod Ara";
			this.btn_Ara.UseVisualStyleBackColor = false;
			this.btn_Ara.Click += new System.EventHandler(this.btn_Ara_Click);
			// 
			// txtBarkodAra
			// 
			this.txtBarkodAra.Location = new System.Drawing.Point(29, 34);
			this.txtBarkodAra.Name = "txtBarkodAra";
			this.txtBarkodAra.Size = new System.Drawing.Size(100, 20);
			this.txtBarkodAra.TabIndex = 8;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(29, 62);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(482, 243);
			this.dataGridView1.TabIndex = 7;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Guncelle);
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
			this.groupBox1.Location = new System.Drawing.Point(539, 62);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(195, 243);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Urun  Guncelle";
			// 
			// btn_Guncelle
			// 
			this.btn_Guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_Guncelle.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_Guncelle.Location = new System.Drawing.Point(84, 185);
			this.btn_Guncelle.Name = "btn_Guncelle";
			this.btn_Guncelle.Size = new System.Drawing.Size(100, 29);
			this.btn_Guncelle.TabIndex = 15;
			this.btn_Guncelle.Text = "Güncelle";
			this.btn_Guncelle.UseVisualStyleBackColor = false;
			this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
			// 
			// txt_StisFiyati
			// 
			this.txt_StisFiyati.Location = new System.Drawing.Point(84, 147);
			this.txt_StisFiyati.Name = "txt_StisFiyati";
			this.txt_StisFiyati.Size = new System.Drawing.Size(100, 20);
			this.txt_StisFiyati.TabIndex = 11;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(20, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(57, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Satiş Fiyatı";
			// 
			// txt_AlisFiyati
			// 
			this.txt_AlisFiyati.Location = new System.Drawing.Point(84, 121);
			this.txt_AlisFiyati.Name = "txt_AlisFiyati";
			this.txt_AlisFiyati.Size = new System.Drawing.Size(100, 20);
			this.txt_AlisFiyati.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(27, 124);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(50, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "Alış Fiyatı";
			// 
			// txt_Miktar
			// 
			this.txt_Miktar.Location = new System.Drawing.Point(84, 95);
			this.txt_Miktar.Name = "txt_Miktar";
			this.txt_Miktar.Size = new System.Drawing.Size(100, 20);
			this.txt_Miktar.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(39, 98);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Miktarı";
			// 
			// txt_UrunAdi
			// 
			this.txt_UrunAdi.Location = new System.Drawing.Point(84, 69);
			this.txt_UrunAdi.Name = "txt_UrunAdi";
			this.txt_UrunAdi.Size = new System.Drawing.Size(100, 20);
			this.txt_UrunAdi.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Urun Adı";
			// 
			// txt_BarkodNo
			// 
			this.txt_BarkodNo.Location = new System.Drawing.Point(84, 41);
			this.txt_BarkodNo.Name = "txt_BarkodNo";
			this.txt_BarkodNo.Size = new System.Drawing.Size(100, 20);
			this.txt_BarkodNo.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(19, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Barkod No";
			// 
			// UrunListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(775, 356);
			this.Controls.Add(this.btn_Ara);
			this.Controls.Add(this.txtBarkodAra);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox1);
			this.Name = "UrunListele";
			this.Text = "UrunListele";
			this.Load += new System.EventHandler(this.UrunListele_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_Ara;
		private System.Windows.Forms.TextBox txtBarkodAra;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_Guncelle;
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
	}
}