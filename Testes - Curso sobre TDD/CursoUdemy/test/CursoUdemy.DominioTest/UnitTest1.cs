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
            // Organização
            var variavel1 = 1;
            var variavel2 = 1;

            // Ação
            variavel2 = variavel1;

            // Asserts
            Assert.Equal(variavel1, variavel2);
        }
    }
}
