using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_tp_6
{
    class Genre
    {
        //les attribute
        private int id;
        private string libele;
        //les constructeurs
        public Genre(int i, string libe)
        {
            this.ID = i;
            this.LIBELE = libe;
        }
        //les accesseur et mutateurs
        public int ID
        {
            get { return id; }
            set { this.id = value; }
        }
        public string LIBELE
        {
            get { return libele; }
            set { this.libele = value; }
        }

    }
}
