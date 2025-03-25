# 🚀 POO - Programação Orientada a Objetos

Este projeto é uma solução em C# desenvolvida no Visual Studio, focada em conceitos de **Programação Orientada a Objetos (POO)**. Ele contém uma estrutura de classes para demonstração de conceitos fundamentais como **herança**, **encapsulamento** e **polimorfismo**. 🎯

## 📌 Índice:
- 🛠️ [Tecnologias Utilizadas](#-tecnologias-utilizadas)
- 📥 [Instalação](#-instalação)
- 🚀 [Como Usar](#-como-usar)
- 🧑‍💻 [Classes (Exemplos)](#-classes-exemplos)
- 📋 [Exercícios de Classe](#-exercícios-de-classe)
- 📦 [Estrutura do Código](#-estrutura-do-codigo)

## 🛠️ Tecnologias Utilizadas:

- 🔹 [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/)
- 🏗️ [.NET Framework/Core](https://dotnet.microsoft.com/)
- 🖥️ [Visual Studio](https://visualstudio.microsoft.com/)

## 📥 Instalação:

1. **Clone este repositório:**
   ```sh
   git clone https://github.com/Kalimbinha/POO.git
   ```
2. **Acesse o diretório do projeto:**
   ```sh
   cd POO
   ```
3. **Abra o projeto no Visual Studio.**
4. **Compile e execute o projeto.** ▶️

## 🚀 Como Usar:

Este projeto serve como um **modelo de estruturação de classes em C#**. Para rodá-lo:

1. Abra o **Visual Studio** e carregue a solução `POO.sln`. 💻
2. Compile e execute no modo **Debug** ou **Release** conforme necessário. 🛠️
3. Modifique as classes para testar diferentes cenários de **POO**. 🎭

---

## 💡 Exemplo de Uso:

Aqui está um exemplo de como usar a classe `Carro`:

```csharp
// Criando um carro vermelho
Carro carro1 = new Carro();
carro1.Cor = "Vermelho";
Console.WriteLine(carro1.Cor); // Saída: Vermelho
```

---

## 🧑‍💻 Classes (Exemplos):

- 🚗 **[Carros Coloridos](Classess/Classess/Exercicios_Slide/Exercicio_1.cs)**: Criação de instâncias de carros com cores diferentes.

```csharp
// Criando instâncias de carros com cores diferentes
Carro carro1 = new Carro();
carro1.Cor = "Vermelho";

Carro carro2 = new Carro();
carro2.Cor = "Azul";

Console.WriteLine(carro1.Cor); // Saída: Vermelho
Console.WriteLine(carro2.Cor); // Saída: Azul
```

- 🎲 **[Carros Aleatórios](Classess/Classess/Exercicios_Slide/Exercicio_2.cs)**: Criação de 1000 instâncias de carros com cores aleatórias e contagem das cores.

```csharp
Random rand = new Random();
string[] cores = { "Vermelho", "Azul", "Verde", "Preto", "Branco" };
int[] contagemCores = new int[cores.Length];

for (int i = 0; i < 1000; i++)
{
    string corAleatoria = cores[rand.Next(cores.Length)];
    int indiceCor = Array.IndexOf(cores, corAleatoria);
    contagemCores[indiceCor]++;
}

// Exibindo contagem de cada cor
for (int i = 0; i < cores.Length; i++)
{
    Console.WriteLine($"{cores[i]}: {contagemCores[i]}");
}
```

- 🚦 **[Simulação de Trânsito](Classess/Classess/Exercicios_Slide/Exercicio_3.cs)**: Simulação de aceleração, frenagem e multas para carros que ultrapassam o limite de velocidade.

```csharp
public class Carro
{
    public string Cor { get; set; }
    public int Velocidade { get; set; }

    public void Acelerar(int incremento)
    {
        Velocidade += incremento;
        Console.WriteLine($"Velocidade após aceleração: {Velocidade} km/h");
    }

    public void Frear(int decremento)
    {
        Velocidade -= decremento;
        if (Velocidade < 0) Velocidade = 0;
        Console.WriteLine($"Velocidade após frenagem: {Velocidade} km/h");
    }

    public void VerificarMulta(int limiteVelocidade)
    {
        if (Velocidade > limiteVelocidade)
        {
            Console.WriteLine($"Multa! Você ultrapassou o limite de velocidade de {limiteVelocidade} km/h.");
        }
        else
        {
            Console.WriteLine("Você está dentro do limite de velocidade.");
        }
    }
}

// Exemplo de uso
Carro carro1 = new Carro();
carro1.Cor = "Preto";
carro1.Acelerar(80);
carro1.VerificarMulta(60); // Saída: Multa! Você ultrapassou o limite de velocidade de 60 km/h.
```

- 🚗 **[Classe dos Carros](Classess/Classess/Exercicios_Slide/Classes.cs)**: Classe base para representar carros com atributos como cor.

```csharp
public class Carro
{
    public string Cor { get; set; }
    public string Modelo { get; set; }

    public Carro(string cor, string modelo)
    {
        Cor = cor;
        Modelo = modelo;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Modelo: {Modelo}, Cor: {Cor}");
    }
}

// Exemplo de uso
Carro carro1 = new Carro("Vermelho", "Fusca");
carro1.ExibirInformacoes(); // Saída: Modelo: Fusca, Cor: Vermelho
```

---

## 📦 Estrutura do Código:
A estrutura do projeto segue a seguinte organização de pastas:
```
POO/
├── Classess/
│   ├── Exercicios_Slide/
│   │   ├── Classes
│   │   |   ├── Classes.cs
│   │   |   ├── Exercicio_1.cs
│   │   |   ├── Exercicio_2.cs
│   │   |   ├── Exercicio_3.cs
│   │   |   ├── Exercicio_4.cs
│   │   ├── Construtores
│   │   |   ├── Aluno
│   │   |   |   ├── Aluno.cs
│   │   |   |   ├── Exercicio_3.cs
│   │   |   ├── Funcionarios
│   │   |   |   ├── Execicio_1.cs
│   │   |   |   ├── Funcionario.cs
│   │   |   ├── Retangulo
│   │   |   |   ├── Exercicio_2.cs
│   │   |   |   ├── Retangulo.cs
│   │   ├── Encapsulamento
│   │   |   |   ├── Aulas
│   │   |   |   |   ├── Aluno.cs
│   │   |   |   |   ├── Aula.cs
│   │   |   |   ├── Biblioteca
│   │   |   |   |   ├── Biblioteca.cs
│   │   |   |   |   ├── Exercicio_2.cs
│   │   |   |   |   ├── Livro.cs
│   │   |   |   ├── Conta Bancaria
│   │   |   |   |   ├── Carteira.cs
│   │   |   |   |   ├── Conta.cs
│   │   |   |   |   ├── Exercicio_1.cs
│   │   |   |   ├── RPG
│   │   |   |   |   ├── Exercicio_3.cs
│   │   |   |   |   ├── Personagem.cs
│   ├── Lista_1/
│   │   ├── Exercicio_1.cs
|   |   ├── Funcionarios.cs
├── Classess.sln
├── README.md
```
Cada diretório contém exercícios e implementações relacionadas a conceitos de POO em C#.

