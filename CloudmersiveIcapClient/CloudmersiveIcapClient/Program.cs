using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace CloudmersiveIcapClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] download = File.ReadAllBytes(args[0]);
            CloudmersiveIcapClient icap = new CloudmersiveIcapClient(args[1], 1344, "reqmod", false);
            icap.Method = "REQMOD";


            int result = icap.scanFileWithoutPreview(download);

            Console.WriteLine("Response Code: " + result.ToString());
        }
    }
}
