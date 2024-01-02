using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlUmowaOpraceSkladnik
{
    public int UpsId { get; set; }

    public int UpsIdWzorca { get; set; }

    public int UpsIdUmowy { get; set; }

    public string UpsNazwaSkladnika { get; set; } = null!;

    public decimal UpsWartosc { get; set; }

    public decimal UpsParametr { get; set; }

    public DateTime UpsDataOd { get; set; }

    public DateTime? UpsDataDo { get; set; }

    public virtual PlUmowaOprace UpsIdUmowyNavigation { get; set; } = null!;

    public virtual SlWzorzecSkladnikaPlacowego UpsIdWzorcaNavigation { get; set; } = null!;
}
