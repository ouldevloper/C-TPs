using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_5_exe_3
{
    class Produit
    {
        private string couleur;
        private string name;
        private int qteStock;
        public Produit(string c,string n,int qt) {
            this.Couleur = c;
            this.Name = n;
            this.qteStock = qt;
        }
        public string Couleur {
            get { return this.couleur; }
            set { this.couleur = value; }
        }
        public string Name {
            get { return this.name; }
            set { this.name = value; }
        }
        public int QteStock {
            get { return this.qteStock;}
            set { this.qteStock = value; }
        } 

    }
}
