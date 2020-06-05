using System;
using System.Threading.Tasks;

namespace Opentok.Standard.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            OpentokSessionManager sm = new OpentokSessionManager();
            await sm.GetTokenAsync().ConfigureAwait(false);
            Console.WriteLine(sm.SessionId);
            Console.WriteLine(sm.Token);
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
