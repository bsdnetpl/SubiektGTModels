using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwRachunkiBialaListaLogUnikalnePozycje
{
    public int KhrId { get; set; }

    public string KhrNumerRachunku { get; set; } = null!;

    public int? KhrIdRachunek { get; set; }

    public string KhrNip { get; set; } = null!;

    public DateTime KhrDataWeryfikacji { get; set; }

    public bool KhrNaBialejLiscie { get; set; }
}
