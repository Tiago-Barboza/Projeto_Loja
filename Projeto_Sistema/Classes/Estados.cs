using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema.Classes
{
    internal class Estados : Pai
    {
        private string Estado;
        private string UF;
        private Paises oPais;

        public Estados() : base()
        {
            Estado = "";
            UF = "";
            oPais = new Paises();
        }

        public Estados(string pEstado, string pUF, Paises pOPais, int pCodigo, DateTime pDataCad, DateTime pDataUltAlt, Usuarios pUserUltAlt)
        : base(pCodigo, pDataCad, pDataUltAlt, pUserUltAlt)
        {
            Estado = pEstado;
            UF = pUF;
            oPais = pOPais;
        }

        public string estado
        {
            get { return Estado; }
            set { Estado = value; }
        }

        public string uf
        {
            get { return UF; }
            set { UF = value; }
        }

        public Paises opais
        {
            get { return oPais; }
            set { oPais = value; }
        }

        public Estados Clone()
        {
            return new Estados(Estado, UF, oPais, Codigo, DataCad, DataUltAlt, UserUltAlt);
        }
        ~Estados()
        {

        }
    }
}
