using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Unitario_C_.Services
{
    public class ValidaçõesString
    {
        public int RetornarQuantidade(string texto)
        {
            return texto.Length;
        }
        public bool ContemCaractere(string texto, string palavra)
        {
            bool contem = false;
            if (texto.Contains(palavra))
            {
                contem = true;
            }
            return contem;
        }
        public bool ContemCaracterenoFinal(string texto, string palavra)
        {
            bool contem = false;

            string[] frase = texto.Split(" ");
            int indice = frase.Length-1;

            if (frase[indice].Contains(palavra))
            {
                contem = true;
            }
            return contem;
        }
    }
}
