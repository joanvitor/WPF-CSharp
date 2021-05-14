using CursoUdemy.DominioTest._Util;
using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoUdemy.DominioTest.Cursos
{
    // "Eu, enquanto adm, quero criar e editar cursos para que sejam abertas matriculas para o mesmo.

    // Criterio de aceite

    // 1 - Criar um curso com nome, carga horaria, publico alvo e valor do curso
    // 2 - As opções para publico alvo são: estudante, universitario, empregado e empreendedor
    // 3 - Todos os campos do curso são obrigatorios
    public class CursoTest
    {
        [Fact]
        public void CriarCurso()
        {
            //// Organização
            //string Nome = "Informática Básica";
            //double CargaHoraria = 80;
            //string PublicoAlvo = "Informática Básica";
            //double ValorCurso = 950;

            //// Ação
            //var curso = new Curso(Nome, CargaHoraria, PublicoAlvo, ValorCurso);

            //// Asserts
            //Assert.Equal(Nome, curso.Nome);
            //Assert.Equal(CargaHoraria, curso.CargaHorarira);
            //Assert.Equal(PublicoAlvo, curso.PublicoAlvo);
            //Assert.Equal(ValorCurso, curso.ValorCurso);

            // Utilização do ExpectedObjects
            var CursoEsperado = new
            {
                Nome = "Informática Básica",
                CargaHoraria = (double) 80,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double) 950
            };

            var curso = 
                new Curso(CursoEsperado.Nome, CursoEsperado.CargaHoraria, CursoEsperado.PublicoAlvo, CursoEsperado.ValorCurso);

            // Para não ter N asserts, teria apenas o ShouldMatch
            CursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }

        // Aula sobre - Tratando parametros inválidos
        // Usa Theory para criar testes parametrizados com inlinedata, pq se fosse o FACT iria precisar ter 2 metodos identicos (1 para tratar null e outro vazio "")
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void CursoNaoPodeTerNomeInvalido(string nomeInvalido)
        {
            var CursoEsperado = new
            {
                Nome = "Informática Básica",
                CargaHoraria = (double)80,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)950
            };

            // Valida se houve uma exceção do tipo ArgumentException
            // Se não tiver exceção ou o exception for diferente do ArgumentException, o teste irá falhar, na criação do objeto
            //var messagem = Assert.Throws<ArgumentException>(() 
            //    => new Curso(
            //        nomeInvalido, 
            //        CursoEsperado.CargaHoraria, 
            //        CursoEsperado.PublicoAlvo, 
            //        CursoEsperado.ValorCurso)
            //    ).Message;
            //Assert.Equal("Nome inválido", messagem);

            // Utilizando a Extensão criada na classe AssertExtension
            Assert.Throws<ArgumentException>(()
                => new Curso(
                    nomeInvalido,
                    CursoEsperado.CargaHoraria,
                    CursoEsperado.PublicoAlvo,
                    CursoEsperado.ValorCurso)
                ).ComMensagem("Nome inválido");

        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void CursoNaoDeveTerCargaHorariaMenorQue1(double CargaHorariaInvalida)
        {
            var CursoEsperado = new
            {
                Nome = "Informática Básica",
                CargaHoraria = (double)80,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)950
            };

            Assert.Throws<ArgumentException>(()
                => new Curso(
                    CursoEsperado.Nome, 
                    CargaHorariaInvalida, 
                    CursoEsperado.PublicoAlvo, 
                    CursoEsperado.ValorCurso)
                ).ComMensagem("Carga horária inválida");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(-2)]
        [InlineData(-100)]
        public void CursoNaoDeveTerValorMenorQue1(double ValorInvalido)
        {
            var CursoEsperado = new
            {
                Nome = "Informática Básica",
                CargaHoraria = (double)80,
                PublicoAlvo = PublicoAlvo.Estudante,
                ValorCurso = (double)950
            };

            Assert.Throws<ArgumentException>(()
                => new Curso(
                    CursoEsperado.Nome, 
                    CursoEsperado.CargaHoraria,
                    CursoEsperado.PublicoAlvo, 
                    ValorInvalido)
                ).ComMensagem("Valor inválido");
        }

        public enum PublicoAlvo
        {
            Estudante,
            Universitario,
            Empregado,
            Empreendedor
        }

        public class Curso
        {
            public string Nome { get; private set; }
            public double CargaHoraria { get; private set; }
            public PublicoAlvo PublicoAlvo { get; private set; }
            public double ValorCurso { get; private set; }

            public Curso(string nome, double CargaHoraria, PublicoAlvo publicoAlvo, double valorCurso)
            {
                if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome inválido");

                if (CargaHoraria < 1) throw new ArgumentException("Carga horária inválida");

                if (valorCurso < 1) throw new ArgumentException("Valor inválido");

                this.Nome = nome;
                this.CargaHoraria = CargaHoraria;
                this.PublicoAlvo = publicoAlvo;
                this.ValorCurso = valorCurso;
            }
        }
    }
}
