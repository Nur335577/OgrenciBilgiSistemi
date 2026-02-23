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

namespace OgrenciBilgiSistemi
{
    public partial class FrmOgrenciDetay2 : Form
    {
        public FrmOgrenciDetay2()
        {
            InitializeComponent();
        }
        public string Numara;
        SqlConnection bgl = new SqlConnection(@"<--->;Initial Catalog=OgrenciSistemi;Integrated Security=True"); //yerel bilgisayar adınızı girin.
        private void FrmOgrenciDetay2_Load(object sender, EventArgs e)
        {
            labelOgrenciNo.Text = Numara;
            bgl.Open();
            SqlCommand cmd = new SqlCommand("select * from TbL_DERS where ogrenciNo=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", labelOgrenciNo.Text);


            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                labelOgrenciAd.Text = rd[2].ToString() + " " + rd[3].ToString();
                labelSinav1.Text = rd[4].ToString();
                labelSinav2.Text = rd[5].ToString();
                labelOratalama.Text = rd[6].ToString();
            }

            double ortalama = double.Parse(labelOratalama.Text);
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

            bgl.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void labelOratalama_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            frmOgrenciDetay fr = new frmOgrenciDetay();
            fr.Show();
            this.Hide();
        }
    }
}
