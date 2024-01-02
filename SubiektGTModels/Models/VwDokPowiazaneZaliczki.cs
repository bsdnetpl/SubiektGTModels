using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokPowiazaneZaliczki
{
    public int DokId { get; set; }

    public int DokTyp { get; set; }

    public int DokPodtyp { get; set; }

    public int? PowId { get; set; }
}
