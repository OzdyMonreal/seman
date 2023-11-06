using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Lexico__Traductor_
{
    public class Variables
    {
        //ATRIBUTOS//
        public string Identificador;
        public string Tipo;
        public bool Usada;
        public bool Valor;

        //CONSTRUCTOR//
        public Variables() { } 
        public Variables(string NewIdentificador)
        {
            Identificador = NewIdentificador;
            Tipo = "NULO";
            Usada = false;
            Valor = false;
        }

        //METODOS//

        //SETTERS//
        public void SetIdentificador(string NewIdentificador)
        {
            Identificador = NewIdentificador;
        }
        public void SetTipo(string NewTipo)
        {
            Tipo = NewTipo; 
        }
        public void SetUsada()
        {
           Usada= true;
        }
        public void SetValor()
        {
            Valor = true;
        }
        //GETTERS//
        public string Identificadores { get { return Identificador; } }
        public string Tipos { get { return Tipo; } }
        public bool GetUsada() { return Usada; }
        public bool GetValor() { return Valor; }

    }
}
