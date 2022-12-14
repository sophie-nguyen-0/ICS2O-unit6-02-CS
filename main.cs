using System;
using System.Threading.Tasks;
using System.IO;

class Program
{
  	public static async Task Main()
	{
      	String answer;
	      int counter = 0;

		    Console.Write("do you want to quit? (yes or no): ");
        answer = Convert.ToString(Console.ReadLine());

		    while (answer == "no")
		    {
			      if (answer == "no")
			      {
				        counter ++;
				        Console.WriteLine("the counter is at " + counter);

				        await File.WriteAllTextAsync("WriteText.txt", counter.ToString());
	    		      Console.WriteLine("File Created ...");

	        	    var someText = await File.ReadAllTextAsync(@"WriteText.txt");

				        Console.Write("do you want to quit? (yes or no): ");
	        	    answer = Convert.ToString(Console.ReadLine());
			      }
		    }
		    counter = 0;
		    Console.WriteLine("\nDone.");


    }
}