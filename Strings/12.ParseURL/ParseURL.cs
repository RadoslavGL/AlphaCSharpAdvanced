//http://telerikacademy.com/Courses/Courses/Details/212

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
            string address = Console.ReadLine();

            string[] splitters = new string[] { "://", "/", ""};
            string[] partsAddress = address.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sbProtocol = new StringBuilder(partsAddress[0]);

            StringBuilder sbServer = new StringBuilder(partsAddress[1]);

            StringBuilder sbResources = new StringBuilder();
            for (int i = 2; i < partsAddress.Length; i++)
            {
                sbResources.Append('/');
                sbResources.Append(partsAddress[i]);
            }

            Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}",
                sbProtocol.ToString().Trim(),
                sbServer.ToString().Trim(),
                sbResources.ToString().TrimEnd());

        }
    }
}
