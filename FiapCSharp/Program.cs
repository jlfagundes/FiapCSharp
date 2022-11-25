// Obtem a tecla pressionada e exibe no console
using System;

public class Example
{
    public static void Main()
    {
        // **************************/ Exibindo a tecla no console /***************************************

        /*
        // Imprimindo no console a tecla pressionada
        ConsoleKeyInfo cki;
        // Prevent example from ending if CTL+C is pressed.
        Console.TreatControlCAsInput = true;

        Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
        Console.WriteLine("Press the Escape (Esc) key to quit: \n");
        do
        {
            cki = Console.ReadKey();
            Console.Write(" --- You pressed ");
            if ((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
            if ((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
            if ((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
            Console.WriteLine(cki.Key.ToString());
        } while (cki.Key != ConsoleKey.Escape);
        */

        ConsoleKeyInfo cki;
        do
        {
            Console.Write("\nPRESSIONE UMA TECLA - PARA SAIR PRESSIONE ESC: ");
            cki = Console.ReadKey();
            Console.Write("\nVoce pressionou a tecla: ");
            Console.WriteLine(cki.Key.ToString());
        } while (cki.Key != ConsoleKey.Escape);

        // This example displays output similar to the following:
        //       Press any combination of CTL, ALT, and SHIFT, and a console key.
        //       Press the Escape (Esc) key to quit:
        //
        //       a --- You pressed A
        //       k --- You pressed ALT+K
        //       ► --- You pressed CTL+P
        //         --- You pressed RightArrow
        //       R --- You pressed SHIFT+R
        //                --- You pressed CTL+I
        //       j --- You pressed ALT+J
        //       O --- You pressed SHIFT+O
        //       § --- You pressed CTL+U

        // **************************/ Usando o Console.ReadKey() /***************************************

        /* // Exemplo do site https://learn.microsoft.com/en-us/dotnet/api/system.console.readkey?view=net-6.0
        DateTime dat = DateTime.Now;
        Console.WriteLine("The time: {0:d} at {0:t}", dat);
        TimeZoneInfo tz = TimeZoneInfo.Local;
        Console.WriteLine("The time zone: {0}\n",
                          tz.IsDaylightSavingTime(dat) ?
                             tz.DaylightName : tz.StandardName);
        Console.Write("Press <Enter> to exit... ");
        while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        */

        /* // Testando pressionar esc para sair do loop
        do
        {
            Console.WriteLine("A tecla pressionada não foi \"ESC");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        */
    }
}
// The example displays output like the following:
//     The time: 11/11/2015 at 4:02 PM:
//     The time zone: Pacific Standard Time


