using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Preencha sua Ficha Cadastral ===");

        // Solicita dados para o usuario 
        Console.Write("Nome: ");                                             //nome 
        string nome = Console.ReadLine();

        Console.Write("Email: ");                                            //email 
        string email = Console.ReadLine();

        Console.Write("Data de Nascimento (DD/MM/AAAA): ");                   
        DateTime dataNascimento = DateTime.Parse(Console.ReadLine());        //data de nascimento 

        Console.Write("Sexo (M/F): ");                                       //sexo
        char sexo = char.Parse(Console.ReadLine());

        Console.Write("CEP: ");                                              //cep
        int cep =  int.Parse(Console.ReadLine());

        Console.Write("Rua: ");                                              //rua
        string rua = Console.ReadLine();

        Console.Write("Número: ");                                            //numero
        int numero = int.Parse(Console.ReadLine());

        Console.Write("Bairro: ");                                            //bairro
        string bairro = Console.ReadLine();

        Console.Write("Cidade: ");                                            //cidade
        string cidade = Console.ReadLine();

        Console.Write("UF: ");                                                //estado / uf
        string uf = Console.ReadLine();

        Console.Write("País: ");                                              //pais
        string pais = Console.ReadLine();

        // Exibe ficha cadastral
        Console.WriteLine("\n=== Ficha Cadastral ===");
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Email: {email}");
        Console.WriteLine($"Data de Nascimento: {dataNascimento.ToShortDateString()}");
        Console.WriteLine($"Sexo: {sexo}");
        Console.WriteLine($"CEP: {cep}");
        Console.WriteLine($"Rua: {rua}");
        Console.WriteLine($"Número: {numero}");
        Console.WriteLine($"Bairro: {bairro}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"UF: {uf}");
        Console.WriteLine($"País: {pais}");
    }
}