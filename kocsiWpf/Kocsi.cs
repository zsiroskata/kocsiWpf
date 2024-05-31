using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace kocsiWpf
{
	internal class Kocsi
	{
//		név
        public string Nev { get; set; }
		//tipus
		public string Tipus { get; set; }
		//üzemanyag
        public string Uzemanyag { get; set; }
        //évjárat
        public int Ev { get; set; }
        //kép
        public string Kep { get; set; }
		public Kocsi(string nev, string tipus, string uzemanyag, int ev, string source)
		{
			Nev = nev;
			Tipus = tipus;
			Uzemanyag = uzemanyag;
			Ev = ev;
			Kep = $@"..\..\..\images\{source}";
		}
	}
}
