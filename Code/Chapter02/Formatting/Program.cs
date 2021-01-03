using System;
using System.Globalization;
using System.Threading;
using static System.Console;

namespace Formatting
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numberOfApples = 12;
            // decimal pricePerApple = 0.35M;

            // WriteLine(format: "{0} apples costs {1:C}",
            //                   arg0: numberOfApples,
            //                   arg1: pricePerApple * numberOfApples);

            // WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

            // string formatted = string.Format(
            //     format: "{0} apples costs {1:C}",
            //     arg0: numberOfApples,
            //     arg1: pricePerApple * numberOfApples);


            // string applesText = "Apples";
            // int applesCount = 1234;
            // string bananasText = "Bananas";
            // int bananasCount = 56789;
            // string formatText = "{0,-8}{1,6:N0}";

            // WriteLine(
            //     format: formatText,
            //     arg0: "Name",
            //     arg1: "Count"
            // );

            // WriteLine(
            //     format: formatText,
            //     arg0: applesText,
            //     arg1: applesCount
            // );

            // WriteLine(
            //     format: formatText,
            //     arg0: bananasText,
            //     arg1: bananasCount
            // );


            // string[] cultureNames = { "en-US", "fr-FR", "es-MX", "de-DE", "pt-BR" };
            // Decimal value = 1043.17689m;

            // foreach (var cultureName in cultureNames)
            // {
            //     // Change the current thread culture.
            //     Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(cultureName);
            //     WriteLine("The current culture is {0}",
            //                       Thread.CurrentThread.CurrentCulture.Name);
            //     WriteLine(value.ToString("C3"));
            //     WriteLine();
            // }


            // Write("Type your first name and press ENTER: ");
            // string firstName = ReadLine();

            // Write("Type your age and press ENTER: ");
            // string age = ReadLine();

            // WriteLine($"Hello {firstName}, you look good for {age}.");


            Write("Press any key combination: ");
            ConsoleKeyInfo key = ReadKey();

            WriteLine();
            WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
            arg0: key.Key,
            arg1: key.KeyChar,
            arg2: key.Modifiers);

        }
    }
}
