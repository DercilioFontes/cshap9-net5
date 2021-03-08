using System;
using System.Globalization;
using static System.Console;
using static System.Convert;

namespace CastingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 10;
            // double b = a;
            // WriteLine(b);

            // double c = 9.8;
            // int d = (int)c;
            // WriteLine(d);

            // long e = 10;
            // long e = 5_000_000_000;
            // int f = (int)e;
            // WriteLine($"e is {e:N0} and f is {f:N0}");
            // e = long.MaxValue;
            // f = (int)e;
            // WriteLine($"e is {e:N0} and f is {f:N0}");

            // double g = 9.8;
            // int h = ToInt32(g);
            // WriteLine($"g is {g} and h is {h}");


            // double[] doubles = new[]
            //   { 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 , 11.49, 11.5, 11.51};
            // foreach (double n in doubles)
            // {
            //     WriteLine($"ToInt({n}) is {ToInt32(n)}");
            // }

            // foreach (double n in doubles)
            // {
            //     WriteLine(format:
            //       "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
            //       arg0: n,
            //       arg1: Math.Round(value: n, digits: 0,
            //               mode: MidpointRounding.AwayFromZero));
            // }


            // int number = 12;
            // WriteLine(number.ToString());
            // bool boolean = true;
            // WriteLine(boolean.ToString());
            // DateTime now = DateTime.Now;
            // WriteLine(now.ToString());
            // object me = new object();
            // WriteLine(me.ToString());

            // // allocate array of 128 bytes
            // byte[] binaryObject = new byte[128];
            // // populate array with random bytes
            // (new Random()).NextBytes(binaryObject);
            // WriteLine("Binary Object as bytes:");
            // for (int index = 0; index < binaryObject.Length; index++)
            // {
            //     Write($"{binaryObject[index]:X} ");
            // }
            // WriteLine();
            // // convert to Base64 string and output as text
            // string encoded = Convert.ToBase64String(binaryObject);
            // WriteLine($"Binary Object as Base64: {encoded}");

            // int age = int.Parse("27");
            // DateTime birthday = DateTime.Parse("4 July 1980");
            // WriteLine($"I was born {age} years ago.");
            // WriteLine($"My birthday is {birthday}.");
            // WriteLine($"My birthday is {birthday:d} (d).");
            // WriteLine($"My birthday is {birthday:D} (D).");
            // WriteLine($"My birthday is {birthday:f} (f).");
            // WriteLine($"My birthday is {birthday:F} (F).");
            // WriteLine($"My birthday is {birthday:g} (g).");
            // WriteLine($"My birthday is {birthday:G} (G).");
            // WriteLine($"My birthday is {birthday:m} (m).");
            // WriteLine($"My birthday is {birthday:M} (M).");
            // WriteLine($"My birthday is {birthday:o} (o).");
            // WriteLine($"My birthday is {birthday:O} (O).");
            // WriteLine($"My birthday is {birthday:r} (r).");
            // WriteLine($"My birthday is {birthday:R} (R).");
            // WriteLine($"My birthday is {birthday:s} (s).");
            // WriteLine($"My birthday is {birthday:t} (t).");
            // WriteLine($"My birthday is {birthday:T} (T).");
            // WriteLine($"My birthday is {birthday:u} (u).");
            // WriteLine($"My birthday is {birthday:U} (U).");
            // WriteLine($"My birthday is {birthday:y} (y).");
            // WriteLine($"My birthday is {birthday:Y} (Y).");


            // Console.WriteLine("'d' standard format string:");
            // foreach (var customString in DateTimeFormatInfo.CurrentInfo.GetAllDateTimePatterns('d'))
            //     Console.WriteLine("   {0}", customString);

            // DateTime dat = new DateTime(2009, 6, 15, 13, 45, 30,
            //                             DateTimeKind.Unspecified);
            // Console.WriteLine("{0} ({1}) --> {0:O}", dat, dat.Kind);

            // DateTime uDat = new DateTime(2009, 6, 15, 13, 45, 30,
            //                              DateTimeKind.Utc);
            // Console.WriteLine("{0} ({1}) --> {0:O}", uDat, uDat.Kind);

            // DateTime lDat = new DateTime(2009, 6, 15, 13, 45, 30,
            //                              DateTimeKind.Local);
            // Console.WriteLine("{0} ({1}) --> {0:O}\n", lDat, lDat.Kind);

            // DateTimeOffset dto = new DateTimeOffset(lDat);
            // Console.WriteLine("{0} --> {0:O}", dto);


            // // Round-trip DateTime values.
            // DateTime originalDate, newDate;
            // string dateString;
            // // Round-trip a local time.
            // originalDate = DateTime.SpecifyKind(new DateTime(2008, 4, 10, 6, 30, 0), DateTimeKind.Local);
            // dateString = originalDate.ToString("o");
            // newDate = DateTime.Parse(dateString, null, DateTimeStyles.RoundtripKind);
            // Console.WriteLine("Round-tripped {0} {1} to {2} {3}.", originalDate, originalDate.Kind,
            //                   newDate, newDate.Kind);
            // // Round-trip a UTC time.
            // originalDate = DateTime.SpecifyKind(new DateTime(2008, 4, 12, 9, 30, 0), DateTimeKind.Utc);
            // dateString = originalDate.ToString("o");
            // newDate = DateTime.Parse(dateString, null, DateTimeStyles.RoundtripKind);
            // Console.WriteLine("Round-tripped {0} {1} to {2} {3}.", originalDate, originalDate.Kind,
            //                   newDate, newDate.Kind);
            // // Round-trip time in an unspecified time zone.
            // originalDate = DateTime.SpecifyKind(new DateTime(2008, 4, 13, 12, 30, 0), DateTimeKind.Unspecified);
            // dateString = originalDate.ToString("o");
            // newDate = DateTime.Parse(dateString, null, DateTimeStyles.RoundtripKind);
            // Console.WriteLine("Round-tripped {0} {1} to {2} {3}.", originalDate, originalDate.Kind,
            //                   newDate, newDate.Kind);

            // // Round-trip a DateTimeOffset value.
            // DateTimeOffset originalDTO = new DateTimeOffset(2008, 4, 12, 9, 30, 0, new TimeSpan(-8, 0, 0));
            // dateString = originalDTO.ToString("o");
            // DateTimeOffset newDTO = DateTimeOffset.Parse(dateString, null, DateTimeStyles.RoundtripKind);
            // Console.WriteLine("Round-tripped {0} to {1}.", originalDTO, newDTO);
            // // The example displays the following output:
            // //    Round-tripped 4/10/2008 6:30:00 AM Local to 4/10/2008 6:30:00 AM Local.
            // //    Round-tripped 4/12/2008 9:30:00 AM Utc to 4/12/2008 9:30:00 AM Utc.
            // //    Round-tripped 4/13/2008 12:30:00 PM Unspecified to 4/13/2008 12:30:00 PM Unspecified.
            // //    Round-tripped 4/12/2008 9:30:00 AM -08:00 to 4/12/2008 9:30:00 AM -08:00.


            // int count = int.Parse("abc");

            Write("How many eggs are there? ");
            // int count;
            string input = ReadLine();
            if (int.TryParse(input, out int count))
            {
                WriteLine($"There are {count} eggs.");
            }
            else
            {
                WriteLine("I could not parse the input.");
            }
        }
    }
}
