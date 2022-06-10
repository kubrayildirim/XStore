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
	public partial class UrunListele : Form
	{
		public UrunListele()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kubra"].ConnectionString);
		private void UrunListele_Load(object sender, EventArgs e)
		{
			UrunleriListele();
		}

		private void UrunleriListele()
		{
			con.Open();
			DataTable dt = new DataTable();
			SqlDataAdapter dap = new SqlDataAdapter("Select BarkodNo,CategoryName,ProductName,PurchasePrice,SalePrice,Quantity from Products p join Categories c ON p.CategoryID=c.CategoryID", con);
			dap.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
		private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			txt_BarkodNo.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
			txt_UrunAdi.Text = dataGridView1.CurrentRow.Cells["ProductName"].Value.ToString();
			txt_Miktar.Text = dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString();
			txt_AlisFiyati.Text = dataGridView1.CurrentRow.Cells["PurchasePrice"].Value.ToString();
			txt_StisFiyati.Text = dataGridView1.CurrentRow.Cells["SalePrice"].Value.ToString();
		}
		private void btn_Guncelle_Click(object sender, EventArgs e)
		{

			con.Open();
			string sorgu2 = "Update Products set BarkodNo=@barkod,ProductName=@ad,PurchasePrice=@alisfiyat,SalePrice=@satisfiyat,Quantity=@miktar where BarkodNo=@barkod";
			SqlCommand command2 = new SqlCommand(sorgu2, con);
			command2.Parameters.AddWithValue("@barkod", txt_BarkodNo.Text);
			command2.Parameters.AddWithValue("@ad", txt_UrunAdi.Text);
			command2.Parameters.AddWithValue("@miktar", Convert.ToInt32(txt_Miktar.Text));
			command2.Parameters.AddWithValue("@alisfiyat", Convert.ToDecimal(txt_AlisFiyati.Text));
			command2.Parameters.AddWithValue("@satisfiyat", Convert.ToDecimal(txt_StisFiyati.Text));
			command2.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Urun başarıyla güncellendi");
			Temizle();
			UrunleriListele();
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

		private void btn_Ara_Click(object sender, EventArgs e)
		{
			con.Open();
			DataTable dt = new DataTable();
			string sorgu3 = "Select * from Products where BarkodNo like '%" + txtBarkodAra.Text + "%'";
			SqlDataAdapter dap = new SqlDataAdapter(sorgu3, con);
			dap.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
			Temizle();
		}
	}

}

