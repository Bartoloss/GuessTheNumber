Console.WriteLine("Guess the number drawn by the computer in the range of 1 to 10!");
Random random = new Random();
int a = random.Next(1, 10);

int b;
int howMany = 0;

Console.Write("Please write the number: ");
do
{

    b = int.Parse(Console.ReadLine());

    if (b <= 10 && b >= 1)
    {

        howMany++;
        if (b == a)
        {
            Console.WriteLine("Congratulations! You guessed the number in {0} total!", howMany);
        }
        else if (b > a)
        {
            Console.WriteLine("Unfortunately! The number you entered is greater than the nummber randomly selected");
            Console.Write("Please write the number again: ");
        }
        else
        {
            Console.WriteLine("Unfortunately! The number you entered is lower than the nummber randomly selected");
            Console.Write("Please write the number again: ");
        }
    }
    else
    {
        Console.WriteLine("The number you entered is out of range! Please enter the number again: ");
    }

} while (a != b);