using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Interface
{
    public interface ISpecialistType
    {
        int SpecialistId { get; set; }
        string Type { get; set; }
    }
}
