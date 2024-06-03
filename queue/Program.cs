

using System.ComponentModel;

internal class Program
{
    static Stack<int> stack = new Stack<int>();
    static Queue<int> fila = new Queue<int>();
    static Dictionary<string, string> dictionarys = new Dictionary<string, string>();
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        string input = "";
        while (true)
        {

            Console.WriteLine(
              "| - Menu --------- |\n\n" +
              "1 - Para Add fila\n" +
              "2 - Para Remover fila\n" +
              "3 - Para Add pilha\n" +
              "4 - Para Remover pilha\n" +
              "5 - Para Add dictionarys \n" +
              "6 - Para Remover item dictionarys \n" +
              "0 - Para encerar \n");

            input = Console.ReadLine() ?? "";

            if (input.Equals("")) input = "-1";

            int intImput = Convert.ToInt16(input);

            switch (intImput)
            {
                case 1:
                    AddItemQueue(15);
                    break;
                case 2:
                    RemoveQueue();
                    break;
                case 3:
                    AddItemStack(15);
                    break;
                case 4:
                    RemoverItemStack();
                    break;
                case 5:
                    AddItemDictionary();
                    break;
                case 6:
                    RemoveDictionary();
                    break;
                case 0:
                    return;

            }
        }

    }
    static void AddItemQueue(int qtItem)
    {
        for (int i = 0; i < qtItem; i++)
        {
            fila.Enqueue(i);
        }

        foreach (var item in fila)
        {
            Print(item, "ADD - LIFO -");
        }

    }
    static void RemoveQueue()
    {
        if (fila.Count > 0)
        {
            for (int i = 0; i < fila.Count; i++)
            {
                fila.Dequeue();
                Print(i, "REMOVIDO - LIFO - Primeiro a entra primeiro a sair ");
            }

            foreach (var item in fila)
            {
                Print(item, "ADD - LIFO - ");
            }
        }
    }
    static void AddItemStack(int qtItem)
    {
        for (int i = 0; i < qtItem; i++)
        {
            stack.Push(i);
        }

        foreach (var item in stack)
        {
            Print(item, "ADD - FIFO -");
        }
    }

    static void RemoverItemStack()
    {
        if (stack.Count > 0)
        {
            for (int i = 0; i < stack.Count; i++)
            {
                stack.Pop();
            }
            foreach (var item in stack)
            {
                Print(item, "REMOVIDO - FIFO - Primeiro a entra Ultimo a sair ");
            }

        }
    }

    static void AddItemDictionary()
    {
        dictionarys.Add("SP", "São Paulo");
        dictionarys.Add("MG", "Minas Gerais");
        dictionarys.Add("PR", "Parana");
        dictionarys.Add("SC", "Santa Catarina");

        foreach (var item in dictionarys)
        {
            Console.WriteLine($"{item.Key}  {item.Value}");
        }
        Console.WriteLine("\n");
    }
    static void RemoveDictionary()
    {
        Console.WriteLine("\n");
        Console.WriteLine("Digite a chave :");
        string key = Console.ReadLine() ?? "";

        if (dictionarys.Count > 0)
        {
            if (!key.Equals(""))
            {
                dictionarys.Remove(key);
                Console.WriteLine($"REMOVIDO - {key}\n");
                foreach(var item in dictionarys)
                {
                    Console.WriteLine($"{item.Key}  {item.Value}");
                }
            }
            return;
        }

        if (dictionarys.Count == 0)
        {
            Console.WriteLine("Dictionary esta vazio");
            return;
        }
        Console.WriteLine("Chave não encontra\n");
        return;
    }

    static void Print(int item, string msg)
    {
        Console.WriteLine($"{msg}  {item}");
    }
}


