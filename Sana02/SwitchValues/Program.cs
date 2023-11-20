using System.Text;

// Ukrainian lang
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

while (true)
{
    int number;

    Console.Write("Введіть число від 0 до 9 [0 - 9] (Вихід з програми |-1|): ");
    bool valid = int.TryParse(Console.ReadLine(), out number);

    if (number == -1)
    {
        break;
    }

    if (valid && (0 <= number && number <= 9))
    {
        switch(number)
        {
            case 0:
                Console.WriteLine("Ви ввели нуль -> 0");
                break;
            case 1:
                Console.WriteLine("Ви ввели один -> 1");
                break;
            case 2:
                Console.WriteLine("Ви ввели два -> 2");
                break;
            case 3:
                Console.WriteLine("Ви ввели три -> 3");
                break;
            case 4:
                Console.WriteLine("Ви ввели чотири -> 4");
                break;
            case 5:
                Console.WriteLine("Ви ввели п`ять -> 5");
                break;
            case 6:
                Console.WriteLine("Ви ввели шість -> 6");
                break;
            case 7:
                Console.WriteLine("Ви ввели сім -> 7");
                break;
            case 8:
                Console.WriteLine("Ви ввели вісім -> 8");
                break;
            case 9:
                Console.WriteLine("Ви ввели дев`ять -> 9");
                break;
        }
    }
}
