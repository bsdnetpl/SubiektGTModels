using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaSkladnik
{
    public int UpsId { get; set; }

    public int UpsIdSkladnika { get; set; }

    public int UpsIdUmowy { get; set; }

    public bool UpsSkladnikDrukowany { get; set; }

    public virtual PlbSkladnik UpsIdSkladnikaNavigation { get; set; } = null!;

    public virtual PlbUmowa UpsIdUmowyNavigation { get; set; } = null!;
}
