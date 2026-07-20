using System;
using System.Globalization;

class Projeto{
  
  public string Nome {get; set;}
  public string Consultor {get; set;}
  public int Qualidade {get; set;}
  public int Prazo {get; set;}
  public int Satisfacao {get; set;}

  // metodo que calculo a media das notas
  
  public double CalcularMedia(){
    
    return (Satisfacao + Qualidade + Prazo) / 3.0;
    
  } 

    // Método que imprime as informações no formato solicitado
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Projeto: {Nome}");
        Console.WriteLine($"Consultor: {Consultor}");
        Console.WriteLine($"Notas: Qualidade: {Qualidade}, Prazo: {Prazo}, Satisfacao: {Satisfacao}");
        Console.WriteLine($"Media: {CalcularMedia():F2}");
    }
}

class Program
{
    static void Main()
    {
        string linhaProjeto = Console.ReadLine(); 
        string nomeProjeto = linhaProjeto.Substring(9); 

        string linhaConsultor = Console.ReadLine(); 
        string nomeConsultor = linhaConsultor.Substring(11); 
        
        string linhaNotas = Console.ReadLine(); 
        string notasApenas = linhaNotas.Substring(7); 
        string[] partes = notasApenas.Split(", "); 

        // Criação do objeto Projeto com os dados extraídos
        Projeto projeto = new Projeto
        {
            Nome = nomeProjeto,
            Consultor = nomeConsultor,
            Qualidade = int.Parse(partes[0]),
            Prazo = int.Parse(partes[1]),
            Satisfacao = int.Parse(partes[2])
        };

        projeto.ExibirInformacoes();
    }
}