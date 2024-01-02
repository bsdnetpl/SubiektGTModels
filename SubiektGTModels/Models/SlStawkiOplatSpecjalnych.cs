using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStawkiOplatSpecjalnych
{
    public int SosId { get; set; }

    public int SosTowId { get; set; }

    public int SosTyp { get; set; }

    public DateTime? SosWazneOd { get; set; }

    public DateTime? SosWazneDo { get; set; }

    public decimal? SosStawka { get; set; }
}
