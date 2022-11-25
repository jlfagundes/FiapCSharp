// Obtem a tecla pressionada e exibe no console
using System;

public class Example
{
    public static void Main()
    {
        /*
        DateTime dat = DateTime.Now;
        Console.WriteLine("The time: {0:d} at {0:t}", dat);
        TimeZoneInfo tz = TimeZoneInfo.Local;
        Console.WriteLine("The time zone: {0}\n",
                          tz.IsDaylightSavingTime(dat) ?
                             tz.DaylightName : tz.StandardName);
        Console.Write("Press <Enter> to exit... ");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        */
        do
        {
            Console.WriteLine("A tecla pressionada não foi \"ESC");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}
// The example displays output like the following:
//     The time: 11/11/2015 at 4:02 PM:
//     The time zone: Pacific Standard Time


