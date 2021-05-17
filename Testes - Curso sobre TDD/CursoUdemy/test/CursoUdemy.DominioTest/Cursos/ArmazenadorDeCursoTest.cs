using Bogus;
using CursoUdemy.Dominio.Cursos;
using CursoUdemy.DominioTest._Util;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CursoUdemy.DominioTest.Cursos
{
    public class ArmazenadorDeCursoTest
    {
        private readonly ArmazenadorDeCurso _armazenadorDeCurso;
        private readonly CursoDto _cursoDTO;
        private readonly Mock<ICursoRepositorio> _cursoRepositorioMock;

        public ArmazenadorDeCursoTest()
        {
            var fake = new Faker();

            _cursoDTO = new CursoDto
            {
                Nome = fake.Random.Words(),
                Descricao = fake.Lorem.Paragraph(),
                CargaHoraria = fake.Random.Double(50, 1000),
                PublicoAlvo = "Estudante",
                Valor = fake.Random.Double(1000, 2000)
            };

            _cursoRepositorioMock = new Mock<ICursoRepositorio>();

            _armazenadorDeCurso = new ArmazenadorDeCurso(_cursoRepositorioMock.Object);
        }

        [Fact]
        public void DeveAdicionar()
        {
            _armazenadorDeCurso.Armazenar(_cursoDTO);

            //Pode ser que esteja passando um Curso X e na hora de instanciar tenha o Curso Y, logo está errado
            // Então utiliza o Is
            _cursoRepositorioMock.Verify(r => r.Adicionar(
                It.Is<Curso>(
                    c => c.Nome == _cursoDTO.Nome
                    && c.Descricao == _cursoDTO.Descricao
                )
            ));
            // Times.AtLeast(2) - espera que o metodo seja chamado pelo menos duas vezes
        }

        [Fact]
        public void NaoDeveInformarPublicoAlvoInvalido()
        {
            // Medico é uma OPÇÃO inválida pro publico alvo
            _cursoDTO.PublicoAlvo = "Médico";

            Assert.Throws<ArgumentException>(() => _armazenadorDeCurso.Armazenar(_cursoDTO))
                .ComMensagem("Público alvo inválido");
        }
    }

    public interface ICursoRepositorio
    {
        void Adicionar(Curso curso);
        void Atualizar(Curso curso);
    }

    public class ArmazenadorDeCurso
    {
        private readonly ICursoRepositorio _cursoRepositorio;

        public ArmazenadorDeCurso(ICursoRepositorio cursoRepositorio)
        {
            _cursoRepositorio = cursoRepositorio;
        }

        public void Armazenar(CursoDto cursoDto)
        {
            Enum.TryParse(typeof(PublicoAlvo), cursoDto.PublicoAlvo, out var publicoAlvo);

            if (publicoAlvo == null)
                throw new ArgumentException("Público alvo inválido");

            var curso = new Curso(
                cursoDto.Nome,
                cursoDto.Descricao,
                cursoDto.CargaHoraria,
                PublicoAlvo.Estudante,
                cursoDto.Valor);

            _cursoRepositorio.Adicionar(curso);
        }
    }

    public class CursoDto
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public double CargaHoraria { get; set; }
        public string PublicoAlvo { get; set; }
        public double Valor { get; set; }
    }
}
