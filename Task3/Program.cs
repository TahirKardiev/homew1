double a; string clir;
Console.WriteLine ("Enter a number "); clir = Console.ReadLine ();
a = double.Parse (clir);
if (a < 1000)
{
Console.WriteLine(a % 10);
}
