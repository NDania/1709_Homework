// Напишите программу, которая на вход принимает число и выдает является ли число четным (делится ли оно на два без остатка) 
Console.Clear();
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 2 == 0)
    Console.WriteLine("Число является четным");
else       
    Console.WriteLine("Число является нечетным");
