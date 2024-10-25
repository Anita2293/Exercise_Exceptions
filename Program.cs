namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tours = { "England", "Spain", "Italy", "Portugal", "France" };
            int choice = Convert.ToInt32(Console.ReadLine());
            int N = choice;

            //your code goes here
            try
            {
                Console.WriteLine(tours[N]);


            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong number");
            }
            finally
            {
                Console.WriteLine("Goodbye");
            }
        }
    }
}