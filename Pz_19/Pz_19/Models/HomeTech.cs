using System;
using System.Collections.Generic;

namespace Pz_19.Models;

public partial class HomeTech
{
    public int HomeTechId { get; set; }

    public string HomeTechType { get; set; } = null!;

    public string HomeTechModel { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();
}
