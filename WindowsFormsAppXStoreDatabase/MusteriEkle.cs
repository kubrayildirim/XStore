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
	public partial class MusteriEkle : Form
	{
		public MusteriEkle()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kubra"].ConnectionString);
		private void MusteriEkle_Load(object sender, EventArgs e)
		{
			MusteriListeleme();
		}

		private void MusteriListeleme()
		{
			con.Open();
			DataTable dt = new DataTable();
			SqlDataAdapter dap = new SqlDataAdapter("Select CustomerTc,CustomerFullName,CustomerPhone,CustomerMail,CustomerAdress from Customers", con);
			dap.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}

		private void btn_Ekle_Click(object sender, EventArgs e)
		{
			//if (txt_TC.Text!=null &&txt_Ad.Text!=null&& txt_Telefon.Text!=null && txt_Email.Text!=null&&txt_Adres.Text!=null)
			//{
			//         con.Open();
			//string sorgu = "Insert into Customers (CustomerTc,CustomerFullName,CustomerPhone,CustomerMail,CustomerAdress) values (@tc,@adsoyad,@telefon,@mail,@adres)";
			//SqlCommand command = new SqlCommand(sorgu, con);
			//command.Parameters.AddWithValue("@tc", txt_TC.Text);
			//command.Parameters.AddWithValue("@adsoyad", txt_Ad.Text);
			//command.Parameters.AddWithValue("@telefon", txt_Telefon.Text);
			//command.Parameters.AddWithValue("@mail", txt_Email.Text);
			//command.Parameters.AddWithValue("@adres", txt_Adres.Text);
			//command.ExecuteNonQuery();
			//con.Close();
			//MessageBox.Show("Musteri başarıyla eklendi");
			//Temizle();
			//MusteriListeleme();
			//}
			//else
			//{
			//	MessageBox.Show("Lütfen eksiksiz doldurunuz!");
			//}

			con.Open();
			string sorgu = "Insert into Customers (CustomerTc,CustomerFullName,CustomerPhone,CustomerMail,CustomerAdress) values (@tc,@adsoyad,@telefon,@mail,@adres)";
			SqlCommand command = new SqlCommand(sorgu, con);
			command.Parameters.AddWithValue("@tc", txt_TC.Text);
			command.Parameters.AddWithValue("@adsoyad", txt_Ad.Text);
			command.Parameters.AddWithValue("@telefon", txt_Telefon.Text);
			command.Parameters.AddWithValue("@mail", txt_Email.Text);
			command.Parameters.AddWithValue("@adres", txt_Adres.Text);
			command.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Musteri başarıyla eklendi");
			Temizle();
			MusteriListeleme();
		}

		private void Temizle()
		{
			foreach (Control item in groupBox1.Controls)
			{
				if (item is TextBox)
				{
					item.Text = "";
				}

			}
		}
	}
	
}
