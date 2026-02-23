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
    public partial class frmOgretmenGiris : Form
    {
        public frmOgretmenGiris()
        {
            InitializeComponent();
        }
        SqlConnection bgl = new SqlConnection(@"Data Source=LAPTOP-74SKFQ4C\SQLEXPRESS;Initial Catalog=OgrenciSistemi;Integrated Security=True");
        private void frmOgretmenGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("select * from tbl_Ogretmen where ogretmenSifre=@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", textBoxOgretmenSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBoxOgretmenSifre.Text = dr[2].ToString();
                frmOgretmenDetay fr = new frmOgretmenDetay();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("yanlış şifre!");
            }
            bgl.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.Show();
            this.Hide();
        }
    }
}
