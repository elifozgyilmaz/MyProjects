using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UROLOJI.Modal;

namespace UROLOJI.BilgiGiris
{
    public partial class frmHastaGiris : Form
    {
        UROLOJIDBDataContext _db = new UROLOJIDBDataContext();
        Formlar _f = new Formlar();
        Mesajlar _m = new Mesajlar();
        Numaralar _n = new Numaralar();
    
        int _hastaId = -1;

        public frmHastaGiris()
        {
            InitializeComponent();
        }

        private void frmHastaGiris_Load(object sender, EventArgs e)
        {
            Temizle();
        }

        void Temizle()
        {
            foreach (TabPage item in tabControl1.Controls)
            {
                foreach (Control ct in item.Controls )
                {
                 if (ct is TextBox) ct.Text = "";
                 if (ct is ComboBox) ((ComboBox)ct).SelectedIndex = -1;
                }

            }

            txtHastaNo.Text = _n.HastaNo();

        }

        void YeniKaydet()
        {
            try
            {
                tblHastaBilgileri hasta = new tblHastaBilgileri();
                hasta.HastaNo = txtHastaNo.Text != "" ? int.Parse(txtHastaNo.Text) : -1;
                hasta.Ad = txtHastaAdi.Text;
                hasta.Soyad = txtHastaSoyadi.Text;
                hasta.Protokol = txtProtokol.Text;
                hasta.OpTarihi = DateTime.Parse(dtp.Text);
                hasta.OpTuru = txtOpTuru.Text;
                hasta.Takip = txtTakip.Text !="" ? int.Parse(txtTakip.Text) : -1;
                hasta.Anah = txtAnah.Text !="" ? int.Parse(txtAnah.Text) : -1;
                _db.tblHastaBilgileris.InsertOnSubmit(hasta);

                tblDemografikOzellikler demog = new tblDemografikOzellikler();

                demog.Yas = txtYas.Text !="" ? int.Parse(txtYas.Text) :-1;
                demog.Boy = txtBoy.Text !="" ? decimal.Parse(txtBoy.Text) : -1;
                demog.Kilo = txtKilo.Text !="" ? decimal.Parse(txtKilo.Text) : -1;
                demog.Bmi = txtBmi.Text != "" ? decimal.Parse(txtBmi.Text) : -1;
                demog.Asa = cbAsa.Text != "" ? int.Parse(cbAsa.Text):-1;
                demog.Dr = txtDr.Text;
                demog.Cins = cbCins.Text;
                demog.Taraf = cbTaraf.Text;
                demog.Lokalizasyon = txtLokalizasyon.Text;
                demog.Boyut = txtBoyut.Text;
                demog.Ko_Morbidite = txtKoMorbidite.Text;
                _db.tblDemografikOzelliklers.InsertOnSubmit(demog);

                tblOperatifOzellikler oper = new tblOperatifOzellikler();

                oper.PksAciklama = cbPksAciklama.Text;
                oper.Sik = cbSik.Text;
                oper.CoOperasyon = txtCoOperasyon.Text;
                oper.Iskemi = txtIskemi.Text != "" ? int.Parse(txtIskemi.Text):-1;
                oper.PortSayisi = cbPortSayisi.Text != "" ? int.Parse(cbPortSayisi.Text):-1;
                oper.YardımYnt = txtYardimYnt.Text;
                oper.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text):-1;
                oper.Dren = cbDren.Text != "" ? int.Parse(cbDren.Text):-1;
                oper.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text):-1;
                oper.Piyes = txtPiyes.Text;
                _db.tblOperatifOzelliklers.InsertOnSubmit(oper);

                tblPosOperatifOzellikler posop = new tblPosOperatifOzellikler();

                posop.PeropVeErkenKomp = cbPeropVeErkenKomp.Text;
                posop.Dren = cbDren.Text != "" ? int.Parse(cbDren.Text):-1;
                posop.PostopAnaliz = txtPostopAnaliz.Text;
                posop.Sonda = cbSonda.Text;
                posop.HospSuresi = cbHosbSuresi.Text != "" ? int.Parse(cbHosbSuresi.Text):-1;
                posop.PreopKreatin = txtPreopKreatin.Text != "" ? decimal.Parse(txtPreopKreatin.Text):-1;
                posop.PostopKreatin = txtPostopKreatin.Text != "" ? decimal.Parse(txtPostopKreatin.Text):-1;
                posop.PreopHct = txtPreopHct.Text != "" ? decimal.Parse(txtPreopHct.Text):-1;
                posop.PostopHct = txtPostopHct.Text != "" ? decimal.Parse(txtPostopHct.Text):-1;
                posop.PreopHb = txtPreopHb.Text != "" ? decimal.Parse(txtPreopHb.Text):-1;
                posop.PostopHb = txtPostopHb.Text != "" ? decimal.Parse(txtPostopHb.Text):-1;
                posop.Takip = txtTakip2.Text;
                posop.Tel = txtTel.Text;
                posop.PostopGecKomp = txtPostopGecKomp.Text;
                posop.KompClavien = txtKompClavien.Text;
                _db.tblPosOperatifOzelliklers.InsertOnSubmit(posop);

                tblPatolojikVeriler pato = new tblPatolojikVeriler();

                pato.Patoloji = cbPatoloji.Text;
                pato.AltGrup = cbAltGrup.Text;
                pato.FurhmanGrade = cbFurhmanGrade.Text != "" ? int.Parse(cbFurhmanGrade.Text):-1;
                pato.PatolojikEvre = cbPatolojikEvre.Text;
                pato.CerrahiSinir = cbCerrahiSinir.Text;
                _db.tblPatolojikVerilers.InsertOnSubmit(pato);

                tblTakipVerileri takip = new tblTakipVerileri();

                takip.Postop3AyLokalNüks = txtPostop3AyLokal.Text;
                takip.Postop3AyKreatin = txtPostop3AyKreatin.Text;
                takip.Postop6AyLokalNüks = txtPostop6AyLokal.Text;
                takip.Postop6AyKreatin = txtPostop6AyKreatin.Text;
                takip.Postop12AyLokalNüks = txtPostop12AyLokal.Text;
                takip.Postop12AyKreatin = txtPostop12AyKreatin.Text;
                _db.tblTakipVerileris.InsertOnSubmit(takip);

                _db.SubmitChanges();

                _m.YeniKayit("Kayıt gerçekleştirildi.");
                Temizle();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            var btnDr = new Button();
            btnDr.Size = new Size(25, txtDr.ClientSize.Height + 2);
            btnDr.Location = new Point(txtDr.ClientSize.Width - btnDr.Width, -1);
            btnDr.Cursor = Cursors.Default;
            txtDr.Controls.Add(btnDr);
            SendMessage(txtDr.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnDr.Width << 16));
            btnDr.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnOpTuru = new Button();
            btnOpTuru.Size = new Size(25, txtOpTuru.ClientSize.Height + 2);
            btnOpTuru.Location = new Point(txtOpTuru.ClientSize.Width - btnOpTuru.Width, -1);
            btnOpTuru.Cursor = Cursors.Default;
            txtOpTuru.Controls.Add(btnOpTuru);
            SendMessage(txtOpTuru.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnOpTuru.Width << 16));
            btnOpTuru.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btnKoMorbid = new Button();
            btnKoMorbid.Size = new Size(25, txtKoMorbidite.ClientSize.Height + 2);
            btnKoMorbid.Location = new Point(txtKoMorbidite.ClientSize.Width - btnKoMorbid.Width, -1);
            btnKoMorbid.Cursor = Cursors.Default;
            txtKoMorbidite.Controls.Add(btnKoMorbid);
            SendMessage(txtKoMorbidite.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnKoMorbid.Width << 16));
            btnKoMorbid.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            btnDr.Click += btnDr_Click;
            btnOpTuru.Click += btnOpTuru_Click;
            btnKoMorbid.Click += btnKoMorbid_Click;

        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnDr_Click(object sender, EventArgs e)
        {
            int id=_f.DoktorList();
            Ac(id);
            frmAnaSayfa.a = "";
        }

        private void btnKoMorbid_Click(object sender, EventArgs e)
        {
            int id=_f.KoMorbid();
            Ac(id);
            frmAnaSayfa.b = "";
        }
        private void btnOpTuru_Click(object sender, EventArgs e)
        {
            int id=_f.OpTuru();
            Ac(id);
            frmAnaSayfa.c = "";
        }
        void Guncelle()
        {
            tblHastaBilgileri hasta = _db.tblHastaBilgileris.First(x => x.hastaID== _hastaId);
            hasta.Ad = txtHastaAdi.Text;
            hasta.Soyad = txtHastaSoyadi.Text;
            hasta.Protokol = txtProtokol.Text;
            hasta.OpTarihi = DateTime.Parse(dtp.Text);
            _db.SubmitChanges();

            _m.Guncelle(true);
            Temizle();
        }

        void Ac(int id)
        {
            try
            {
                _hastaId = id;
                tblHastaBilgileri hasta = _db.tblHastaBilgileris.First(s => s.hastaID == id);
                txtHastaNo.Text = hasta.HastaNo.ToString().PadLeft(7, '0');
                txtHastaAdi.Text = hasta.Ad;
                txtHastaSoyadi.Text = hasta.Soyad;
                txtProtokol.Text = hasta.Protokol;
                dtp.Text = hasta.OpTarihi.ToString();
                txtOpTuru.Text = hasta.OpTuru;
                txtTakip.Text = hasta.Takip.ToString();
                txtAnah.Text = hasta.Anah.ToString();

                tblDemografikOzellikler demog = _db.tblDemografikOzelliklers.First(s => s.hastaID == _hastaId);
                txtYas.Text = demog.Yas.ToString();
                txtBoy.Text = demog.Boy.ToString();
                txtKilo.Text = demog.Kilo.ToString();
                txtBmi.Text = demog.Bmi.ToString();
                cbAsa.Text = demog.Asa.ToString();
                txtDr.Text = demog.Dr;
                cbCins.Text = demog.Cins;
                cbTaraf.Text = demog.Taraf;
                txtLokalizasyon.Text = demog.Lokalizasyon;
                txtBoyut.Text = demog.Boyut;
                txtKoMorbidite.Text = demog.Ko_Morbidite;

                tblOperatifOzellikler oper = _db.tblOperatifOzelliklers.First(s => s.hastaID == _hastaId);
                cbPksAciklama.Text = oper.PksAciklama;
                cbSik.Text = oper.Sik;
                txtCoOperasyon.Text = oper.CoOperasyon;
                txtIskemi.Text = oper.Iskemi.ToString();
                cbPortSayisi.Text = oper.PortSayisi.ToString();
                txtYardimYnt.Text = oper.YardımYnt;
                txtSure.Text = oper.Sure.ToString();
                cbDren.Text = oper.Dren.ToString();
                txtKanama.Text = oper.Kanama.ToString();
                txtPiyes.Text = oper.Piyes;

                tblPosOperatifOzellikler posop = _db.tblPosOperatifOzelliklers.First(s => s.hastaID == _hastaId);
                cbPeropVeErkenKomp.Text = posop.PeropVeErkenKomp;
                cbDren.Text = posop.Dren.ToString();
                txtPostopAnaliz.Text = posop.PostopAnaliz;
                cbSonda.Text = posop.Sonda;
                cbHosbSuresi.Text = posop.HospSuresi.ToString();
                txtPreopKreatin.Text = posop.PreopKreatin.ToString();
                txtPostopKreatin.Text = posop.PostopKreatin.ToString();
                txtPreopHct.Text = posop.PreopKreatin.ToString();
                txtPostopHct.Text = posop.PostopHct.ToString();
                txtPreopHb.Text = posop.PreopHb.ToString();
                txtPostopHb.Text = posop.PostopHb.ToString();
                txtTakip2.Text = posop.Takip;
                txtTel.Text = posop.Tel;
                txtPostopGecKomp.Text = posop.PostopGecKomp;
                txtKompClavien.Text = posop.KompClavien;

                tblPatolojikVeriler pato = _db.tblPatolojikVerilers.First(s => s.hastaID == _hastaId);
                cbPatoloji.Text = pato.Patoloji;
                cbAltGrup.Text = pato.AltGrup;
                cbFurhmanGrade.Text = pato.FurhmanGrade.ToString();
                cbPatolojikEvre.Text = pato.PatolojikEvre;
                cbCerrahiSinir.Text = pato.CerrahiSinir;

                tblTakipVerileri takip = _db.tblTakipVerileris.First(s => s.hastaID == _hastaId);
                txtPostop3AyLokal.Text = takip.Postop3AyLokalNüks;
                txtPostop3AyKreatin.Text = takip.Postop3AyKreatin;
                txtPostop6AyLokal.Text = takip.Postop6AyLokalNüks;
                txtPostop6AyKreatin.Text = takip.Postop6AyKreatin;
                txtPostop12AyLokal.Text = takip.Postop12AyLokalNüks;
                txtPostop12AyKreatin.Text = takip.Postop12AyKreatin;
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            YeniKaydet();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            int id = _f.HastaBul();
            if (id>0)
            {
                Ac(id);

            }
            frmAnaSayfa.Aktarma = -1;
        }
    }
}
