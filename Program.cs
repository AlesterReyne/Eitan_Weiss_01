namespace Eitan_Weiss_01
{
    class Program
    {
        // Class variables to store name and age
        static string _name = "";
        static sbyte _age;

        // Entry point of the program
        static void Main()
        {
            // Working through functions like a real junior guy ;)
            _name = InputName();
            _age = InputAge();
            ShowInfo();
        }

        static string InputName()
        {
            while (true)
            {
                Console.Write("Enter your name: ");
                string? inputName = Console.ReadLine(); // Use nullable string to handle possible null

                // Accept only non-empty names that do not contain digits
                if (!string.IsNullOrWhiteSpace(inputName) && !inputName.Any(char.IsDigit))
                    return inputName;

                Console.WriteLine("Name cannot be empty or contain numbers. Please try again.");
            }
        }

        static sbyte InputAge()
        {
            while (true)
            {
                Console.Write("Enter your age: ");
                string? inputAge = Console.ReadLine();

                // Accept ages between 0 and 120 and avoid letters
                if (sbyte.TryParse(inputAge, out sbyte parsedAge) && parsedAge >= 0 && parsedAge <= 120)
                    return parsedAge;

                Console.WriteLine("Invalid age. Please enter a number between 0 and 120.");
            }
        }

        static void ShowInfo()
        {
            Console.WriteLine($"Hello, {_name}! You are {_age} years old.");
        }
    }
}