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
    public partial class frmKoMorbidite : Form
    {
        UROLOJIDBDataContext _db = new UROLOJIDBDataContext();
        Mesajlar _m = new Mesajlar();
        int _secimId = -1;
        public bool Secim = false;
        bool _edit = false;
        public string ak;

        public frmKoMorbidite()
        {
            InitializeComponent();
        }

        private void frmKoMorbidite_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = _db.tblKoMorbidites.ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = k.KoMorbidite;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        void YeniKaydet()
        {
            try
            {
                tblKoMorbidite koMor = new tblKoMorbidite();
                koMor.KoMorbidite = txtKoMorEkle.Text;
                _db.tblKoMorbidites.InsertOnSubmit(koMor);
                _db.SubmitChanges();
                _m.YeniKayit("Kayıt tamamlandı.");
                Temizle();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        void Sec()
        {
            try
            {
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());

                if (txtkMor1.Text == "")
                {
                    txtkMor1.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtkMor2.Text == "")
                {
                    txtkMor2.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
                else if (txtkMor3.Text == "")
                {
                    txtkMor3.Text = Liste.CurrentRow.Cells[1].Value.ToString();
                }
            }
            catch (Exception)
            {
                _secimId = -1;
            }
        }

        void Guncelle()
        {
            tblKoMorbidite koMor = _db.tblKoMorbidites.First(x => x.id == _secimId);
            koMor.KoMorbidite = txtKoMorEkle.Text;
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }

        void Temizle()
        {
            txtKoMorEkle.Text = "";
            _edit = false;
            _secimId = -1;
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_edit && _secimId > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (_secimId < 0) YeniKaydet();
        }

        private void Liste_Click(object sender, EventArgs e)
        {
            Sec();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                _db.tblKoMorbidites.DeleteOnSubmit(_db.tblKoMorbidites.First(s => s.id == int.Parse(Liste.CurrentRow.Cells[0].Value.ToString())));
                _db.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                _m.Hata(ex);
            }
        }

        private void txtKoMorEkle_TextChanged(object sender, EventArgs e)
        {
            if (txtKoMorEkle.Text == "")
            {
                Temizle();
            }
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
            if (txtkMor1.Text != "" && txtkMor2.Text == "" && txtkMor3.Text=="")
            {
                ak = txtkMor1.Text;
            }
            else if (txtkMor1.Text != "" && txtkMor2.Text != "" && txtkMor3.Text=="")
            {
                ak = txtkMor1.Text + "," + txtkMor2.Text;
            }
            else if (txtkMor1.Text != "" && txtkMor2.Text != "" && txtkMor3.Text!="")
            {
                ak = txtkMor1.Text + "," + txtkMor2.Text + "," + txtkMor3.Text;
            }
            frmAnaSayfa.b = ak;
            Close();
        }
    }
}
