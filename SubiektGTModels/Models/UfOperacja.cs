using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfOperacja
{
    public int UopId { get; set; }

    public string UopNazwa { get; set; } = null!;

    public virtual ICollection<UfTransmisja> UfTransmisjas { get; set; } = new List<UfTransmisja>();

    public virtual ICollection<UfZadanie> UfZadanies { get; set; } = new List<UfZadanie>();
}
