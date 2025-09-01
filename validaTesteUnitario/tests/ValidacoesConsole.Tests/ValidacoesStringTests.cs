using System;
using Xunit;
using ValidacoesConsole;

namespace ValidacoesConsole.Tests
{
    public class ValidacoesStringTests
    {
        [Fact]
        public void DeveRetornar6QuantidadeCaracteresDaPalavraMatrix()
        {
            var texto = "Matrix";
            var validacoes = new ValidacoesString();
            Assert.Equal(6, validacoes.RetornarQuantidadeCaracteres(texto));
        }

        [Fact]
        public void DeveContemAPalavraQualquerNoTexto()
        {
            var texto = "Esse é um texto qualquer";
            var validacoes = new ValidacoesString();
            Assert.True(validacoes.ContemCaractere(texto, "qualquer"));
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            var texto = "Esse é um texto qualquer";
            var validacoes = new ValidacoesString();
            Assert.False(validacoes.ContemCaractere(texto, "teste"));
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            var texto = "Começo, meio e fim do texto procurado";
            var validacoes = new ValidacoesString();
            Assert.True(validacoes.TextoTerminaCom(texto, "procurado"));
        }
    }
}
