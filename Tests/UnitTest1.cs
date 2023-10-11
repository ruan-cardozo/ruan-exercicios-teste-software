using ExpectedObjects;

namespace Teste
{
    public class CursoTeste 
    {
        [Fact]
        public void CriarCurso()
        {
            //Arrange
            var cursoEsperado = new
            {
                Nome = "Banco de Dados" ,
                Descricao ="Básico sobre banco de dados relacional" ,
                CargaHoraria = 80,
                Publico = PublicoAlvo.Universitário,
                Valor= 150.00
            };
            // Act
            Curso curso = new Curso(cursoEsperado.Nome, cursoEsperado.Descricao,
            cursoEsperado.CargaHoraria, cursoEsperado.Publico, cursoEsperado.Valor);
            // Assert
            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }
    }   

    public enum PublicoAlvo
    {
        Secundarista,
        Universitário ,
        Profissional,
        Empreendedor
    }




    public class Curso
    {
        private string nome;
        private string descricao;
        private double cargaHoraria;
        private PublicoAlvo publico;
        private double valor;

        public string Nome { get=>nome; private set=>nome = value; }
        public string Descricao { get=>descricao; private set => descricao = value; }
        public double CargaHoraria { get=>cargaHoraria; private set => cargaHoraria = value; }
        public PublicoAlvo Publico { get=>publico; private set=>publico = value; }
        public double Valor { get => valor; private set=> valor = value; }

        public Curso(string nome, string descricao, double cargaHoraria, PublicoAlvo publico, double valor)
        {
            this.Nome = nome;
            this.Descricao = descricao;
            this.CargaHoraria = cargaHoraria;
            this.Publico = publico;
            this.Valor = valor;
        }       
    }  
}  