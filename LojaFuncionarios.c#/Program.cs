
using System.Collections.Generic;


public class Funcionario
{
    public int Id;
    public string Name;
    public int Salario;



    public Funcionario() { }

    public Funcionario(int id, string name, int salario)
    {
        
        int Id = id;
        string Name = name;
        int Salario = salario;


    }
    



}

class Program
{
    static void Main()
    {
        List<Funcionario> funcionarios = new List<Funcionario>();



        Console.WriteLine(" Quantos funcionários serão registrados ? ");

        int QuantFunc = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < QuantFunc; i++)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine($"FUNCIONÁRIO(A) { i + 1}: ");

            
            Console.Write("Id: ");
            funcionario.Id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nome: ");
            funcionario.Name = Console.ReadLine();


            Console.Write("Salario: ");
            funcionario.Salario = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("---------------------");

            funcionarios.Add(funcionario);

        }

        Console.WriteLine("Insira o ID do funcionário que terá aumento salarial");
        int idFuncionario = Convert.ToInt32(Console.ReadLine());

        if (funcionarios.Any(f => f.Id == idFuncionario))
        
        {
        }
        else
        {
            Console.Write("This id does not exist! ");
        }

        Console.WriteLine("Insira a porcentagem");
        int porcentagem = Convert.ToInt32(Console.ReadLine());

        foreach (var funcionario in funcionarios)
        {
            if (funcionario.Id == idFuncionario)
            {
                funcionario.Salario += (int)(funcionario.Salario * (porcentagem / 100.0));

            }

        }
        Console.WriteLine("\nFuncionários com salários atualizados:");

        foreach (var funcionario in funcionarios)
        {
            Console.WriteLine($"{funcionario.Id}, {funcionario.Name}, {funcionario.Salario:F2}");
        }
    }

}



