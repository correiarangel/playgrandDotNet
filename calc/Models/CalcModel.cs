namespace CalcModel.Models
{
    public class CalcModel
    {

        public void Sum()
        {
            String? numberOne = "";
            String? numberTwo = "";
            while (numberOne!.Equals(""))
            {
                Console.WriteLine("Digite 1 numeros para Soma :");
                numberOne = Console.ReadLine();
            }
            while (numberTwo!.Equals(""))
            {
                Console.WriteLine("Digite 2 numeros para Soma :");
                numberTwo = Console.ReadLine();
            }

            double total = Convert.ToDouble(numberOne) + Convert.ToDouble(numberTwo);
            Console.WriteLine($"Total :{total}");

        }
        public void Sub()
        {
            String? numberOne = "";
            String? numberTwo = "";
            while (numberOne!.Equals(""))
            {
                Console.WriteLine("Digite 1 numeros para Subtração :");
                numberOne = Console.ReadLine();
            }
            while (numberTwo!.Equals(""))
            {
                Console.WriteLine("Digite 2 numeros para Subtração :");
                numberTwo = Console.ReadLine();
            }
            double total = Convert.ToDouble(numberOne) - Convert.ToDouble(numberTwo);
            Console.WriteLine($"Total :{total}");

        }
        public void Mult()
        {
            String? numberOne = "";
            String? numberTwo = "";
            while (numberOne!.Equals(""))
            {
                Console.WriteLine("Digite 1 numeros para Multiplicação :");
                numberOne = Console.ReadLine();
            }
            while (numberTwo!.Equals(""))
            {
                Console.WriteLine("Digite 2 numeros para Multiplicação :");
                numberTwo = Console.ReadLine();
            }

            double total = Convert.ToDouble(numberOne) * Convert.ToDouble(numberTwo);
            Console.WriteLine($"Total :{total}");

        }
        public void Divisor()
        {
            String? numberOne = "";
            String? numberTwo = "";
            while (numberOne!.Equals(""))
            {
                Console.WriteLine("Digite 1 numeros para Divisão :");
                numberOne = Console.ReadLine();
            }
            while (numberTwo!.Equals(""))
            {
                Console.WriteLine("Digite 2 numeros para Divisão :");
                numberTwo = Console.ReadLine();
            }



            double total = Convert.ToDouble(numberOne) / Convert.ToDouble(numberTwo);
            Console.WriteLine($"Total :{total}");

        }
        public void Potencia()
        {


            String? numberOne = "";
            String? numberTwo = "";
            while (numberOne!.Equals(""))
            {
                Console.WriteLine("Digite 1 numeros p/ potencia :");
                numberOne = Console.ReadLine();
            }
            while (numberTwo!.Equals(""))
            {
                Console.WriteLine("Digite 2 numeros p/ potencia:");
                numberTwo = Console.ReadLine();
            }


            double pot = Math.Pow(Convert.ToDouble(numberOne), Convert.ToDouble(numberTwo));

            Console.WriteLine($"Potencia de: {numberOne}^{numberTwo} = {pot}");

        }
        public void Seno()
        {
            String? anguloStr = "";

            while (anguloStr!.Equals(""))
            {
                Console.WriteLine("Digite o angulo :");
                anguloStr = Console.ReadLine();
            }
            double angulo = Convert.ToDouble(anguloStr);
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);

            Console.WriteLine($"Seno de  :{angulo}º = {seno}");

        }
        public void Coseno()
        {
            String? anguloStr = "";

            while (anguloStr!.Equals(""))
            {
                Console.WriteLine("Digite o angulo :");
                anguloStr = Console.ReadLine();
            }
            double angulo = Convert.ToDouble(anguloStr);
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);

            Console.WriteLine($"Coseno de  :{angulo}º = {coseno}");

        }

        public void Tangente()
        {
            String? anguloStr = "";

            while (anguloStr!.Equals(""))
            {
                Console.WriteLine("Digite o angulo :");
                anguloStr = Console.ReadLine();
            }
            double angulo = Convert.ToDouble(anguloStr);
            double radiano = angulo * Math.PI / 180;
            double tangent = Math.Tan(radiano);

            Console.WriteLine($"Tangente de  :{angulo}º = {tangent}");

        }
    }
}