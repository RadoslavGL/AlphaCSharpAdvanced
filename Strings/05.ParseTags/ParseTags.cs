using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParseTags
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        int indexFoundOpen = 0;
        int indexFoundClose = 0;
        int indexStartSearch = 0;

        StringBuilder sb = new StringBuilder(input);

        while (true)
        {
            indexFoundOpen = input.IndexOf("<upcase>", indexStartSearch);
            indexFoundClose = input.IndexOf("</upcase>", indexStartSearch);

            if (indexFoundOpen > -1)    
            {
                for (int i = indexFoundOpen + 8; i <= indexFoundClose - 1; i++)
                {
                    sb[i] = char.ToUpper(sb[i]);
                }

                indexStartSearch = indexFoundClose + 9;
            }
            else
            {
                break;
            }
        }

        sb.Replace("<upcase>", "");
        sb.Replace("</upcase>", "");

        input = sb.ToString();

        Console.WriteLine(input);
    }
}

