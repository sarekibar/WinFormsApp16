using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp16
{
    internal class elektrikliotomobil : Otomobil
    {
        private int sarjdurumu;

        public elektrikliotomobil(int sarjdurumu, string renk, string cant)
        {
            this.sarjdurumu = sarjdurumu;
            this.Renk = renk;
            this.Cant = cant;
        }

        public string sarjdurumugetir()
        {
            return sarjdurumu + "kwh";
        }
        public void sarjet()
        {
            this.sarjdurumu = 240;
        }
    }
}
