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

            string[] splitters = new string[] { "://"};
            string[] partsAddress = address.Split(splitters, StringSplitOptions.RemoveEmptyEntries);

            StringBuilder sbProtocol = new StringBuilder(partsAddress[0]);

            string serverAndResources = partsAddress[1];
            int indexOfFirstSlash = serverAndResources.IndexOf('/');

            StringBuilder sbServer = new StringBuilder();

            sbServer.Append(serverAndResources, 0, indexOfFirstSlash);

            StringBuilder sbResources = new StringBuilder();
            sbResources.Append('/');
            sbResources.Append(serverAndResources, 
                (indexOfFirstSlash + 1), 
                (serverAndResources.Length - (indexOfFirstSlash + 1)));

            Console.WriteLine("[protocol] = {0}\n[server] = {1}\n[resource] = {2}",
                sbProtocol.ToString().TrimEnd(),
                sbServer.ToString().TrimEnd(),
                sbResources.ToString().TrimEnd());

        }
    }
}
