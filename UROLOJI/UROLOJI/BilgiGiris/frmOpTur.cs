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
    public partial class frmOpTur : Form
    {
        UROLOJIDBDataContext _db = new UROLOJIDBDataContext();
        Mesajlar _m = new Mesajlar();
        bool _edit = false;
        int _secimId = -1;
        public bool Secim = false;
        public string ak;

        public frmOpTur()
        {
            InitializeComponent();
        }

        private void frmOpTur_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = _db.tblOpTurus.ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.id;
                Liste.Rows[i].Cells[1].Value = k.OpTuru;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }

        void YeniKaydet()
        {
            try
            {
                tblOpTuru opTur = new tblOpTuru();
                opTur.OpTuru = txtopTurEkle.Text;
                _db.tblOpTurus.InsertOnSubmit(opTur);
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
                _edit = true;
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
                txtopTurEkle.Text = Liste.CurrentRow.Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                _edit = false;
                _secimId = -1;
            }
        }

        void Guncelle()
        {
            tblOpTuru opTur = _db.tblOpTurus.First(x => x.id == _secimId);
            opTur.OpTuru = txtopTurEkle.Text;
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }

        void Temizle()
        {
            txtopTurEkle.Text = "";
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
                _db.tblOpTurus.DeleteOnSubmit(_db.tblOpTurus.First(s => s.id == int.Parse(Liste.CurrentRow.Cells[0].Value.ToString())));
                _db.SubmitChanges();
                Temizle();
            }
            catch (Exception ex)
            {
                _m.Hata(ex);
            }
        }

        private void txtopTurEkle_TextChanged(object sender, EventArgs e)
        {
            if (txtopTurEkle.Text == "")
            {
                Temizle();
            }
        }

        private void txtopTurEkle_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && _secimId > 0)
            {
                frmAnaSayfa.Aktarma = _secimId;
                Close();
            }
        }

        private void btnAktarma_Click(object sender, EventArgs e)
        {
            ak = txtopTurEkle.Text;
            frmAnaSayfa.c = ak;
            Close();
        }
    }
}
