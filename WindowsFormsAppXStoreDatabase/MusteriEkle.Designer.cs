
namespace WindowsFormsAppXStoreDatabase
{
	partial class MusteriEkle
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
			this.txt_Adres = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_Email = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_Telefon = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_Ad = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_TC = new System.Windows.Forms.TextBox();
			this.btn_Ekle = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txt_Adres);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.txt_Email);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.txt_Telefon);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txt_Ad);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txt_TC);
			this.groupBox1.Controls.Add(this.btn_Ekle);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(30, 87);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 210);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Müşteri Ekle";
			// 
			// txt_Adres
			// 
			this.txt_Adres.Location = new System.Drawing.Point(78, 144);
			this.txt_Adres.Name = "txt_Adres";
			this.txt_Adres.Size = new System.Drawing.Size(100, 20);
			this.txt_Adres.TabIndex = 26;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(31, 147);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(34, 13);
			this.label6.TabIndex = 25;
			this.label6.Text = "Adres";
			// 
			// txt_Email
			// 
			this.txt_Email.Location = new System.Drawing.Point(78, 116);
			this.txt_Email.Name = "txt_Email";
			this.txt_Email.Size = new System.Drawing.Size(100, 20);
			this.txt_Email.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(33, 119);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 23;
			this.label5.Text = "Email";
			// 
			// txt_Telefon
			// 
			this.txt_Telefon.Location = new System.Drawing.Point(78, 90);
			this.txt_Telefon.Name = "txt_Telefon";
			this.txt_Telefon.Size = new System.Drawing.Size(100, 20);
			this.txt_Telefon.TabIndex = 22;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 21;
			this.label4.Text = "Telefon";
			// 
			// txt_Ad
			// 
			this.txt_Ad.Location = new System.Drawing.Point(78, 57);
			this.txt_Ad.Name = "txt_Ad";
			this.txt_Ad.Size = new System.Drawing.Size(100, 20);
			this.txt_Ad.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(20, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Ad";
			// 
			// txt_TC
			// 
			this.txt_TC.Location = new System.Drawing.Point(78, 27);
			this.txt_TC.Name = "txt_TC";
			this.txt_TC.Size = new System.Drawing.Size(100, 20);
			this.txt_TC.TabIndex = 16;
			// 
			// btn_Ekle
			// 
			this.btn_Ekle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
			this.btn_Ekle.ForeColor = System.Drawing.Color.Gainsboro;
			this.btn_Ekle.Location = new System.Drawing.Point(78, 170);
			this.btn_Ekle.Name = "btn_Ekle";
			this.btn_Ekle.Size = new System.Drawing.Size(100, 34);
			this.btn_Ekle.TabIndex = 15;
			this.btn_Ekle.Text = "Ekle";
			this.btn_Ekle.UseVisualStyleBackColor = false;
			this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(44, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(21, 13);
			this.label1.TabIndex = 14;
			this.label1.Text = "TC";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(248, 63);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(610, 285);
			this.dataGridView1.TabIndex = 17;
			// 
			// MusteriEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 438);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView1);
			this.Name = "MusteriEkle";
			this.Text = "MusteriEkle";
			this.Load += new System.EventHandler(this.MusteriEkle_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.GroupBox groupBox1;
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
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btn_Ekle;
	}
}