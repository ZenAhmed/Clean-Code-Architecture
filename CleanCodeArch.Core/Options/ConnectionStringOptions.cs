using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeArch.Domain.Options
{
    public class ConnectionStringOptions
    {
        public const string SectionName = "ConncetionString";
        public string DefaultConnection { get; set; } = null!;
    }
}
