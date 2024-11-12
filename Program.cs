namespace Week2_ChallengeLab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int temp;

            Console.WriteLine("Enter the temperature: ");
            temp = Convert.ToInt32(Console.ReadLine());

            if (temp >= 0 && temp < 11) 
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp >= 11 &&  temp <= 20)
            {
                Console.WriteLine("Very cold weather");
            }
            else if (temp >= 21 && temp <= 35)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp >= 36 && temp <= 50)
            {
                Console.WriteLine("Normal Weather");
            }
            else if (temp >= 51 && temp <= 65)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temp >= 66 && temp <= 80)
            {
                Console.WriteLine("Its Very Hot");
            }
            else if (temp < 0 )
            {
                Console.WriteLine("Weather is below freezing");
            }
           

        }
    }
}
