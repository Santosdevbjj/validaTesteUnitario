--- /dev/null
+++ tests/ValidacoesConsole.Tests/ValidacoesListaTests.cs
@@ -0,0 +1,61 @@
using System;
using System.Collections.Generic;
using Xunit;
using ValidacoesConsole;

namespace ValidacoesConsole.Tests
{
    public class ValidacoesListaTests
    {
        [Fact]
        public void DeveRemoverNumerosNegativosDeUmaLista()
        {
            var lista = new List<int> { 1, -2, 3, -4, 5 };
            var validacoes = new ValidacoesLista();
            var resultado = validacoes.RemoverNumerosNegativos(lista);

            Assert.DoesNotContain(resultado, x => x < 0);
            Assert.Contains(1, resultado);
            Assert.Contains(3, resultado);
            Assert.Contains(5, resultado);
            Assert.Equal(3, resultado.Count);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            var lista = new List<int> { 1, 4, 9, 2, 7 };
            var validacoes = new ValidacoesLista();
            Assert.True(validacoes.ListaContemDeterminadoNumero(lista, 9));
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            var lista = new List<int> { 1, 4, 9, 2, 7 };
            var validacoes = new ValidacoesLista();
            Assert.False(validacoes.ListaContemDeterminadoNumero(lista, 10));
        }

        [Fact]
        public void DeveMultiplicarOsElementosDaListaPor2()
        {
            var lista = new List<int> { 1, 2, 3 };
            var validacoes = new ValidacoesLista();
            var resultado = validacoes.MultiplicarNumerosLista(lista, 2);

            Assert.Equal(new List<int> { 2, 4, 6 }, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumeroDaLista()
        {
            var lista = new List<int> { 5, 9, 3, 7 };
            var validacoes = new ValidacoesLista();
            Assert.Equal(9, validacoes.RetornarMaiorNumeroLista(lista));
        }

        [Fact]
        public void DeveRetornarOitoNegativoComoMenorNumeroDaList()
        {
            var lista = new List<int> { -3, -8, 0, 2 };
            var validacoes = new ValidacoesLista();
            Assert.Equal(-8, validacoes.RetornarMenorNumeroLista(lista));
        }
    }
}
