using Teste_Unitario_C_.Services;
namespace teste
{
    public class ValidaçõesStringTeste
    {
        private ValidaçõesString _vs;
        public ValidaçõesStringTeste()
        {
            _vs = new ValidaçõesString();
        }
        [Fact]
        public void DeveRetornarQuantidade6NaPalavraMatrix()
        {
            //arrange
            string texto = "Matrix";
            //act
            int quantidade = _vs.RetornarQuantidade(texto);
            //assert
            Assert.Equal(6, quantidade);
        }
        [Fact]
        public void DeveConterAPalavraQualquerNoTexto()
        {
            //arrange
            string texto = "Esse é um texto qualquer";
            string palavra = "qualquer";
            //act
            bool contem = _vs.ContemCaractere(texto, palavra);
            //assert
            Assert.True(contem);
        }
        [Fact]
        public void NãoDeveConterAPalavraTesteNoTexto()
        {
            //arrange
            string texto = "Esse é um texto qualquer";
            string palavra = "teste";
            //act
            bool contem = _vs.ContemCaractere(texto, palavra);
            //assert
            Assert.False(contem);
        }
        [Fact]
        public void DeveTerminarComAPalavraProcurado()
        {
            //arrange
            string texto = "Este homem é procurado";
            string palavra = "procurado";
            //act
            bool contem = _vs.ContemCaracterenoFinal(texto, palavra);
            //assert
            Assert.True(contem);
        }
    }
}