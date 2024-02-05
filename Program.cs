using System;

public class HelloWorld // detta är klassen Helloworld
{

static  void Main(string[] args) 
{
  Hello32();

}
 public static void Hello32() // här skapas en public metod som jag kallar hello32
{
    for (int i = 0; i < 32; i++) // for loop för att skriva ut HelloWorld 32 gånger 
    {
      Console.WriteLine("Hello, World");  
    }


}


}