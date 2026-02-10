using System.Security.AccessControl;
using System.Text;

namespace DataCenter
{
    public class Rack
    {
        public Rack(int slots)
        {
            Slots = slots;
            Servers = new List<Server>();
        }

        public int Slots
        {
            get;
            set;
        }
        public List<Server> Servers { get; set; }

        public int GetCount
        {
            get { return Servers.Count; }
        }
        public void AddServer(Server server)
        {
            if (Slots > GetCount && !Servers.Exists(s => s.SerialNumber == server.SerialNumber))
            {
                Servers.Add(server);
            }
        }

        public bool RemoveServer(string serialNumber)
        {
            Server server = Servers.FirstOrDefault(s => s.SerialNumber == serialNumber);

            if (server != null)
            {
                Servers.Remove(server);
                return true;
            }

            return false;
        }

        public string GetHighestPowerUsage()
        {
            Server server = Servers.MaxBy(s => s.PowerUsage);
            return server.ToString();
        }

        public int GetTotalCapacity()
        {
            int capacity = Servers.Sum(s => s.Capacity);
            return capacity;
        }

        public string DeviceManager()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{GetCount} servers operating:");

            foreach (var server in Servers)
            {
                sb.AppendLine(server.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
