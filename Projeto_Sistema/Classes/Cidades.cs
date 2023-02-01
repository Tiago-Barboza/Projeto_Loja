using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Sistema.Classes
{
    internal class Cidades : Pai
    {
        private string Cidade;
        private string DDD;
        private Estados oEstado;

        public Cidades() : base()
        {
            Cidade = "";
            DDD = "";
            oEstado = new Estados();
        }

        public Cidades(int pCodigo, string pCidade, string pDDD, Estados pOEstado, DateTime pDataCad, DateTime pDataUltAlt, Usuarios pUserUltAlt)
        : base(pCodigo, pDataCad, pDataUltAlt, pUserUltAlt)
        {
            Cidade = pCidade;
            DDD = pDDD;
            oEstado = pOEstado;
        }

        public string cidade
        {
            get { return Cidade; }
            set { Cidade = value; }
        }

        public string ddd
        {
            get { return DDD; }
            set { DDD = value; }
        }

        public Estados oestado
        {
            get { return oEstado; }
            set { oEstado = value; }
        }

        public Cidades Clone()
        {
            return new Cidades(Codigo, Cidade, DDD, oEstado, DataCad, DataUltAlt, UserUltAlt);
        }

        ~Cidades() 
        {
            
        }
    }
}
