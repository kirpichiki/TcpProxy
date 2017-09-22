using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace TcpProxy
{
    public class Listener
    {
        public async Task Listen(CancellationToken cancellationToken)
        {
            var listener = new TcpListener(IPAddress.Any, 6060);
            ThreadPool.QueueUserWorkItem();
            while (!cancellationToken.IsCancellationRequested)
            listener.
        }
    }
}
