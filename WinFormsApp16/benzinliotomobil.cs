using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp16
{
    internal class benzinliotomobil : Otomobil
    {
        private int yakıtdurumu;

        public benzinliotomobil(int yakıtdurumu, string renk, string cant)
        {
            this.yakıtdurumu = yakıtdurumu;
            this.Renk = renk;
            this.Cant = cant;
        }

        public string yakıtdurumugoster()
        {
            return (yakıtdurumu + "lt.");
        }
        public void depoyufulle()
        {
            this.yakıtdurumu = 50;
        }
    }
}
