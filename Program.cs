Console.WriteLine("welcome to the calculator!");

// Declare variables
float num1, num2, result;
int choice = 0;
num1 = num2 = result = 0;  


// Get user input for the two numbers
num1 = checkdata("write the first number: ");
num2 = checkdata("write the secon number:");


// Check if the input numbers are valid
while(choice < 1 || choice > 5)
{
    Console.WriteLine("\nSelect an operation:\n");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Modulus");
    Console.WriteLine("exit the program by pressing q at any time");
    choice = checkdataint("Write Operation \n 1-+ \n 2 - -\n 3-* \n 4-/ \n5-%: \n");
}



// Perform the selected operation
switch (choice)
{
    case 1:

        result = num1 + num2;
        Console.WriteLine("Result: " + result);
        break;
    case 2:

        result = num1 - num2;
        Console.WriteLine("Result: " + result);
        break;
    case 3:

        result = num1 * num2;
        Console.WriteLine("Result: " + result);
        break;
    case 4:
        if (num2 == 0)
            Console.WriteLine("Error: Division by zero!");
        else
            Console.WriteLine("Result: " + (num1 / num2));
        break;
    case 5:
        if (num2 == 0)
            Console.WriteLine("Error: Modulus by zero!");
        else
            Console.WriteLine("Result: " + (num1 % num2));
        break;
    default:
        Console.WriteLine("Invalid choice and the program will exit");
        break;
}


// Function to check if the input is a valid number

static float checkdata( string message = " ")
{
    while (true)
    {
        Console.Write(message);
        string input = Console.ReadLine() ?? string.Empty;

        if (input.StartsWith(">")) ComandsOfControll(input);

        if (float.TryParse(input.Replace('.', ','), out float number))
        {

            return number;
        
        }
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}

static int checkdataint(string message = " ")
{
    while (true)
    {
        System.Console.WriteLine(message);
        string input = Console.ReadLine() ?? string.Empty;

        if (input.StartsWith(">")) ComandsOfControll(input);

        if (int.TryParse(input, out int number))
        {
            return number;
        }
        Console.WriteLine("Invalid input. Please enter a valid number.");
    
    }
}
// Function to exit the application
static void ComandsOfControll (string message = "")
{
    if (message.Contains('>'))
    {
        int ComandFlagIndex = message.IndexOf('>');
        if (ComandFlagIndex + 1 < message.Length)
        {
        switch (message[ComandFlagIndex+1])
        {
            case 'q':
                Console.WriteLine("Exiting the program...");
                Environment.Exit(0);
                break;
            case 'h':
                Console.WriteLine("Help: This is a simple calculator program.\n You can perform basic arithmetic operations such as\n addition, subtraction, multiplication, division, and modulus. \nTo exit the program, enter comand flag: - and press 'q' at any time.");
                break;
            default:
                break;
        }
        }
    }
}