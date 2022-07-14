using System.Net;
using System.Net.NetworkInformation;

public class Program
{
    public static void Main(string[] args)
    {
        // Check if network is available 
        if (!NetworkInterface.GetIsNetworkAvailable())
            Console.WriteLine("No Network Connection");
        else
        {
            Console.WriteLine("Current IP Address: ");

            // Get host entry for current hostname
            var hostname = Dns.GetHostName();
            var host = Dns.GetHostEntry(hostname);

            // Iterate over each IP Address and render their values
            foreach (var address in host.AddressList)
            {
                Console.WriteLine($"\t{address}");
            }
        }
    }
}