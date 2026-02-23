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
    public partial class frmOgrenciDetay : Form
    {
        public frmOgrenciDetay()
        {
            InitializeComponent();
        }

        //Data Source=LAPTOP-74SKFQ4C\SQLEXPRESS;Initial Catalog=OgrenciSistemi;Integrated Security=True;Trust Server Certificate=True
        SqlConnection bgl = new SqlConnection(@"Data Source=LAPTOP-74SKFQ4C\SQLEXPRESS;Initial Catalog=OgrenciSistemi;Integrated Security=True");
        private void buttonGirisYap_Click(object sender, EventArgs e) 
        {
            bgl.Open();
            SqlCommand cmd = new SqlCommand("select * from Tbl_Ders where ogrenciNo =@p1", bgl);
            cmd.Parameters.AddWithValue("@p1", textBoxOgrenciNo.Text);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                FrmOgrenciDetay2 fr = new FrmOgrenciDetay2();
                fr.Numara = textBoxOgrenciNo.Text;
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("yanlış Numara!");
            }
            bgl.Close();

        }

        private void frmOgrenciDetay_Load(object sender, EventArgs e)
        {
            
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
