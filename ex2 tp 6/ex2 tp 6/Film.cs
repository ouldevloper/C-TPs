using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace ex2_tp_6
{
    class Film
    {
        //les attributes
        private string gain;
        private string genre;
        private int id;
        private Image img;
        private string nomination;
        private string titre;
        //les constructeurs
        public Film(string ga, string gen, int i, Image im, string nomina, string tit)
        {

            this.GAIN = ga;
            this.GENRE = gen;
            this.ID = i;
            this.IMG = im;
            this.NOMINATION = nomina;
            this.TITRE = tit;
        }
        //les accesseurs et les mutateurs
        public string GAIN
        {
            get { return gain; }
            set { this.gain = value; }
        }
        public string GENRE
        {
            get { return genre; }
            set { this.genre = value; }
        }
        public int  ID
        {
            get { return id ; }
            set { this.id = value; }
        }
        public Image IMG
        {
            get { return   img; }
            set { this.img = value; }
        }

        public string NOMINATION
        {
            get { return nomination; }
            set { this.nomination = value; }
        }
        public string TITRE
        {
            get { return  titre; }
            set { this.titre = value; }
        }
    }
}
