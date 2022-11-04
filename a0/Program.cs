namespace Act1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introdueix la base (cm) : ");
            string? base_input = Console.ReadLine();
            if (base_input == null)
            {
                return;
            }
            try
            {
                float.Parse(base_input);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("No has introduit un nombre valid");
                return;
            }


            float f_base = float.Parse(base_input);

            Console.WriteLine("Introdueix l'altura (cm) : ");
            string? altura_input = Console.ReadLine();
            if (altura_input == null)
            {
                return;
            }
            try
            {
                float.Parse(altura_input);
            }
            catch (System.FormatException)
            {
                return;
            }

            float f_altura = float.Parse(altura_input);

            float f_area = (f_base * f_altura) / 2;
            Console.WriteLine($"L'area és {f_area} cm^2");
        }
    }
}