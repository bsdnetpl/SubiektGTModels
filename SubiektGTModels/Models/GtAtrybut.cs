using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GtAtrybut
{
    public int GtaId { get; set; }

    public int GtaIdObiektu { get; set; }

    public int GtaIdObiektuGt { get; set; }

    public string GtaNazwa { get; set; } = null!;

    public string GtaWartosc { get; set; } = null!;
}
