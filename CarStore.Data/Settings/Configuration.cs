using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarStore.Data.Settings
{
    public static class Configuration
    {
        static Configuration()
        {
            Laguages.AddRange(new[] { "PL", "EN" });
        }

        public static List<string> Laguages { get; } = new List<string>();
    }
}
