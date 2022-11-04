namespace Act1
{
    class Program
    {
        static void Main()
        {
            string? base_input;
            string? altura_input;
            float f_base;
            float f_altura;

            while (true)
            {
                Console.WriteLine("Introdueix la base (cm) : ");
                base_input = Console.ReadLine();
                if (base_input != null)
                {
                    try
                    {
                        f_base = float.Parse(base_input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no es valid");
                    }
                }
            }

            while (true)
            {
                Console.WriteLine("Introdueix l'altura (cm) : ");
                altura_input = Console.ReadLine();
                if (altura_input != null)
                {
                    try
                    {
                        f_altura = float.Parse(altura_input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no es valid");
                    }
                }
            }

            float f_area = (f_base * f_altura) / 2;
            Console.WriteLine($"L'area és {f_area} cm^2");
        }
    }
}