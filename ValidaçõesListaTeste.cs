using Teste_Unitario_C_.Services;
namespace teste
{
    public class Valida��esListaTeste
    {
        private Valida��esLista _vl;
        public Valida��esListaTeste()
        {
            _vl = new Valida��esLista();
        }
        [Fact]
        public void DeveRemoverNumerosNegativos()
        {
            //arrange
            List<int> lista = new List<int>() { 1, 2, -1, 9, -8, -2 };
            //act
            List<int> novaLista = _vl.RemoverNumerosNegativos(lista);
            //assert
            Assert.Equal(3, novaLista.Count);
        }
        [Fact]
        public void DeveConterONumero9NaLista()
        {
            //arrange
            List<int> lista = new List<int>() { 1, 2, -1, 9, -8, -2 };
            //act
            bool contem = _vl.ListaContemDeterminadoNumero(lista, 9);
            //assert
            Assert.True(contem);
        }
        [Fact]
        public void N�oDeveConterONumero10NaLista()
        {
            //arrange
            List<int> lista = new List<int>() { 1, 2, -1, 9, -8, -2 };
            //act
            bool contem = _vl.ListaContemDeterminadoNumero(lista, 10);
            //assert
            Assert.False(contem);
        }
        [Fact]
        public void DeveRetornarUmaListaMultiplicadaPor2()
        {
            //arrange
            List<int> lista = new List<int>() { 1, 2, -1, 9, -8, -2 };
            //act
            List<int> novaLista = _vl.MultiplicarNumerosLista(lista);
            //assert
            Assert.Equal(2, novaLista[0]);
        }
        [Fact]
        public void DeveRetornar9ComoMaior()
        {
            //arrange
            List<int> lista = new List<int>() { 1, 2, -1, 9, -8, -2 };
            //act
            int maximo = _vl.RetornarMaiorNumero(lista);
            //assert
            Assert.Equal(9, maximo);
        }
        [Fact]
        public void DeveRetornar8NegativoComoMenor()
        {
            //arrange
            List<int> lista = new List<int>() { 1, 2, -1, 9, -8, -2 };
            //act
            int minimo = _vl.RetornarMenorNumero(lista);
            //assert
            Assert.Equal(-8, minimo);
        }
    }
}