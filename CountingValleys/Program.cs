using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingValleys
{

    //For every step he took, he noted if it was an uphill, or a downhill, step. 
    //Gary's hikes start and end at sea level and each step up or down represents a  unit change in altitude. We define the following terms:
    //    A mountain is a sequence of consecutive steps above sea level, starting with a step up from sea level and ending with a step down to sea level.
    //    A valley is a sequence of consecutive steps below sea level, starting with a step down from sea level and ending with a step up to sea level.
    /////
    ///       mountain +=1;
    ///       valley +=1;
    ///       currentAltitute = mountain - valley;
    ///         
    ///     if(
    ///     
    ///         if (temp == s[i + 1])
    ///          {
    ///              tempcount += 1;
    ///          }


class Program
    {
        // Complete the countingValleys function below.
        //static int countingValleys(int n, string s)
        static int countingValleys(string s)
        {
            int valleys = 0;
            int tempcount = 0;
            int n = s.Length;
            char temp = '\0';

            for (int i = 1; i <= n; i++)
            {
                temp = s[i];

                if (temp == s[i + 1])
                {
                    tempcount += 1;
                }

                //valleys += 1;
            }

            //       N  N+1 N+2 N+3 N+4 N+5 N+6 N+7 N+8
            //       8  U   D   D   D   U   D   U   U
            //  TEMP = U TEMP-COUNT = 1     STEP = 1    N=1>N=2
            //  TEMP = D TEMP-COUNT = 3     STEP = 4    N=4>N=5
            //  TEMP = U TEMP-COUNT = 4     STEP = 5    N=5>N=6
            //  TEMP = D TEMP-COUNT = 1     STEP = 5    N=6>N=7
            //  TEMP = U TEMP-COUNT = 2     STEP = 8    N=8


            return valleys;
        }
        static void Main(string[] args)
        {
            //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            //UDDDUDUU

            //int n = Convert.ToInt32(Console.ReadLine());

            //string s = Console.ReadLine();
            string s = "UDDDUDUU";
            //int n = s.Length;
            //int result = countingValleys(n, s);
            int result = countingValleys(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
