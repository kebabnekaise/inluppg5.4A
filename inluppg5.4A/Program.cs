using System;

namespace inluppg5_4A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] namn = new string[] { "Xerxes", "Adam", "Erik", "Xuxuman", "Mmmmmmmmmmmm" };
            string[] sorteradeNamn = new string[namn.Length];

            int highNamn = 0;
            for (int i = 0; i < namn.Length; i++)
            {
                if ((int)namn[i][0] < (int)namn[highNamn][0])
                {
                    highNamn = i;
                }
                //Kollar om två namn börjar med samma namn
                else if ((int)namn[i][1] < (int)namn[highNamn][1] && (int)namn[i][0] == (int)namn[highNamn][0])
                {
                    highNamn = i;
                }
            }

            Console.WriteLine(namn[highNamn]);
        }
    }
}