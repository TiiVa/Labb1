// See https://aka.ms/new-console-template for more information


Console.WriteLine("Input string: ");
string input = Console.ReadLine();
string partString;
long sum = 0;


for (int i = 0; i < input.Length; i++)
{
    if (Char.IsDigit(input[i]))
    {
        for (int j = i + 1; j < input.Length; j++)
        {
            if (!Char.IsDigit(input[j]))
            {
                break;
            }
            if (input[i] == input[j])
            {
                Console.Write(input.Substring(0, i));
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(input.Substring(i, j - i + 1));
                partString = input.Substring(i, j - i + 1);
                sum += long.Parse(partString);
                Console.ResetColor();
                Console.Write(input.Substring(j + 1));
                Console.WriteLine();
                break;
            }

        }
    }

}
Console.WriteLine();
Console.WriteLine("Total = " + sum);

