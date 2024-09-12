int number = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
if (secondNumber > 10)
{
    Console.WriteLine($"{number} X {secondNumber} = {number * secondNumber}");
   
}
else
{


for (int i = secondNumber; i <= 10; i++)
{
    Console.WriteLine($"{number} X {i} = {number * i}");
}}