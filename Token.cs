using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analizador_Lexico__Traductor_
{
    internal class Token
    {
        //ATRIBUTOS//
        private string Character; 
        private string Type;
        private string GeneralType;

        //CONSTRUCTORES//
        public Token() {}

        public Token(string NewCharacter, string NewTipe, string generalType)
        {
            Character = NewCharacter;
            Type = NewTipe;
            GeneralType = generalType;
        }

        //GETTERS//
        public string General() { return GeneralType; }
        public string Caracteres { get { return Character; } }
        public string Tipos { get { return Type; } }
    }
}
