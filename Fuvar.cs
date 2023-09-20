using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doga
{
    class Fuvar
    {
        int ID;
        DateTime indulas;
        int idotartam;
        double tavolsag, veteldij,borravalo;
        string fizetesModja;

        public Fuvar(int iD, DateTime indulas, int idotartam, double tavolsag, double veteldij, double borravalo, string fizetesModja)
        {
            ID = iD;
            this.indulas = indulas;
            this.idotartam = idotartam;
            this.tavolsag = tavolsag;
            this.veteldij = veteldij;
            this.borravalo = borravalo;
            this.fizetesModja = fizetesModja;
        }

        public int ID1 { get => ID; set => ID = value; }
        public DateTime Indulas { get => indulas; set => indulas = value; }
        public int Idotartam { get => idotartam; set => idotartam = value; }
        public double Tavolsag { get => tavolsag; set => tavolsag = value; }
        public double Veteldij { get => veteldij; set => veteldij = value; }
        public double Borravalo { get => borravalo; set => borravalo = value; }
        public string FizetesModja { get => fizetesModja; set => fizetesModja = value; }
    }
}
