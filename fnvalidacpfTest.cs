using System;
using Xunit;

namespace httpValidaCPF.Tests
{
    public class fnvalidacpfTest
    {
        [Theory]
        [InlineData("123.456.789-09", false)] // Invalid CPF
        [InlineData("111.111.111-11", false)] // Invalid CPF with repeated digits
        [InlineData("529.982.247-25", true)]  // Valid CPF
        [InlineData("000.000.000-00", false)] // Invalid CPF with repeated digits
        [InlineData("12345678909", false)]    // Invalid CPF without formatting
        [InlineData("52998224725", true)]     // Valid CPF without formatting
        [InlineData("", false)]               // Empty CPF
        [InlineData(null, false)]             // Null CPF
        public void ValidandoCPF_ShouldValidateCorrectly(string cpf, bool expected)
        {
            // Act
            var result = fnvalidacpf.ValidandoCPF(cpf);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}