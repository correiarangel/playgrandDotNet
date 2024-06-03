//using CalcModel.Models;
//using PersonModel.Models;
using ConditionsModel.Models;

//namespace PersonModel.Models;
namespace ConditionsModel.Models
namespace CalcModel.Models;

class Program
{
    static void Main()
    {
        calc.Sum();
    }


    static bool uniqCharacter()
    {
        String? input = "";
        while (input!.Equals(""))
        {
            Console.WriteLine("Digite um texto ou um conjunto de caracter:");
            input = Console.ReadLine();
        }
        List<Char> uniqueChar = [];

        for (int i = 0; i < input.Length; i++)
        {
            Char ch = input[i];
            if (uniqueChar.Contains(ch))
            {
                return false;
            };
            uniqueChar.Add(ch);
        }
        return true;
    }
}
