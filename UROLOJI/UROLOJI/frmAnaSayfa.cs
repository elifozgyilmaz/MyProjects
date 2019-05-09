using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UROLOJI.Modal;

namespace UROLOJI
{
    public partial class frmAnaSayfa : Form
    {
        public static int Aktarma;


        UROLOJIDBDataContext _db = new UROLOJIDBDataContext();
        Formlar _f = new Formlar();

        public static string a=" ";
        public static string b =" ";
        public static string c = " ";

        public frmAnaSayfa()
        {
            InitializeComponent();
        }

        private void frmAnaSayfa_Load(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            grpLeft.BackColor = Color.CornflowerBlue;
            grpLeft.ForeColor = Color.White;
            grpLeft.Text = "UROLOJI";
            pnlLeft1.Visible = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            _f.HastaGiris();
        }

        private void btnBilgiGiris_Click(object sender, EventArgs e)
        {
            pnlLeft1.Visible = false;
            pnlLeft2.Visible = true;
            pnlLeft3.Visible = false;
            grpLeft.Text = "Bilgi Giriş İşlemleri";
            grpLeft.BackColor = Color.CornflowerBlue;
            grpLeft.ForeColor = Color.White;
        }

        private void btnHastaBul_Click(object sender, EventArgs e)
        {
            _f.HastaBul();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {

        }
    }
}
