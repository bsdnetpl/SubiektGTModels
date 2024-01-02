using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlInformacjeOpodatkuAkcyzowym
{
    public int SliopId { get; set; }

    public string SliopWartosc { get; set; } = null!;

    public bool SliopAktywna { get; set; }
}
