
namespace WindowsFormsAppXStoreDatabase
{
	partial class MusteriListele
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btn_Guncelle = new System.Windows.Forms.Button();
			this.txt_Adres = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Telefon = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Ad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_TC = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_TcAra = new System.Windows.Forms.Button();
			this.txt_TcAra = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btn_Guncelle);
			this.groupBox1.Controls.Add(this.txt_Adres);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txt_Email);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txt_Telefon);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_Ad);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_TC);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(501, 73);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(206, 264);
			this.groupBox1.TabIndex = 38;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteri Güncelle";
			// 
			// btn_Guncelle
			// 
			this.btn_Guncelle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_Guncelle.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_Guncelle.Location = new System.Drawing.Point(92, 191);
			this.btn_Guncelle.Name = "btn_Guncelle";
			this.btn_Guncelle.Size = new System.Drawing.Size(100, 30);
			this.btn_Guncelle.TabIndex = 43;
			this.btn_Guncelle.Text = "Guncelle";
			this.btn_Guncelle.UseVisualStyleBackColor = false;
			this.btn_Guncelle.Click += new System.EventHandler(this.btn_Guncelle_Click);
			// 
			// txt_Adres
			// 
			this.txt_Adres.Location = new System.Drawing.Point(92, 154);
			this.txt_Adres.Name = "txt_Adres";
			this.txt_Adres.Size = new System.Drawing.Size(100, 20);
			this.txt_Adres.TabIndex = 42;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(37, 157);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 41;
			this.label6.Text = "Adres";
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(92, 126);
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(100, 20);
			this.txt_Email.TabIndex = 40;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(39, 129);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 39;
			this.label5.Text = "Email";
			// 
			// txt_Telefon
			// 
			this.txt_Telefon.Location = new System.Drawing.Point(92, 94);
			this.txt_Telefon.Name = "txt_Telefon";
			this.txt_Telefon.Size = new System.Drawing.Size(100, 20);
			this.txt_Telefon.TabIndex = 38;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(28, 97);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 37;
			this.label4.Text = "Telefon";
			// 
			// txt_Ad
			// 
			this.txt_Ad.Location = new System.Drawing.Point(92, 68);
			this.txt_Ad.Name = "txt_Ad";
			this.txt_Ad.Size = new System.Drawing.Size(100, 20);
			this.txt_Ad.TabIndex = 34;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 71);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(63, 13);
			this.label2.TabIndex = 33;
			this.label2.Text = "İsim Soyisim";
			// 
			// txt_TC
			// 
			this.txt_TC.Location = new System.Drawing.Point(92, 42);
			this.txt_TC.Name = "txt_TC";
			this.txt_TC.Size = new System.Drawing.Size(100, 20);
			this.txt_TC.TabIndex = 32;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(50, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 31;
			this.label1.Text = "TC";
			// 
			// btn_TcAra
			// 
			this.btn_TcAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_TcAra.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_TcAra.Location = new System.Drawing.Point(150, 44);
			this.btn_TcAra.Name = "btn_TcAra";
			this.btn_TcAra.Size = new System.Drawing.Size(80, 23);
			this.btn_TcAra.TabIndex = 37;
			this.btn_TcAra.Text = "TC ARA";
			this.btn_TcAra.UseVisualStyleBackColor = false;
			this.btn_TcAra.Click += new System.EventHandler(this.btn_TcAra_Click);
			// 
			// txt_TcAra
			// 
			this.txt_TcAra.Location = new System.Drawing.Point(55, 44);
			this.txt_TcAra.Name = "txt_TcAra";
			this.txt_TcAra.Size = new System.Drawing.Size(89, 20);
			this.txt_TcAra.TabIndex = 36;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(55, 73);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(430, 264);
			this.dataGridView1.TabIndex = 35;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
			// 
			// MusteriListele
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(738, 399);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btn_TcAra);
			this.Controls.Add(this.txt_TcAra);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MusteriListele";
			this.Text = "MusteriListele";
			this.Load += new System.EventHandler(this.MusteriListele_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_Guncelle;
		private System.Windows.Forms.TextBox txt_Adres;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_Email;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_Telefon;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_Ad;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_TC;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btn_TcAra;
		private System.Windows.Forms.TextBox txt_TcAra;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}