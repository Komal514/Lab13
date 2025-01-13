using Microsoft.AspNetCore.Hosting.Server;

namespace Activity_01.Components.Models
{
    public class ServersRepository
    {
        private static List<Server> servers = new List<Server>
        {
            new Server { Name = "Server1", City = "Toronto", IsOnline = true },
            new Server { Name = "Server2", City = "Toronto", IsOnline = true },
            new Server { Name = "Server3", City = "Toronto", IsOnline = true },
            new Server { Name = "Server4", City = "Toronto", IsOnline = false },
            new Server { Name = "Server1", City = "Montreal", IsOnline = true },
        };

        public static List<Server> GetServersByCity(string city)
        {
            return servers.Where(s => s.City == city).ToList();
        }
    }
}
