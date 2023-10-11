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

    [Theory]
    [InlineData("")]
    [InlineData(null)]
    public void CursoNomeInvalido(string nomeInvalido)
    {
        var mensagem = Assert.Throws<ArgumentException>(() =>
            new Curso(nomeInvalido, this._descricao, this._carga, this._publico, this._valor)).Message;
            Assert.Equal("Nome vazio ou nulo", mensagem);
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
        // if (nome == string.Empty) throw new ArgumentException("Nome vazio");
        // if (nome == null) throw new ArgumentNullException("Nome nulo");
        if (string.IsNullOrEmpty(nome)) throw new ArgumentException("Nome vazio ou nulo");
        this.Nome = nome;
        this.Descricao = descricao;
        this.CargaHoraria = cargaHoraria;
        this.Publico = publico;
        this.Valor = valor;
    }
}
    internal static class ArgumentExceptionExtension
    {
        public static void ComMensagem(this ArgumentException excecao, string mensagem)
        {
            if (excecao.Message == mensagem) 
            {
                Assert.True(true);
            }
            else 
            {
                Assert.False(true);
            }
       }
    }   