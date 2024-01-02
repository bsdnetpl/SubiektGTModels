using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwProfileSlowniki
{
    public int SlId { get; set; }

    public string SlNazwa { get; set; } = null!;

    public string SlOpis { get; set; } = null!;

    public int SlStatusNowosci { get; set; }
}
