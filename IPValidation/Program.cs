
using IPValidation.Utilities;

namespace IPValidation
{
    public class Program
    {
        

        static void Main(string[] args)
        {
            Console.Title = "IP Validation";
            Console.WriteLine("IP Validation");
            Console.WriteLine("\nPlease input IP:");
            var ip = Console.ReadLine();
            var isValid = Validator.IsValidIP(ip);
            Console.WriteLine("IP: {0} is {1}", ip, isValid?"valid":"invalid");
            Console.ReadLine();
        }

        

        
    }
}