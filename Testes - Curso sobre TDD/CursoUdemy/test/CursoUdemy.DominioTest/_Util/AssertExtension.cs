using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoUdemy.DominioTest._Util
{
    // Classe de extensão tem que ser estatica
    public static class AssertExtension
    {
        // Criando metodo de extensão para a classe ArgumentException
        // Como eu sei disso ? Porque o parametro ArgumentException, antes dele tem o this
        public static void ComMensagem(this ArgumentException exception, string mensagem)
        {
            if (exception.Message == mensagem)
                Assert.True(true);
            else
                Assert.False(true, $"Esperava a mensagem {mensagem}");
        }
    }
}
