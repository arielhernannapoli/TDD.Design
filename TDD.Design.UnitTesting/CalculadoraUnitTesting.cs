using FluentAssertions;
using TDD.Design.Model;
using Xunit;

namespace TDD.Design.UnitTesting;

public class CalculadoraUnitTesting
{
    private Calculadora calculadora;

    public CalculadoraUnitTesting()
    {
        this.calculadora = new Calculadora();
    }

    [Fact]
    public void calculadoraSuma_shouldReturnsSumatoria()
    {
        var resultado = calculadora.Sumar(10,20);
        resultado.Should().Be(30);
    }

    [Fact]
    public void calculadoraResta_shouldReturnsSubstraccion()
    {
        var resultado = calculadora.Restar(30, 10);
        resultado.Should().Be(20);
    }

    [Fact]
    public void calculadoraMultiplica_shouldReturnsMultiplication()
    {        
        var resultado = calculadora.Multiplicar(30, 10);
        resultado.Should().Be(300);
    }

    [Fact]
    public void calculadoraDivide_shouldReturnsDivision()
    {
        var resultado = calculadora.Dividir(30, 10);
        resultado.Should().Be(3);
    }
}