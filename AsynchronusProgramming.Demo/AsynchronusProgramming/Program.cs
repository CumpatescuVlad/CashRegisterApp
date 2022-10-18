using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    static async Task Main(string[] args)
    {
        //Task<TResult> generic classs is used wen the async method has a return type 
        Task<int> number =CreateANumber();
        //Create method has a call triugh Task

        Message();

        var result = await number;
        //After delay passes this result varaible waits the result
        Console.WriteLine("This never gets executed before the CreateNumber finished ");
        //This message is executed 
        Console.WriteLine(result);
        //Result is the final thing executed because has an await modifier
    }

    public async static Task<int> CreateANumber()
    {
        Random random = new Random();

        Console.WriteLine("Creating the number...");
        //Task has a delay , computer return to main an looks form what 
        //is allowed to execute now 
        await Task.Delay(4000);

        Console.WriteLine("Number is ....");

        return random.Next(1, 20);
    }
    public static void Message()
    {
        //This method is execute now 
        //in the meantime time passes at CreateANumber  method 
        Console.WriteLine("Runs while the task , elapses time");

        Console.WriteLine("DONE");
    }
   
}

