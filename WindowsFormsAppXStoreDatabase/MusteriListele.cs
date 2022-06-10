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
	public partial class MusteriListele : Form
	{
		public MusteriListele()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kubra"].ConnectionString);
		private void MusteriListele_Load(object sender, EventArgs e)
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

		private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
		{
			txt_TC.Text = dataGridView1.CurrentRow.Cells["CustomerTc"].Value.ToString();
			txt_Ad.Text = dataGridView1.CurrentRow.Cells["CustomerFullName"].Value.ToString();
			txt_Telefon.Text = dataGridView1.CurrentRow.Cells["CustomerPhone"].Value.ToString();
			txt_Email.Text = dataGridView1.CurrentRow.Cells["CustomerMail"].Value.ToString();
			txt_Adres.Text = dataGridView1.CurrentRow.Cells["CustomerAdress"].Value.ToString();
		}

		private void btn_Guncelle_Click(object sender, EventArgs e)
		{
			con.Open();
			string sorgu2 = "Update Customers set CustomerFullName=@ad,CustomerPhone=@telefon,CustomerMail=@mail,CustomerAdress=@adres where CustomerTc=@tc";
			SqlCommand command2 = new SqlCommand(sorgu2, con);
			command2.Parameters.AddWithValue("@tc", txt_TC.Text);
			command2.Parameters.AddWithValue("@ad", txt_Ad.Text);
			command2.Parameters.AddWithValue("@telefon", txt_Telefon.Text);
			command2.Parameters.AddWithValue("@mail", txt_Email.Text);
			command2.Parameters.AddWithValue("@adres", txt_Adres.Text);
			command2.ExecuteNonQuery();
			con.Close();
			MessageBox.Show("Musteri başarıyla güncellendi");
			Temizle();
			MusteriListeleme();
		}

		private void btn_TcAra_Click(object sender, EventArgs e)
		{
			con.Open();
			DataTable dt = new DataTable();
			string sorgu3 = "Select * from Customers where CustomerTc like '%" + txt_TcAra.Text + "%'";
			SqlDataAdapter dap = new SqlDataAdapter(sorgu3, con);
			dap.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
			Temizle();
		}

		
	}
}
