
namespace ConditionsModel.Models
{
    public class ConditionsModel
    {


        public static void IsVogal()
        {
            string input = Getcharacter();

            switch (input)
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine($"{input} -> É uma consoante ");
                    break;

                default:
                    Console.WriteLine($"{input} -> Não é uma consoante ! ");
                    break;
            }

        }

        private static string Getcharacter()
        {
            string? input = "";

            while (input!.Equals(""))
            {
                Console.WriteLine("Digite uma letra:");
                input = Console.ReadLine();

            }
            return input!;
        }
    }


}