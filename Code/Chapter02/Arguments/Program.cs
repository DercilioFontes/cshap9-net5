using System;
using static System.Console;
using System.IO;
using System.Text;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteLine($"There are {args.Length} arguments.");

            // foreach (string arg in args)
            // {
            //     WriteLine(arg);
            // }

            // if (args.Length < 3)
            // {
            //     WriteLine("You must specify two colors and cursor size, e.g.");
            //     WriteLine("dotnet run red yellow 50");
            //     return;
            // }

            // ForegroundColor = (ConsoleColor)Enum.Parse(
            //     enumType: typeof(ConsoleColor),
            //     value: args[0],
            //     ignoreCase: true
            // );

            // BackgroundColor = (ConsoleColor)Enum.Parse(
            //     enumType: typeof(ConsoleColor),
            //     value: args[1],
            //     ignoreCase: true
            // );

            // try
            // {
            //     CursorSize = int.Parse(args[2]);
            // }
            // catch (PlatformNotSupportedException)
            // {
            //     WriteLine("The current platform does not support changing the size of the cursor.");
            // }

            // Create a Char array for the modern Cyrillic alphabet,
            // from U+0410 to U+044F.
            // int nChars = 0x044F - 0x0410 + 1;
            // char[] chars = new char[nChars];
            // ushort codePoint = 0x0410;
            // for (int ctr = 0; ctr < chars.Length; ctr++)
            // {
            //     chars[ctr] = Convert.ToChar(codePoint);
            //     codePoint++;
            // }

            // Console.WriteLine("Current code page: {0}\n",
            //                   Console.OutputEncoding.CodePage);
            // // Display the characters.
            // foreach (var ch in chars)
            // {
            //     Console.Write("{0}  ", ch);
            //     if (Console.CursorLeft >= 70)
            //         Console.WriteLine();
            // }

            Random rnd = new Random();

            // string str = String.Empty;
            StringBuilder sb = new StringBuilder();
            // StreamWriter sw = new StreamWriter(@"StringFile.txt",
            //                      false, Encoding.Unicode);

            StreamWriter sw = new StreamWriter(@"StringBuilderFile.txt",
                     false, Encoding.Unicode);

            var start = DateTime.Now;
            // str += "Start: " + start + "\n";
            sb.AppendLine("Start: " + start + "\n");

            for (int ctr = 0; ctr <= 1000; ctr++)
            {
                // str += Convert.ToChar(rnd.Next(1, 0x0530));
                // if (str.Length % 60 == 0)
                //     str += Environment.NewLine;

                sb.Append(Convert.ToChar(rnd.Next(1, 0x0530)));
                if (sb.Length % 60 == 0)
                    sb.AppendLine();
            }

            var end = DateTime.Now;
            // str += "\n" + "End: " + end;
            sb.AppendLine("\n" + "End: " + end);

            // str += "\n" + "Difference: " + (end - start);
            sb.AppendLine("Difference: " + (end - start));


            // sw.Write(str);
            sw.Write(sb.ToString());
            sw.Close();

            // String: Difference: 00:00:00.0107120
            // StringBuilder: Difference: 00:00:00.0113010
        }
    }
}
