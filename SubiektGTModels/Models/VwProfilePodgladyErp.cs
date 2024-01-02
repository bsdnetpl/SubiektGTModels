using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfilePodgladyErp
{
    public int GttId { get; set; }

    public bool? GttIsBuiltIn { get; set; }

    public string GtoNazwa { get; set; } = null!;

    public string GttNazwa { get; set; } = null!;

    public bool GttDomyslna { get; set; }

    public int? GttDefinicjaId { get; set; }

    public int GttObiektId { get; set; }

    public int GttStatusNowosci { get; set; }
}
