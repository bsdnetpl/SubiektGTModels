using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GtPlik
{
    public int GtpId { get; set; }

    public int GtpIdWpisu { get; set; }

    public string GtpNazwaPliku { get; set; } = null!;
}
