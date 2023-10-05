// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter first numbers:");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter second numbers:");
int num2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Palindrome numbers between {num1} and {num2} are:");

for (int i = num1; i <= num2; i++)
{
    if (IsPalindrome(i))
    {
        Console.WriteLine(i);
    }
}

 static bool IsPalindrome(int number)
{
    int  revnumber = 0,temp,  reminder;
    temp = number;
    while (number != 0)
    {
        reminder = number % 10;
        revnumber = revnumber * 10 + reminder;
        number = number / 10;
    }
    // number asli nemishe gozasht chon ke bad is while loop value number 0 mishe pas bayad to temp zakhire konim!!
    return temp == revnumber;
}
Console.Read();  

