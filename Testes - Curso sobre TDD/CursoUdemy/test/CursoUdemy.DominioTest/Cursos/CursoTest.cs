using ExpectedObjects;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoUdemy.DominioTest.Cursos
{
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
                PublicoAlvo = "Estudante",
                ValorCurso = (double) 950
            };

            var curso = 
                new Curso(CursoEsperado.Nome, CursoEsperado.CargaHoraria, CursoEsperado.PublicoAlvo, CursoEsperado.ValorCurso);

            // Para não ter N asserts, teria apenas o ShouldMatch
            CursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }

        public class Curso
        {
            public string Nome { get; private set; }
            public double CargaHoraria { get; private set; }
            public string PublicoAlvo { get; private set; }
            public double ValorCurso { get; private set; }

            public Curso(string nome, double CargaHoraria, string publicoAlvo, double valorCurso)
            {
                this.Nome = nome;
                this.CargaHoraria = CargaHoraria;
                this.PublicoAlvo = publicoAlvo;
                this.ValorCurso = valorCurso;
            }
        }
    }
}
