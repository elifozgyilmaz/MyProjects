using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UROLOJI.Modal;

namespace UROLOJI.Modal
{
    class Numaralar
    {
        UROLOJIDBDataContext _db = new UROLOJIDBDataContext();
        public string HastaNo()
        {
            try
            {
                int numara = ((from s in _db.tblHastaBilgileris
                               orderby s.hastaID descending
                               select s).First()).HastaNo.Value;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
