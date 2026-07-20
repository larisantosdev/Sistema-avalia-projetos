using System;
using System.Globalization;
using SistemaAvaliaProjetos.Models;


        Console.WriteLine("Digite os dados do projeto:");
        string nomeProjeto = Console.ReadLine();

        //string nomeProjeto = linhaProjeto.Substring(9); 

        string nomeConsultor = Console.ReadLine(); 
        //string nomeConsultor = linhaConsultor.Substring(11); 
        
        string notasApenas = Console.ReadLine(); 
        //string notasApenas = linhaNotas.Substring(7);
        
        string[] partes = notasApenas.Split(" "); 

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