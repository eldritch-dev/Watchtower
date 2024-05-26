Console.WriteLine("What are the coordinates of the enemy?");
Console.WriteLine("Give me the x axis value first:");
var x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Perfect. Now give me the y axis value:");
var y = Convert.ToInt32(Console.ReadLine());

if (x < 0)
{
    if (y < 0) Console.WriteLine("The enemy is to the southwest");
    if (y == 0) Console.WriteLine("The enemy is to the west");
    if (y > 0) Console.WriteLine("The enemy is to the northwest");
}
else if (x == 0)
{
    if (y < 0) Console.WriteLine("The enemy is to the south");
    if (y == 0) Console.WriteLine("The enemy is right here");
    if (y > 0) Console.WriteLine("The enemy is to the north");
}
else if (x > 0)
{
    if (y < 0) Console.WriteLine("The enemy is to the southeast");
    if (y == 0) Console.WriteLine("The enemy is to the east");
    if (y > 0) Console.WriteLine("The enemy is to the northeast");
}

