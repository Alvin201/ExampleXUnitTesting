using System;
using Xunit;

namespace MathDemo.function;

public class MatematicUnitTest
{
    [Fact]
    public void GanjilNumberTest() 
    {
            //Arrange
            var num = 7;
            //Act
            bool result = Mathematics.isGanjil(num);
            //Assert
            Assert.True(result);
    }
    [Fact]
    public void GenapNumberTest()
    {
            //Arrange
            var num = 4;
            //Act
            bool result = Mathematics.isGenap(num);
            //Assert
            Assert.True(result);
    }
    [Fact]
    public void KuadratNumberTest()
    {
            //Arrange
            var num = 5;
            var expectedResult = 25;
            //Act
            var result = Mathematics.isKuadrat(num);
            //Assert
            Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void PenjumlahanOfNumber() 
    {
            //Arrange
            var num1 = 5;
            var num2 = 2;
            var expectedResult = 7;
            //Act
            var result = Mathematics.Ispenjumlahan(num1, num2);
            //Assert
            Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void PenguranganOfNumber()
    {
            //Arrange
            var num1 = 5;
            var num2 = 2;
            var expectedResult = 3;
            //Act
            var result = Mathematics.Ispengurangan(num1, num2);
            //Assert
            Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void PerkalianNumber() 
    {
            //Arrange
            var num1 = 5;
            var num2 = 2;
            var expectedResult = 10;
            //Act
            var result = Mathematics.Isperkalian(num1, num2);
            //Assert
            Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void PembagianNumber() 
    {
        //Arrange
        var num1 = 10;
        var num2 = 2;
        var expectedResult = 5;
        //Act
        var result = Mathematics.Ispembagian(num1, num2);
        //Assert
        Assert.Equal(expectedResult, result);
    }
}
