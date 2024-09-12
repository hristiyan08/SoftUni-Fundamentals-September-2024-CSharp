using System.ComponentModel.Design;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int largestNum = 0;
int midNum = 0;
int smallestNum = 0;
if (num1 >= num2 && num1 >= num3)
{
    largestNum += num1;
    if (num2 >= num3)
    {
        midNum += num2;
        smallestNum += num3;
    }
    else
    {
        smallestNum += num2;
        midNum += num3;
    }
}
else if (num2 >= num1 && num2 >= num3)
{
    largestNum += num2;
    if (num1 >= num3)
    {
        midNum += num1;
        smallestNum += num3;
    }
    else
    {
        smallestNum += num3;
        midNum += num1;
    }

}
else
{
    largestNum += num3;
    if (num1 >= num2)  
    {
        midNum += num1  ;
        smallestNum += num2;
    }
    else
    {
        smallestNum += num1;
        midNum += num2;
    }
}
Console.WriteLine(largestNum);
Console.WriteLine(midNum);
Console.WriteLine(smallestNum);