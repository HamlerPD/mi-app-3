// Realizar un programa que lea cuatro valores numéricos e
// informar su suma y promedioRealizar un programa que lea cuatro valores numéricos
// e informar su suma y promedio

using ConsoleApp3.ejercicio_3;

Suma c;
Console.WriteLine(" ingrese el pirmer valor numerico ");
double num1 = double.Parse(Console.ReadLine());
Console.WriteLine(" ingrese el segundo valor numerico ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine(" ingrese el tercer valor numerico ");
double num3 = double.Parse(Console.ReadLine());
Console.WriteLine(" ingrese el cuarto valor numerico ");
double num4 = double.Parse(Console.ReadLine());

c = new Suma(num1, num2, num3, num4);

Console.WriteLine(" la suma de los valores numericos es " +c.Getsuma());
Console.WriteLine(" El promedio de los valores numericos es " +c.Promedio());
