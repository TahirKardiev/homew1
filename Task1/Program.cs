 double a; string clir;
Console.WriteLine ("Enter a number "); clir = Console.ReadLine ();
a = double.Parse (clir);
Console.WriteLine(((a - (a % 10))/10)%10);




