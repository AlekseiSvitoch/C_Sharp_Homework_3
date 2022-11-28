Console.Clear();
Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10000 || num > 99999)
    Console.Write("Это не пятизначное число ");

else
{
    string str = num.ToString();
   
    if (str[0] == str[4] && str[1] == str[3])
        Console.Write("это число является палиндромом");
    
    else
        Console.Write("это число не является палиндромом");
}