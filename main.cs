using System;
using System.Threading.Tasks;
using System.IO;

class Program {
  public static async Task Main()
    {
      	String answer;
	    int counter = 0;

        await File.WriteAllTextAsync("WriteText.txt", counter.ToString());
        Console.WriteLine("File Created ...");

        var someText = await File.ReadAllTextAsync(@"WriteText.txt");

		Console.Write("do you want to quit? (yes or no): ");
        answer = Convert.ToString(Console.ReadLine());

        if (answer == "no")
		{
			if(someText == )
			counter ++;
			Console.WriteLine("the counter is at " + counter);
		}
	  	else
	  	{
		  Console.WriteLine("\nDone.");
		}


    }
}