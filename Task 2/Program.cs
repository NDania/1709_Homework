// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if(n < m)
{
      Console.WriteLine("max: " + m);
      Console.WriteLine("min: " + n);
}
else 
{
      Console.WriteLine("max: " + n);   
      Console.WriteLine("min: " + m);      
}