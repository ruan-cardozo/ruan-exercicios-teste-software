namespace Tests;

public class UnitTest1
{
    [Fact]
    public void CriarCurso()
    {
        // Arrange
        string Nome = "Banco de dados";
        double CargaHoraria = 18;
        PublicoAlvo Publico = PublicoAlvo.Profissional;
        double Valor = 150.15;
        // Act
        Curso curso = new Curso(Nome, CargaHoraria, Publico, Valor);
    
        // Assert
        Assert.Equal(Nome,curso.Nome);
        Assert.Equal(CargaHoraria,curso.CargaHoraria);
        Assert.Equal(Publico, curso.Publico);
        Assert.Equal(Valor, curso.Valor);
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
        private double cargaHoraria;
        private PublicoAlvo publico;
        private double valor;
        public string Nome { get => nome; private set => nome = value; }
        public double CargaHoraria { get => cargaHoraria; private set => cargaHoraria = value; }
        public PublicoAlvo Publico { get => publico; private set => publico = value; }
        public double Valor { get => valor; private set => valor = value; }
        public Curso(string nome, double cargaHoraria, PublicoAlvo publico, double valor)
        {   
            this.Nome = nome;
            this.CargaHoraria = cargaHoraria;
            this.Publico = publico;
            this.Valor = valor;
        }
    }
}
