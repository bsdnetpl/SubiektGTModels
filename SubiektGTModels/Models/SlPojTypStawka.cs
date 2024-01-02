using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlPojTypStawka
{
    public int SpsId { get; set; }

    public int SpsTypPojazdu { get; set; }

    public decimal SpsStawka { get; set; }

    public DateTime SpsWaznaOd { get; set; }
}
