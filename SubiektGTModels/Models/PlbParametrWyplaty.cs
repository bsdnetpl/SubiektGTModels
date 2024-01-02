using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbParametrWyplaty
{
    public int GpId { get; set; }

    public bool GpWypGenerujZadanie { get; set; }

    public string GpWypOpisZadania { get; set; } = null!;

    public int? GpParamEwidId { get; set; }

    public int GpSpNalPodstWynUrl { get; set; }

    public int GpSpOblDefSkl { get; set; }

    public virtual ParEwid? GpParamEwid { get; set; }
}
