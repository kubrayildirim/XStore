using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppXStoreDatabase
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kubra"].ConnectionString);
		DataSet ds = new DataSet();
		private void Form1_Load(object sender, EventArgs e)
		{
			SatisListele();
		}

		private void SatisListele()
		{
			con.Open();
			SqlDataAdapter dap = new SqlDataAdapter("Select CustomerID,CustomerName,BarkodNo,ProductName,Quantity,SalePrice,TotalPrice from Satis", con);
			dap.Fill(ds, "Satis");
			dataGridView1.DataSource = ds.Tables["Satis"];
			con.Close();
			
		}
		
		private void FormGetir(Form frm)
		{
			panel3.Controls.Clear();
			frm.MdiParent = this; // bu sayfada aç diyorum
			frm.FormBorderStyle = FormBorderStyle.None; // oynatama diye sabitledik
			panel3.Controls.Add(frm);
			frm.Show();

		}
		private void btn_MusteriEkle_Click(object sender, EventArgs e)
		{
			MusteriEkle frmMusteriekle = new MusteriEkle();
			FormGetir(frmMusteriekle);
		}

		private void btn_MusteriListele_Click(object sender, EventArgs e)
		{
			MusteriListele frmMusterilistele = new MusteriListele();
			FormGetir(frmMusterilistele);
		}

		private void btn_UrunEkle_Click(object sender, EventArgs e)
		{
			UrunEkle frmUrunEkle = new UrunEkle();
			FormGetir(frmUrunEkle);
		}

		private void btn_UrunListele_Click(object sender, EventArgs e)
		{
			UrunListele frmUrunlistele = new UrunListele();
			FormGetir(frmUrunlistele);
		}

		private void btn_SatıslarıListele_Click(object sender, EventArgs e)
		{
			SiparisleriListele frmSiparislistele = new SiparisleriListele();
			FormGetir(frmSiparislistele);
		}

		private void txt_TC_TextChanged(object sender, EventArgs e)
		{
			con.Open();
			string sorgu = "Select * from Customers where CustomerTc like '"+ txt_TC.Text + "'";
			SqlCommand command = new SqlCommand(sorgu, con);
			SqlDataReader dr = command.ExecuteReader();
			while (dr.Read())
			{
				txt_Cid.Text = dr["CustomerID"].ToString();
				Txt_AdSoyad.Text = dr["CustomerFullName"].ToString();
				txt_Telefon.Text = dr["CustomerPhone"].ToString();
			}
			con.Close(); 
		}

		private void txt_Barkod_TextChanged(object sender, EventArgs e)
		{

			con.Open();
			string sorgu2 = "Select * from Products p where BarkodNo like '" + txt_Barkod.Text + "'";
			SqlCommand command2 = new SqlCommand(sorgu2, con);
			SqlDataReader dr2 = command2.ExecuteReader();
			while (dr2.Read())
			{
				txt_pId.Text = dr2["ProductID"].ToString();
				txt_UrunAdi.Text = dr2["ProductName"].ToString();
				txt_SatisFiyati.Text = dr2["SalePrice"].ToString();

			}

			Temizle();
			con.Close();

		}

		private void Temizle()
		{
			if (txt_Barkod.Text == "")
			{
				foreach (Control item in groupBox2.Controls)
				{
					if (item is TextBox)
					{
						if (item != txt_Miktari)
						{
							item.Text = "";
						}

					}

				}
			}
		}

		private void btn_Ekle_Click(object sender, EventArgs e)
		{
			con.Open();
			string sorgu3 = "Insert into Satis(CustomerID,CustomerName,BarkodNo,ProductName,Quantity,SalePrice,TotalPrice) values(@CustomerID,@CustomerName,@BarkodNo,@ProductName,@Quantity,@SalePrice,@TotalPrice)";
			SqlCommand command = new SqlCommand(sorgu3, con);
			command.Parameters.AddWithValue("@CustomerID", int.Parse(txt_Cid.Text));
			command.Parameters.AddWithValue("@CustomerName", Txt_AdSoyad.Text);
			command.Parameters.AddWithValue("@BarkodNo",txt_Barkod.Text);
			command.Parameters.AddWithValue("@ProductName", txt_UrunAdi.Text);
			command.Parameters.AddWithValue("@Quantity", int.Parse(txt_Miktari.Text));
			command.Parameters.AddWithValue("@SalePrice", decimal.Parse(txt_SatisFiyati.Text));
			command.Parameters.AddWithValue("@TotalPrice",decimal.Parse(txt_ToplamFiyat.Text));


			command.ExecuteNonQuery();
			con.Close();

			ds.Tables["Satis"].Clear();
			SatisListele();
			Temizle();
			Hesapla();

		}

		private void txt_Miktari_TextChanged(object sender, EventArgs e)
		{
			try
			{
				txt_ToplamFiyat.Text = (decimal.Parse(txt_Miktari.Text) * decimal.Parse(txt_SatisFiyati.Text)).ToString();
			}
			catch (Exception)
			{

			}
		}

		private void btn_Sil_Click(object sender, EventArgs e)
		{
			con.Open();
			string sorgu = "Delete from Satis where BarkodNo='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'";
			SqlCommand command = new SqlCommand(sorgu, con);
			command.ExecuteNonQuery();
			con.Close();
			
			MessageBox.Show("Ürün satıştan  çıkarıldı");
			ds.Tables[0].Clear();
			SatisListele();
			Hesapla();
		}

		private void btn_SatisIptal_Click(object sender, EventArgs e)
		{
			con.Open();
			string sorgu = "Delete from Satis";
			SqlCommand command = new SqlCommand(sorgu, con);
			command.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Ürün satıştan  çıkarıldı");
			ds.Tables[0].Clear();
			SatisListele();
			Hesapla();
		}

		private void Hesapla()
		{
			try
			{
            con.Open();
			SqlCommand command = new SqlCommand("select sum(TotalPrice) from Satis", con);
			lbl_GenelToplam.Text = command.ExecuteScalar()+"TL";
				con.Close();
			}
			catch (Exception)
			{

				throw;
			}
			
		}

		private void btn_SatisYap_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
			{
				con.Open();
				string sorgu3 = "Insert into Orders(CustomerID,ProductID,Quantity,SalePrice,TotalPrice) values(@CustomerID,@ProductID,@Quantity,@SalePrice,@TotalPrice)";
				SqlCommand command = new SqlCommand(sorgu3, con);
				command.Parameters.AddWithValue("@CustomerID",txt_Cid.Text);
				command.Parameters.AddWithValue("@ProductID", txt_pId.Text);
				command.Parameters.AddWithValue("@Quantity", int.Parse(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString()));
				command.Parameters.AddWithValue("@SalePrice", decimal.Parse(dataGridView1.Rows[i].Cells["SalePrice"].Value.ToString()));
				command.Parameters.AddWithValue("@TotalPrice", decimal.Parse(dataGridView1.Rows[i].Cells["TotalPrice"].Value.ToString()));
				command.ExecuteNonQuery();
				string sorgu4 = "Update Products set Quantity=Quantity-'" + int.Parse(dataGridView1.Rows[i].Cells["Quantity"].Value.ToString()) + "'where BarkodNo='" + dataGridView1.Rows[i].Cells["BarkodNo"].Value.ToString() + "'";
				SqlCommand command4 = new SqlCommand(sorgu4, con);
				command4.ExecuteNonQuery();
				con.Close();
			}
			con.Open();
			string sorgu5 = "Delete from Satis";
			SqlCommand command5 = new SqlCommand(sorgu5, con);
			command5.ExecuteNonQuery();
			con.Close();
			ds.Tables[0].Clear();
			SatisListele();
			Hesapla();
		}

		private void panel2_Click(object sender, EventArgs e)
		{
			Form1 frm1 = new Form1();
			frm1.Show();
		}

	
	}
}
