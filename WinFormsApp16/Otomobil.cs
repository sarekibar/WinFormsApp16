using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp16
{
    internal class Otomobil
    {
        private string renk;
        private string cant;
        private string model = "audi";
        private int en = 2;
        private int boy = 4;

        public Otomobil()
        { 
        }
        public Otomobil(string renk, string cant)
        {
            this.renk = renk;
            this.cant = cant;
        }
            public Otomobil(string renk, string cant , int boy)
        {
            this.renk = renk;
            this.cant = cant;
            this.boy = 7;
        }

        public string Renk { get => renk; set => renk = value; }
        public string Cant { get => cant; set => cant = value; }

        public string getModel()
        {
            return this.model;
        }
        public int getEn()
        {
             return this.en;
        }
        public int getBoy()
        {
            return this.boy;
        }
    }
}
