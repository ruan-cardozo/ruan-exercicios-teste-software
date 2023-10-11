using ExpectedObjects;

namespace Tests;

    public class CursoTeste
    {
        private string _nome;
        private string _descricao;
        private double _carga;
        private PublicoAlvo _publico;
        private double _valor;
    public CursoTeste()
    {
        _nome = "Banco de Dados";
        _descricao = "Básico sobre banco de dados relacional";
        _carga = 80;
        _publico = PublicoAlvo.Universitário;
        _valor = 150.00;
    }
    
    [Fact]
    public void CriarCurso()
    {
        // Arrange
        var cursoEsperado = new
        {
            Nome = _nome,
            Descricao = _descricao,
            CargaHoraria = _carga,
            Publico = _publico,
            Valor = _valor
        };
        // Act
        Curso curso = new Curso(cursoEsperado.Nome, cursoEsperado.Descricao,
        cursoEsperado.CargaHoraria, cursoEsperado.Publico, cursoEsperado.Valor);
        // Assert
        cursoEsperado.ToExpectedObject().ShouldMatch(curso);
    }

    public enum PublicoAlvo
    {
        Secundarista,
        Universitário,
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
        public string Nome { get => nome; private set => nome = value; }
        public string Descricao { get => descricao; private set => descricao = value; }
        public double CargaHoraria { get => cargaHoraria; private set => cargaHoraria = value; }
        public PublicoAlvo Publico { get => publico; private set => publico = value; }
        public double Valor { get => valor; private set => valor = value; }
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
