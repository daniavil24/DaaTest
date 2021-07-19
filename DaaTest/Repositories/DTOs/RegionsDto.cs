using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.DTOs
{
    public class RegionsDto
    {
        public IEnumerable<Region> Data { get; set; }
    }

    public class Region
    {
        public string Iso { get; set; }
        public string Name { get; set; }
    }
}