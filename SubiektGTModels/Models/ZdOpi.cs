using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdOpi
{
    public int ZdoId { get; set; }

    public int ZdoIdZadania { get; set; }

    public string ZdoOpis { get; set; } = null!;

    public string? ZdoOpisTekst { get; set; }

    public virtual ZdZadanie ZdoIdZadaniaNavigation { get; set; } = null!;
}
