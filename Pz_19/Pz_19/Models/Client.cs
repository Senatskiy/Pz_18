using System;
using System.Collections.Generic;

namespace Pz_19.Models;

public partial class Client
{
    public int ClientId { get; set; }

    public string Type { get; set; } = null!;

    public virtual ICollection<Request> Requests { get; set; } = new List<Request>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
