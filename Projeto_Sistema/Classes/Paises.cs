using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema.Classes
{
    internal class Paises : Pai
    {
        private string Pais;
        private string Sigla;
        private string DDI;
        public Paises() : base()
        {
            Pais = "";
            Sigla = "";
            DDI = "";
        }

        public Paises(string pPais, string pSigla, string pDDI, int pCodigo, DateTime pDataCad, DateTime pDataUltAlt, Usuarios pUserUltAlt)
        : base(pCodigo,pDataCad,pDataUltAlt,pUserUltAlt)
        {
            Pais = pPais;
            Sigla = pSigla;
            DDI = pDDI;
        }

        public string pais
        {
            get { return Pais; }
            set { Pais = value; }
        }

        public string sigla
        {
            get { return Sigla; }
            set { Sigla = value; }
        }

        public string ddi
        {
            get { return DDI; }
            set { DDI = value; }
        }

        public Paises Clone()
        {
            return new Paises(Pais, Sigla, ddi, Codigo, DataCad, DataUltAlt, UserUltAlt);
        }

        ~Paises()
        {

        }
    }
}
