using Repositories.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interface.Regiones
{
    public interface IRegions
    {
        RegionsDto GetCasesRegions(string iso);
        RegionesList GetRegions();
    }
}
