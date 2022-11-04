namespace Act1
{
    class Program
    {
        static void Main()
        {
            string? base_input;
            string? height_input;
            float f_base;
            float f_height;

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
                height_input = Console.ReadLine();
                if (height_input != null)
                {
                    try
                    {
                        f_height = float.Parse(height_input);
                        break;
                    }
                    catch (System.FormatException)
                    {
                        Console.WriteLine("El que has introduit no es valid");
                    }
                }
            }

            float f_area = (f_base * f_height) / 2;
            Console.WriteLine($"L'area és {f_area} cm^2");
        }
    }
}