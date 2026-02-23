using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciBilgiSistemi
{
    public partial class frmOgretmenDetay : Form
    {
        public frmOgretmenDetay()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"<--->;Initial Catalog=OgrenciSistemi;Integrated Security=True"); // bilgisayar adını girin.
        

        private void frmOgretmenDetay_Load(object sender, EventArgs e)
        {
            
            this.tbl_DersTableAdapter.Fill(this.ogrenciSistemiDataSet.Tbl_Ders);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("insert into tbl_Ders (ogrenciAd,ogrenciSoyad, ogrenciNo,sinav1,sinav2) values (@p1,@p2,@p3,@p4,@p5)", bgl);
            cmd.Parameters.AddWithValue("@p1", textBoxAd.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", textBoxNumara.Text);
            cmd.Parameters.AddWithValue("@p4", textBoxSinav1.Text);
            cmd.Parameters.AddWithValue("@p5", textBoxSinav2.Text);
            cmd.ExecuteNonQuery();
            this.tbl_DersTableAdapter.Fill(this.ogrenciSistemiDataSet.Tbl_Ders);
            MessageBox.Show("Kaydedildi!");
            bgl.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            double ortalama, sinav1, sinav2;
            
           
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            textBoxSinav1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            textBoxSinav2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            textBox1No.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            textBoxAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            textBoxSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            //labelOrtalama.Text= dataGridView1.Rows[secilen].Cells[6].Value.ToString();

            if (dataGridView1.Rows[secilen].Cells[4].Value != null && dataGridView1.Rows[secilen].Cells[5].Value!= null
                && !string.IsNullOrWhiteSpace(dataGridView1.Rows[secilen].Cells[4].Value.ToString()) &&
                !string.IsNullOrWhiteSpace(dataGridView1.Rows[secilen].Cells[5].Value.ToString()))
            {
                sinav1 = double.Parse(dataGridView1.Rows[secilen].Cells[4].Value.ToString());
                sinav2 = double.Parse(dataGridView1.Rows[secilen].Cells[5].Value.ToString());
                ortalama = (sinav1 + sinav2) / 2;
                labelOrtalama.Text = ortalama.ToString();
            }
            else
            {
                labelOrtalama.Text = "";
            }

            ortalama = double.Parse(labelOrtalama.Text);
            if (ortalama > 50)
            {
                labelDurum.Text = "GEÇTİ";
                labelDurum.ForeColor = Color.Green;
            }
            else
            {
                labelDurum.Text = "KALDI";
                labelDurum.ForeColor = Color.Red;
            }

            

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bgl.Open();
            

            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            SqlCommand cmd = new SqlCommand("Update Tbl_Ders Set ogrenciAd=@p1, OgrenciSoyad =@p2,  sinav1 =@p4 , sinav2 =@p5, ortalama =@a1 Where ogrenciNo = @p3", bgl);
            cmd.Parameters.AddWithValue("@p1", textBoxAd.Text);
            cmd.Parameters.AddWithValue("@p2", textBoxSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", textBoxNumara.Text);
            cmd.Parameters.AddWithValue("@p4", textBoxSinav1.Text);
            cmd.Parameters.AddWithValue("@p5", textBoxSinav2.Text);
           // ortalama bulmak için text box dolu mu boş mu kontrolü sağlar.

            if (dataGridView1.Rows[secilen].Cells[4].Value != null && dataGridView1.Rows[secilen].Cells[5].Value != null
               && !string.IsNullOrWhiteSpace(dataGridView1.Rows[secilen].Cells[4].Value.ToString()) &&
               !string.IsNullOrWhiteSpace(dataGridView1.Rows[secilen].Cells[5].Value.ToString()))
            {
                double ortalama = double.Parse(labelOrtalama.Text);
                cmd.Parameters.AddWithValue("@a1", ortalama);
            }
            else
            {
                cmd.Parameters.AddWithValue("@a1", 00);
            }
                cmd.ExecuteNonQuery();
            this.tbl_DersTableAdapter.Fill(this.ogrenciSistemiDataSet.Tbl_Ders);
            MessageBox.Show("Güncellendi!");
            bgl.Close();

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("delete from tbl_Ders where ogrencino=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", textBoxNumara.Text);
            cmd.ExecuteNonQuery();
            this.tbl_DersTableAdapter.Fill(this.ogrenciSistemiDataSet.Tbl_Ders);
            MessageBox.Show("silindi!");
            bgl.Close();
        }

        private void buttonKAydet_Click(object sender, EventArgs e)
        {
          
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmOgretmenGiris fr = new frmOgretmenGiris();
            fr.Show();
            this.Hide();
        }
    }
}
