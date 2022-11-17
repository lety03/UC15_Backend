namespace UC15_Backend.Classes
{
    public static class Utils
    {
        public static void BarraCarregamento(string texto){

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.DarkGray;

            Console.WriteLine($"{texto}");

            for (int i = 0; i < 8; i++)
            {
            Console.Write("||");    
            Thread.Sleep(200);
            }

            Console.ResetColor();
            Console.Clear();
        }
    }
}