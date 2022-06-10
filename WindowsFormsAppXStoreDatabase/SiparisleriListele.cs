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
	public partial class SiparisleriListele : Form
	{
		public SiparisleriListele()
		{
			InitializeComponent();
		}
		SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["kubra"].ConnectionString);
		private void SiparisleriListele_Load(object sender, EventArgs e)
		{
			SiparisListele();
		}

		private void SiparisListele()
		{
			con.Open();
			DataTable dt = new DataTable();
			SqlDataAdapter dap = new SqlDataAdapter("Select c.CustomerFullName,p.BarkodNo,p.productName,o.Quantity,o.TotalPrice from Orders o join Customers c ON o.CustomerID=c.CustomerID join Products p ON o.ProductID=p.ProductID ", con);
			dap.Fill(dt);
			dataGridView1.DataSource = dt;
			con.Close();
		}
	}
}
