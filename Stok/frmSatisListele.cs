using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok
{
    public partial class frmSatisListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TQVN8NS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        public frmSatisListele()
        {
            InitializeComponent();
        }

        private void satisListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from satis", baglanti);
            adtr.Fill(daset, "satis");
            dataGridView1.DataSource = daset.Tables["satis"];
            
            baglanti.Close();

        }

        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            satisListele();
        }
    }
}
