using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Model
{
    public class Tipp
    {
        public int Id { get; set; }
        public int JatekosId { get; set; }
        public int Sz1 { get; set; }
        public int Sz2 { get; set; }
        public int Sz3 { get; set; }
        public int Sz4 { get; set; }
        public int Sz5 { get; set; }
        public int Sz6 { get; set; }

        public Tipp()
        {
        }

        public Tipp(string sor)
        {
            string[] s = sor.Split(";");
            JatekosId = Convert.ToInt32(s[0]);
            Sz1 = Convert.ToInt32(s[1]);
            Sz2 = Convert.ToInt32(s[2]);
            Sz3 = Convert.ToInt32(s[3]);
            Sz4 = Convert.ToInt32(s[4]);
            Sz5 = Convert.ToInt32(s[5]);
            Sz6 = Convert.ToInt32(s[6]);
        }
    }
}
