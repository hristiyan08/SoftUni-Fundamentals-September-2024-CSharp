int number = int.Parse(Console.ReadLine());
int sum = 0;
int interations = 0;
for (int i = 1; i<= 100; i++) 
{ 
    
    if (i%2 == 1)
    {
        Console.WriteLine(i);
        sum += i;
        interations++;
        if(interations == number)
        {
            Console.WriteLine($"Sum: {sum}");
            return;
        }
    }
}
