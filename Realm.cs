using System.Collections.Generic;

namespace Login
{
    public class Realm
    {
        public string Name { get; set; }
        public string ClusterUrl { get; set; }
        public string DatabaseUrl { get; set; }
        public Dictionary<string, string> OtherServiceUrls { get; set; } = new Dictionary<string, string>();
    }
}
