using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Unitario_C_.Services
{
    public class ValidaçõesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> listaNumerica)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < listaNumerica.Count; i++)
            {
                if (listaNumerica[i]>=0)
                {
                    lista.Add(listaNumerica[i]);
                }
            }
            return lista;
        }
        public bool ListaContemDeterminadoNumero(List<int> listaNumerica, int numero)
        {
            bool existe = false;
            for (int i = 0; i < listaNumerica.Count; i++)
            {
                if (listaNumerica[i]==numero)
                {
                    existe = true;
                }
            }
            return existe;
        }
        public List<int> MultiplicarNumerosLista(List<int> listaNumerica)
        {
            List<int> lista = new List<int>();
            foreach (var item in listaNumerica)
            {
                int item2x = item * 2;
                lista.Add(item2x);
            }
            return lista;
        }
        public int RetornarMaiorNumero(List<int> listaNumerica)
        {
            int maximo = 0;
            foreach (var item in listaNumerica)
            {
                maximo = Math.Max(item, maximo);
            }
            return maximo;
        }
        public int RetornarMenorNumero(List<int> listaNumerica)
        {
            int minimo = 0;
            foreach (var item in listaNumerica)
            {
                minimo = Math.Min(item, minimo);
            }
            return minimo;
        }
    }
}
