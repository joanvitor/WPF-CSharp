using System;
using Xunit;

namespace CursoUdemy.DominioTest
{
    public class UnitTest1
    {
        //[Fact]
        [Fact(DisplayName = "Test1")]
        public void TesteIgualdadeEntre2Variaveis()
        {
            // AAA 
            // Organiza��o
            var variavel1 = 1;
            var variavel2 = 1;

            // A��o
            variavel2 = variavel1;

            // Asserts
            Assert.Equal(variavel1, variavel2);
        }
    }
}
