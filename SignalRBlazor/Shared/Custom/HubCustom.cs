using Microsoft.AspNetCore.SignalR;

namespace SignalRBlazor.Client.Custom
{
    public abstract class HubCustom : IDisposable
    {
        private bool _disposed;

        private IHubCallerClients _clients;

        private HubCallerContext _context;

        private IGroupManager _groups;

        //
        // Summary:
        //     Gets or sets an object that can be used to invoke methods on the clients connected
        //     to this hub.
        public IHubCallerClients Clients
        {
            get
            {
                CheckDisposed();
                return _clients;
            }
            set
            {
                CheckDisposed();
                _clients = value;
            }
        }

        //
        // Summary:
        //     Gets or sets the hub caller context.
        public HubCallerContext Context
        {
            get
            {
                CheckDisposed();
                return _context;
            }
            set
            {
                CheckDisposed();
                _context = value;
            }
        }

        //
        // Summary:
        //     Gets or sets the group manager.
        public IGroupManager Groups
        {
            get
            {
                CheckDisposed();
                return _groups;
            }
            set
            {
                CheckDisposed();
                _groups = value;
            }
        }

        //
        // Summary:
        //     Called when a new connection is established with the hub.
        //
        // Returns:
        //     A System.Threading.Tasks.Task that represents the asynchronous connect.
        public virtual Task OnConnectedAsync()
        {
            return Task.CompletedTask;
        }

        //
        // Summary:
        //     Called when a connection with the hub is terminated.
        //
        // Returns:
        //     A System.Threading.Tasks.Task that represents the asynchronous disconnect.
        public virtual Task OnDisconnectedAsync(Exception exception)
        {
            return Task.CompletedTask;
        }

        //
        // Summary:
        //     Releases all resources currently used by this Microsoft.AspNetCore.SignalR.Hub
        //     instance.
        //
        // Parameters:
        //   disposing:
        //     true if this method is being invoked by the Microsoft.AspNetCore.SignalR.Hub.Dispose
        //     method, otherwise false.
        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                Dispose(disposing: true);
                _disposed = true;
            }
        }

        private void CheckDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException(GetType().Name);
            }
        }
    }
}
