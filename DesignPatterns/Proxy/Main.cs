using System.Linq;
/// <summary>
/// A proxy, in its most general form, is a class functioning as an interface to something else. The proxy could interface to anything: 
/// a network connection, a large object in memory, a file, or some other resource that is expensive or impossible to duplicate. 
/// In short, a proxy is a wrapper or agent object that is being called by the client to access the real serving object behind the scenes. 
/// </summary>
namespace DesignPatterns.Proxy
{
    public partial class Main : IPattern
    {
        public void Start()
        {
            // Create proxy and request a service

            Proxy proxy = new Proxy();
            proxy.Request();
            System.Console.WriteLine($" using {proxy.GetType().Name.Split('.').Last()}");

        }
    }
}
