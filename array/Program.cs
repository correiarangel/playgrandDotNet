//using System;
using System;
using System.Collections.Generic;

class Program
{
      static void exibeList(List<string> itens)
    {
        Console.WriteLine("Lista de itens:");
        foreach (string item in itens)
        {
            Console.WriteLine($"- {item}");
        }
        return;
    }
    
    static List<string> GetList()
    {
        List<string> itens = new List<string>();

        // TODO: Solicite os itens ao usuário
        for (int i = 0; i < 3; i++)
        {
            //  Console.WriteLine("Digite uma arma:");
            string? imput = Console.ReadLine();
           imput??="";
            if (imput.Equals("")) itens.Add(imput);
        }
        return itens;
    }
  
  
    static void Main(string[] args)
    {
        // Lista para armazenar os itens
        List<string> itens = new List<string>();
        itens = GetList();

        // Exibe a lista de itens
        exibeList(itens);
    }
}
/* 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o saldo atual: ");
        int saldoTotal = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o valor do saque: ");
        int valorSaque = Convert.ToInt32(Console.ReadLine());
        bool result = CalcSaldoParaSaque(saldoTotal, valorSaque);
        if (result)
        {
            EfetuarSaque(saldoTotal, valorSaque);
            return;
        }
        Console.WriteLine("Saldo insuficiente. Saque nao realizado!");
    }
    static void EfetuarSaque(int saldo, int saque)
    {
        int saldoFinal = saldo - saque;
        Console.WriteLine($"Saque realizado com sucesso.\nNovo saldo:{saldoFinal}.");

    }
    static bool CalcSaldoParaSaque(int saldo, int saque)
    {
        if (saldo >= saque) return true;
        return false;
    }
}
 */
/* 

class Program
{
    static void Main()
    {
        //arrayString();
        //Tabuada();
       var lst = listUser();
       IsName(lst,"Name - x");
    }

    static void arrayString()
    {
        string[] arrayStr = ["Arara", "Arpia", "Carcara", "Coruja"];

        Console.WriteLine($"Array...");


        foreach (var item in arrayStr)
        {
            Console.WriteLine($"| {item} | \n");
        }

    }
    static void arrayInt()
    {
        int[] arrayInt = { 11, 34, 21, 44, 55, 6 };

        Console.WriteLine($"Array...");

        foreach (var item in arrayInt)
        {
            Console.WriteLine($"-| {item} |- \n");
        }



    }
    static bool IsName(List<string> lstUser, string name)
    {
        Console.WriteLine($"Buscando por : {name}");
        bool result = lstUser.Contains(name);
        if (result) Console.WriteLine($"O valor : {name} foi encontrado ;)");
        if (!result) Console.WriteLine($"O valor : {name} não foi encontrado :(");
        return result;
    }

    static List<string> listUser()
    {
        List<string> lstUser = [];
        Console.WriteLine($"Array...");

        for (int i = 0; i < 10; i++)
            lstUser.Add($"Name - {i}");

        foreach (var item in lstUser)
            Console.WriteLine($"-| {item} |- \n");

        return lstUser;

    }
    static void Tabuada()
    {
        Console.WriteLine($"Tabuada...\n");
        int[] arrayTab = new int[11];
        Console.WriteLine("Qual a tabuada: ");
        int tab = Convert.ToInt16(Console.ReadLine());
        for (int i = 0; i < 11; ++i)
        {
            arrayTab[i] = i;
            Console.WriteLine($"{tab} x {arrayTab[i]} = {tab * arrayTab[i]}");
        }
        Console.WriteLine($"...\n");
    }
}

 */