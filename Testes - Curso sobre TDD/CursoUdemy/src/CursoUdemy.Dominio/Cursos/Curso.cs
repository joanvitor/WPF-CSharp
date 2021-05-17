using System;
using System.Collections.Generic;
using System.Text;

namespace CursoUdemy.Dominio.Cursos
{
    public class Curso
    {
        public string Nome { get; private set; }
        public double CargaHoraria { get; private set; }
        public PublicoAlvo PublicoAlvo { get; private set; }
        public double ValorCurso { get; private set; }
        public string Descricao { get; }

        public Curso(string nome, string descricao, double cargaHoraria, PublicoAlvo publicoAlvo, double valorCurso)
        {
            if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome inválido");

            if (cargaHoraria < 1) throw new ArgumentException("Carga horária inválida");

            if (valorCurso < 1) throw new ArgumentException("Valor inválido");

            this.Nome = nome;
            this.Descricao = descricao;
            this.CargaHoraria = cargaHoraria;
            this.PublicoAlvo = publicoAlvo;
            this.ValorCurso = valorCurso;
        }
    }
}
