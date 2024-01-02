using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStawkaProwizyjnaProg
{
    public int SppId { get; set; }

    public int SppIdStawkiProwizyjnej { get; set; }

    public int SppLp { get; set; }

    public decimal SppProg { get; set; }

    public decimal SppWartosc { get; set; }
}
