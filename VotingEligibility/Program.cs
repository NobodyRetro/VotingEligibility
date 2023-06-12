Console.WriteLine("What is your age?");
int Age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Are you a citizen?");
string Citizen = Convert.ToString(Console.ReadLine().ToUpper());

if (Age >= 18)
{
    if (Citizen == "YES")
    {
        Console.WriteLine("You are eligible to vote.");
    }
    else
    {
        Console.WriteLine("Only citizens are eligible to vote.");       
    }
}
else
{
    Console.WriteLine("You are not old enough to vote");    
}
Console.WriteLine("Press any key to exit");
Console.ReadKey();
