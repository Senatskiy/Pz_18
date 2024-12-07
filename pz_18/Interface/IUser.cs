using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Interface
{
    public interface IUser
    {
        int UserId { get; }
        string FullName { get; set; }
        string PhoneNumber { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        int SpecialistId { get; set; }
        int ClientId { get; set; }
    }
}
