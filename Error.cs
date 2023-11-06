using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Lexico__Traductor_
{
    internal class Error
    {
        //ATRIBUTOS// 
        private string Cadena;
        private string Exception;

        //CONSTRUCTOR//
        public Error(string NewCadena, string NewException)
        {
            Cadena = NewCadena;
            Exception = NewException;
        }

        //SETTERS//
        public void SetCadena(string NewCadena) { Cadena = NewCadena; }
        public void SetException(string NewException) { Exception = NewException; }

        //GETTERS//
        public string Instruccion {  get { return Cadena; } }
        public string Excepcion { get { return Exception; } } 
    }
}
