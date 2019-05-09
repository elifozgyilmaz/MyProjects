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

namespace UROLOJI.BilgiGiris
{
    public partial class frmHastaBul : Form
    {
        UROLOJIDBDataContext _db = new UROLOJIDBDataContext();
        Formlar _f = new Formlar();
        public int _id = -1;

        public frmHastaBul()
        {
            InitializeComponent();
        }

        private void frmHastaBul_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblHastaBilgileris
                       where s.Ad.Contains(txtBul.Text) || s.Protokol.Contains(txtBul.Text)
                       select new
                       {
                           a = s.hastaID,
                           p = s.Protokol,
                           n = s.HastaNo,
                           d = s.Ad,
                           e = s.Soyad,
                       }).Distinct().OrderByDescending(x => x.d).OrderBy(y => y.n);
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.a;
                Liste.Rows[i].Cells[1].Value = k.p;
                Liste.Rows[i].Cells[2].Value = k.n;
                Liste.Rows[i].Cells[3].Value = k.d;
                Liste.Rows[i].Cells[4].Value = k.e;
                i++;
            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
        }

        void Sec()
        {
            try
            {
                _id = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                _id = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if ( _id > 0)
            {
                frmAnaSayfa.Aktarma = _id;
                Close();
            }
        }

        private void btnAra_Click(object sender, EventArgs e)
        {

            Listele();
            
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
