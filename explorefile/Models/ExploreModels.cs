
namespace explorefile.Models
{
    public class ExploreModels
    {
        public void LineRead(string path)
        {
            try
            {
                Console.WriteLine("//->");
                string[] lines = File.ReadAllLines(path);
                Console.WriteLine("//-> foreach");
                foreach (var line in lines)
                {
                    Console.WriteLine($"/-> {line}");
                }
            }
            catch (DirectoryNotFoundException err)
            {
                Console.WriteLine($"ERROR : Diretório não encontrado ! \n {err.Message} ");
            }
            catch (FileNotFoundException err)
            {
                Console.WriteLine($"ERROR : Arquivo não encontrado ! \n {err.Message} ");
            }
            catch (Exception err)
            {
                Console.WriteLine($"ERROR : Desconhecido ! \n {err.Message} ");
            }
        }

        public void MethodOne()
        {
            Console.WriteLine("MethodOne ...");
            try
            {
                MethodTwo();
            }
            catch (Exception err)
            {
                Console.WriteLine($"Error //-> {err.Message}");
            }

        }

        public void MethodTwo()
        {
            Console.WriteLine("MethodTwo ...");
            MethodTree();
        }

        public void MethodTree()
        {

            Random random = new Random();
            int result = random.Next(100);
            if (result % 2 == 0)
            {
                Console.WriteLine($"MethodTwo ...{result}");
                return;
            }

            throw new Exception("Ops ! Exception Test |//->  Run ");

        }

    }
}