using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema.Classes
{
    internal class Pai
    {
        protected int Codigo;
        protected DateTime DataCad;
        protected DateTime DataUltAlt;
        protected Usuarios UserUltAlt;

        public Pai()
        {
            Codigo = 0;
            DataCad = new DateTime();
            DataUltAlt = new DateTime();
            UserUltAlt = new Usuarios();
        }

        public Pai(int pCodigo, DateTime pDataCad, DateTime pDatUltAlt, Usuarios pUserUltAlt)
        {
            Codigo = pCodigo;
            DataCad = pDataCad;
            DataUltAlt = pDatUltAlt;
            UserUltAlt = pUserUltAlt;
        }

        public int codigo
        {
            get { return Codigo; } 
            set { Codigo = value; }
        }

        public DateTime datacad 
        { 
            get { return DataCad; } 
            set { DataCad = value; } 
        }

        public DateTime dataUltAlt
        {
            get { return DataUltAlt; }
            set { DataUltAlt = value; }
        }

        public Usuarios userUltAlt
        {
            get { return UserUltAlt;}
            set { UserUltAlt = value;}
        }
    }
}
