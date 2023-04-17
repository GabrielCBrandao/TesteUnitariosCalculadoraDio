using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }
    //A anotação Fact indica que este é um método de teste do XUnit.
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        //Arrange: Nesta etapa iremos preparar o que nós iremos passar para o nosso teste.
        int numero1 = 5;
        int numero2 = 10;

        //Act: Nesta etapa iremos executar a ação do teste, no caso a ação de somar.
        int resultado = _calc.Somar(numero1, numero2);
        //Assert: Nesta estapa fazemos a validação do resultado do teste.
        Assert.Equal(15, resultado);
    }

    [Fact]
    public void DeveSomar10Com10ERetornar20()
    {
        //Arrange: Nesta etapa iremos preparar o que nós iremos passar para o nosso teste.
        int numero1 = 10;
        int numero2 = 10;

        //Act: Nesta etapa iremos executar a ação do teste, no caso a ação de somar.
        int resultado = _calc.Somar(numero1, numero2);
        //Assert: Nesta estapa fazemos a validação do resultado do teste.
        Assert.Equal(20, resultado);
    }
    [Fact]
    public void DeveVerificarSe4EhParERetornarVerdadeiro()
    {
        //Arrange
        int numero = 4;
        //Act
        bool resultado = _calc.EhPar(numero);
        //Assert
        Assert.True(resultado);


    }
    //Utilizando o Theory com InLineData para validação de mais de um cenário de teste que tenham o mesmo retorno esperado.
    // [Theory]
    //     [InlineData(2)]
    //     [InlineData(4)]
    //     [InlineData(6)]
    //     [InlineData(8)]
    //     [InlineData(10)]
    //     public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int numero)
    //     {
    //         //Arrange: Neste caso o arrange é próprio InLineData.
    //         //Act
    //         bool resultado = _calc.EhPar(numero);
    //     //Assert

    //     Assert.True(resultado);

    // }
    //-->Refatorando o método anterior para deixá-lo mais enxuto e passando uma lista como parametro.
     [Theory]
        [InlineData(new int[]{2,4})]
         [InlineData(new int[]{6,8,10})]
        
        public void DeveVerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numeros)
        {
        //Arrange: Neste caso o arrange é próprio InLineData.
        //Act e Assert nesse caso serão fundidos. 
        Assert.All(numeros, num => Assert.True(_calc.EhPar(num)));




    }

}