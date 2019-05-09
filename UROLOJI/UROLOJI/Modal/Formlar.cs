using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UROLOJI.Modal
{
    class Formlar
    {
        #region BilgiGiris

        public void HastaGiris()
        {
            BilgiGiris.frmHastaGiris frm = new BilgiGiris.frmHastaGiris();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        public int DoktorList(bool secim = false)
        {
            BilgiGiris.frmDoktorlar frm = new BilgiGiris.frmDoktorlar();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
            return frmAnaSayfa.Aktarma;
        }

        public int OpTuru(bool secim = false)
        {
            BilgiGiris.frmOpTur frm = new BilgiGiris.frmOpTur();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
            return frmAnaSayfa.Aktarma;
        }

        public int KoMorbid(bool secim = false)
        {
            BilgiGiris.frmKoMorbidite frm = new BilgiGiris.frmKoMorbidite();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
            return frmAnaSayfa.Aktarma;
        }

        public int HastaBul()
        {
            BilgiGiris.frmHastaBul frm = new BilgiGiris.frmHastaBul();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();

            return frmAnaSayfa.Aktarma;
        }

    }
}
        #endregion
