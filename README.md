1 – Considere o teste de instanciação abaixo. Do ponto de vista conceitual de testes unitários, qual é o problema que
pode ser encontrado no código abaixo?

Não segue a prática de ter um único `assert` por teste, o que é uma recomendação comum em testes unitários. O teste atualmente possui quatro afirmações (`Assert.Equal`) em um único método de teste, cada uma verificando um atributo diferente do objeto `Curso`.

O problema principal com vários `asserts` em um único teste é que, se um `assert` falhar, não fica claro qual parte do código ou qual atributo do objeto `Curso causou a falha. Isso torna mais difícil identificar e solucionar problemas, tornando os testes menos informativos e menos eficazes como ferramentas de depuração.

Para aderir às boas práticas de testes unitários, você pode dividir esse teste em vários testes individuais, cada um testando um atributo específico da classe `Curso. 

Por exemplo:
```csharp
[Fact]
public void TestNomeDoCurso()
{
    // Arrange
    string nomeEsperado = "Banco de dados";

    // Act
    Curso curso = new Curso(nomeEsperado, 18, PublicoAlvo.Profissional, 150.15);

    // Assert
    Assert.Equal(nomeEsperado, curso.Nome);
}

[Fact]
public void TestCargaHorariaDoCurso()
{
    // Arrange
    double cargaHorariaEsperada = 18;

    // Act
    Curso curso = new Curso("Banco de dados", cargaHorariaEsperada, PublicoAlvo.Profissional, 150.15);

    // Assert
    Assert.Equal(cargaHorariaEsperada, curso.CargaHoraria);
}

```

Dessa forma, cada teste verifica um único aspecto do objeto `Curso`, tornando os testes mais claros, informativos e fáceis de depurar, se necessário.