using ExpectedObjects;

namespace Tests;

    public class CursoTeste
    {
        private string _nome;
        private string _descricao;
        private double _cargaHoraria;
        private PublicoAlvo _publico;
        private double _valor;

        public CursoTeste()
        {
            _nome = "Banco de Dados";
            _descricao = "Básico sobre banco de dados relacional";
            _cargaHoraria = 80.00;
            _publico = PublicoAlvo.Universitário;
            _valor = 150.00;
        }

        [Fact]
        public void CriarCurso()
        {   
            var cursoEsperado = new 
            {
                Nome = _nome,
                Descricao = _descricao,
                CargaHoraria = _cargaHoraria,
                Publico = _publico,
                Valor = _valor
            };

            Curso curso = new Curso(cursoEsperado.Nome, cursoEsperado.Descricao, cursoEsperado.CargaHoraria, 
            cursoEsperado.Publico, cursoEsperado.Valor);

            cursoEsperado.ToExpectedObject().ShouldMatch(curso);
        }
        [Theory]
        [InlineData("")]
        [InlineData(null)]
        public void CursoNomeInvalido(string nomeInvalido)
        {
            Assert.Throws<ArgumentException>(() =>
            new Curso(nomeInvalido, this._descricao, this._cargaHoraria, this._publico, this._valor));
        }
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
            // if (nome == string.Empty) throw new ArgumentException();
            // if (nome == null) throw new ArgumentNullException();
            if (string.IsNullOrEmpty(nome)) throw new ArgumentException();
            this.Nome = nome;
            this.Descricao = descricao;
            this.CargaHoraria = cargaHoraria;
            this.Publico = publico;
            this.Valor = valor;
        }
    }
