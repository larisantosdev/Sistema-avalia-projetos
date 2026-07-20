namespace SistemaAvaliaProjetos.Models
{
    class Projeto {
        
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
    
}

