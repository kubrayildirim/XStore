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
	public partial class UrunEkle : Form
	{
		public UrunEkle()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kubra"].ConnectionString);
		private void UrunEkle_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'xStoreDatabaseDataSet.Categories' table. You can move, or remove it, as needed.
			this.categoriesTableAdapter.Fill(this.xStoreDatabaseDataSet.Categories);
			UrunleriListele();
		}
		private void UrunleriListele()
		{
			con.Open();
			DataTable dt = new DataTable();
			SqlDataAdapter dap = new SqlDataAdapter("Select * from Products", con);
			dap.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
		private void btn_Ekle_Click(object sender, EventArgs e)
		{
			if (txt_BarkodNo.Text!=null&& txt_UrunAdi.Text!=null&&txt_Miktar.Text!=null&&txt_StisFiyati.Text!=null)
			{
            con.Open();
			string sorgu = "Insert into Products (BarkodNo,CategoryID,ProductName,PurchasePrice,SalePrice,Quantity) values (@barkod,@id,@ad,@alisfiyat,@satisfiyat,@miktar)";
			SqlCommand command = new SqlCommand(sorgu, con);
			command.Parameters.AddWithValue("@barkod", txt_BarkodNo.Text);
			command.Parameters.AddWithValue("@id", cb_Kategori.SelectedValue);
			command.Parameters.AddWithValue("@ad", txt_UrunAdi.Text);
			command.Parameters.AddWithValue("@alisfiyat",Convert.ToDecimal(txt_AlisFiyati.Text));
			command.Parameters.AddWithValue("@satisfiyat",Convert.ToDecimal(txt_StisFiyati.Text));
			command.Parameters.AddWithValue("@miktar", Convert.ToInt32(txt_Miktar.Text));
		    command.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Ürün başarıyla eklendi");
			Temizle();
			UrunleriListele();
			}
			else
			{
				MessageBox.Show("Lütfen eksiksiz bilgi giriniz");
			}
			
		}
		private void Temizle()
		{
			foreach (Control item in this.Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";
				}

			}
		}


	}
}
