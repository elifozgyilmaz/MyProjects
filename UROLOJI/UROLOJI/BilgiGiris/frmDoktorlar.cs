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
    public partial class frmDoktorlar : Form
    {
        UROLOJIDBDataContext _db = new UROLOJIDBDataContext();
        Mesajlar _m = new Mesajlar();
        public bool Secim = false;
        int _secimId = -1;
        public string ak;
        bool _edit = false;

        public frmDoktorlar()
        {
            InitializeComponent();
        }

        private void frmDoktorlar_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = _db.tblDRs.ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = k.DR;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        void YeniKaydet()
        {
            try
            {
                tblDR dr = new tblDR();
                dr.DR = txtDoktorEkle.Text;
                _db.tblDRs.InsertOnSubmit(dr);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt başarıyla gerçekleştirildi.");
                Temizle();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        void Temizle()
        {
            txtDoktorEkle.Text = "";
            _edit = false;
            _secimId = -1;
            Listele();
        }

        void Guncelle()
        {
            tblDR dr = _db.tblDRs.First(x => x.id == _secimId);
            dr.DR = txtDoktorEkle.Text;
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }

        void Sec()
        {
            try
            {
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());

                if (txtDr1.Text == "")
                {
                    txtDr1.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtDr2.Text == "")
                {
                    txtDr2.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtDr3.Text == "")
                {
                    txtDr3.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }

            }
            catch (Exception)
            {
                _secimId = -1;
            }
        }

        private void Liste_Click(object sender, EventArgs e)
        {
            Sec();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && _secimId > 0)
            {
                frmAnaSayfa.Aktarma = _secimId;
                Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAktarma_Click(object sender, EventArgs e)
        {
            if (txtDr1.Text != "" && txtDr2.Text == "" && txtDr3.Text=="")
            {
                ak = txtDr1.Text;
            }
            else if (txtDr1.Text != "" && txtDr2.Text != "" && txtDr3.Text =="")
            {
                ak = txtDr1.Text + ", " + txtDr2.Text;
            }
            else if (txtDr1.Text != "" && txtDr2.Text != "" && txtDr3.Text !="")
            {
                ak = txtDr1.Text + ", " + txtDr2.Text + ", " + txtDr3.Text;
            }
            frmAnaSayfa.a = ak;
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_edit && _secimId > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (_secimId < 0) YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _db.tblDRs.DeleteOnSubmit(_db.tblDRs.First(s => s.id == int.Parse(Liste.CurrentRow.Cells[0].Value.ToString())));
                _db.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                _m.Hata(ex);
            }
        }
    }
}
