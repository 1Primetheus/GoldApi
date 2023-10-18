using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoldApi.Core.Constants;

public abstract class ConfigConstants
{
    public static readonly Dictionary<string, string> ConnectionStrings = new Dictionary<string, string>()
    {
        {"DemoConnection","Server=localhost;Database=demo;User=root;Password=password;"}
    };
}
