using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_RCA.Codigo.DTO
{   //ini dto namespace
    class dto_Equip
    {    //ini class dto_Equip
        //Atributos dos equipamentos
        private int id;
        private string tipo;
        private string fabricante;
        private string modelo;
        private string sn;
        private string contagem;
        private string potencia;
        private string polegadas;
        //Variáveis de controle de entrada e saída
        private int status = 0;                 // status 0 (RCA) - 1 (CLIENTE/RUA)        
        private string local;                   // variável de localização do equipamento
        private string tecEnt;                  //Variável de controle do técnico de entrada do equipamento
        private string tecRet;                  //Variável de controle do técnico de retirada do equipamento
        private string tecSaid;                 //Variável de controle do técnico de saída do equipamento
        private string tecInstal;               //Variável de controle do técnico de instalação do equipamento
        //Gets, Sets dos atributos dos equipamentos
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value;}
        }
        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        public string SN
        {
            get { return sn; }
            set { sn = value; }
        }
        public string Contagem
        {
            get { return contagem; }
            set { contagem = value; }
        }
        public string Potencia
        {
            get { return potencia; }
            set { potencia = value; }
        }
        public string Polegadas
        {
            get { return polegadas; }
            set { polegadas = value; }
        }
        //Gets, Sets de controle dos equipamentos
        public int Status
        {
            get { return status; }
            set { status = value; }
        }       
        public string Local
        {
            get { return local; }
            set { local = value; }
        }
        public string TecEnt
        {
            get { return tecEnt; }
            set { tecEnt = value;}
        }
        public string TecRet
        {
            get { return tecRet; }
            set { tecRet = value; }
        }
        public string TecSaid
        {
            get { return tecSaid; }
            set { tecSaid = value; }
        }
        public string TecInstal
        {
            get { return tecInstal; }
            set { tecInstal = value; }
        }
    }   //fim class dto_Equip
}   //fim dto namespace
