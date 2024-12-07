using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Interface
{
    public interface IRequest
    {
        int RequestId { get; }
        DateTime RequestDate { get; set; }
        int HomeTechId { get; set; }
        string FaultType { get; set; }
        int UserId { get; set; }
        int StatusId { get; set; }
        DateTime? CompletionDate { get; set; }
        int SpecialistId { get; set; }
        int ClientId { get; set; }

        void UpdateStatus(int newStatusId);
        void AssignSpecialist(int specialistId);
    }
}
