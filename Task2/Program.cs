double a;
Console.WriteLine (a = new Random().Next(100,999));
Console.WriteLine (a-(((a - (a % 10))/10)%10)*10);