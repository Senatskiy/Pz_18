using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Interface
{
    public interface ITechnicianComment
    {
        int CommentId { get; }
        string CommentText { get; set; }
        int SpecialistId { get; set; }
        int RequestId { get; set; }
    }
}