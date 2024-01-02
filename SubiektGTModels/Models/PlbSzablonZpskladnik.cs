using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbSzablonZpskladnik
{
    public int SzskId { get; set; }

    public int SzskIdSzablonu { get; set; }

    public int SzskIdSkladnika { get; set; }

    public virtual PlbSkladnik SzskIdSkladnikaNavigation { get; set; } = null!;

    public virtual PlbSzablonZp SzskIdSzablonuNavigation { get; set; } = null!;
}
