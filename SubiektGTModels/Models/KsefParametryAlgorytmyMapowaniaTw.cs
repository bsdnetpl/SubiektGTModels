using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsefParametryAlgorytmyMapowaniaTw
{
    public int KsefmtwId { get; set; }

    public int? KsefmtwParametryId { get; set; }

    public int KsefmtwParamEwidId { get; set; }

    public int KsefmtwAlgorytm { get; set; }

    public bool KsefmtwAktywny { get; set; }

    public int KsefmtwKolejnosc { get; set; }

    public virtual ParEwid KsefmtwParamEwid { get; set; } = null!;
}
