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
    public partial class frmUrunListele : Form
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TQVN8NS;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();

        private void kategorigetir()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kategoribilgileri", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboKategori.Items.Add(read["kategori"].ToString());
            }
            baglanti.Close();
        }
        public frmUrunListele()
        {
            InitializeComponent();
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunListele();
            kategorigetir();
        }

        private void UrunListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from urun", baglanti);
            adtr.Fill(daset, "urun");
            dataGridView1.DataSource = daset.Tables["urun"];
            baglanti.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            barkodNoTxt.Text = dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString();
            kategoriTxt.Text = dataGridView1.CurrentRow.Cells["kategori"].Value.ToString();
            markaTxt.Text = dataGridView1.CurrentRow.Cells["marka"].Value.ToString();
            urunAdiTxt.Text = dataGridView1.CurrentRow.Cells["urunadi"].Value.ToString();
            miktarTxt.Text = dataGridView1.CurrentRow.Cells["miktari"].Value.ToString();
            alisFiyatiTxt.Text = dataGridView1.CurrentRow.Cells["alisfiyati"].Value.ToString();
            satisFiyatiTxt.Text = dataGridView1.CurrentRow.Cells["satisfiyati"].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update urun set urunadi=@urunadi, miktari=@miktari," +
                "alisfiyati=@alisfiyati,satisfiyati=@satisfiyati where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", barkodNoTxt.Text);
            komut.Parameters.AddWithValue("@urunadi", urunAdiTxt.Text);
            komut.Parameters.AddWithValue("@miktari",int.Parse( miktarTxt.Text));
            komut.Parameters.AddWithValue("@alisfiyati",double.Parse( alisFiyatiTxt.Text));
            komut.Parameters.AddWithValue("@satisfiyati",double.Parse( satisFiyatiTxt.Text));
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme yapıldı.");
            daset.Tables["urun"].Clear(); 
            UrunListele();
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void btnMarkaGuncelle_Click(object sender, EventArgs e)
        {
            if (barkodNoTxt.Text!="")
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update urun set kategori=@kategori, marka=@marka" +
                    " where barkodno=@barkodno", baglanti);
                komut.Parameters.AddWithValue("@barkodno", barkodNoTxt.Text);
                komut.Parameters.AddWithValue("@kategori", comboKategori.Text);
                komut.Parameters.AddWithValue("@marka", comboMarka.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Güncelleme yapıldı.");
                daset.Tables["urun"].Clear();
                UrunListele();
            }
            else
            {
                MessageBox.Show("Barkodno yazılı değil", "Uyarı");
            }
          
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
        }

        private void comboKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboMarka.Items.Clear();
            comboMarka.Text = "";
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from markabilgileri where kategori='" + comboKategori.SelectedItem + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                comboMarka.Items.Add(read["marka"].ToString());
            }
            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from urun where barkodno='" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["urun"].Clear();
            UrunListele();
            MessageBox.Show("Kayıt Silindi.");
        }

        private void txtBarkodnoAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select* from urun where barkodno like '%" + txtBarkodnoAra.Text + "%'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
    }
}
