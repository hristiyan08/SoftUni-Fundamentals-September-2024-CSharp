string typeOfDay = Console.ReadLine();
int age = int.Parse(Console.ReadLine());

int price = 0;
bool validInput = true;

switch (typeOfDay)
{
    case "Weekday":
        if (age >= 0 && age <= 18)
        {
            price = 12;
        }
        else if (age > 18 && age <= 64)
        {
            price = 18;
        }
        else if (age > 64 && age <= 122)
        {
            price = 12;
        }
        else
        {
            validInput = false;
        }
        break;

    case "Weekend":
        if (age >= 0 && age <= 18)
        {
            price = 15;
        }
        else if (age > 18 && age <= 64)
        {
            price = 20;
        }
        else if (age > 64 && age <= 122)
        {
            price = 15;
        }
        else
        {
            validInput = false;
        }
        break;

    case "Holiday":
        if (age >= 0 && age <= 18)
        {
            price = 5;
        }
        else if (age > 18 && age <= 64)
        {
            price = 12;
        }
        else if (age > 64 && age <= 122)
        {
            price = 10;
        }
        else
        {
            validInput = false;
        }
        break;

    default:
        validInput = false;
        break;
}

if (validInput)
{
    Console.WriteLine($"{price}$");
}
else
{
    Console.WriteLine("Error!");
}
