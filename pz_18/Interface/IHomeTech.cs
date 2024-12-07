using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Interface
{
    public interface IHomeTech
    {
        int HomeTechId { get; set; }
        string HomeTechType { get; set; }
        string HomeTechModel { get; set; }
    }
}
