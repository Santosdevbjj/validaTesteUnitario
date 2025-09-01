using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidacoesConsole
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            if (lista == null)
                throw new ArgumentNullException(nameof(lista));
            return lista.Where(x => x >= 0).ToList();
        }

        public bool ListaContemDeterminadoNumero(List<int> lista, int numero)
        {
            if (lista == null)
                throw new ArgumentNullException(nameof(lista));
            return lista.Contains(numero);
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int multiplicador)
        {
            if (lista == null)
                throw new ArgumentNullException(nameof(lista));
            return lista.Select(x => x * multiplicador).ToList();
        }

        public int RetornarMaiorNumeroLista(List<int> lista)
        {
            if (lista == null || !lista.Any())
                throw new ArgumentException("Lista vazia ou nula");
            return lista.Max();
        }

        public int RetornarMenorNumeroLista(List<int> lista)
        {
            if (lista == null || !lista.Any())
                throw new ArgumentException("Lista vazia ou nula");
            return lista.Min();
        }
    }
}
