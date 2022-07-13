using LineComparision;

Console.WriteLine("Welcome to Line Comparision: ");
LineOne line = new LineOne();
double result1 = line.Length();
Console.WriteLine("Length Of Line1: {0}",result1);
double result2 = line.Length();
Console.WriteLine("Length Of Line2: {0}", result2);

if (result1 > result2)
    Console.WriteLine("Line1 is Greater than Line2");
else if (result1 < result2)
    Console.WriteLine("Line2 is Greater than Line1");
else
    Console.WriteLine("Line1 and Line2 Are Equal");




