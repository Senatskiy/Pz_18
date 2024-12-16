using System;
using System.Collections.Generic;

namespace Pz_19.Models;

public partial class SpecialistsType
{
    public int SpecialistId { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<TechnicianComment> TechnicianComments { get; set; } = new List<TechnicianComment>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
