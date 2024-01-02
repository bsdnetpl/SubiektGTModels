﻿using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwKompensatyRew
{
    public int NzkId { get; set; }

    public int NzkStatus { get; set; }

    public DateTime NzkDataWystawienia { get; set; }

    public DateTime? NzkDataRealizacji { get; set; }

    public int NzkNumer { get; set; }

    public string? NzkNrPelny { get; set; }

    public int NzkIdObiektu { get; set; }

    public int NzkTypObiektu { get; set; }

    public int? NzkIdKategorii { get; set; }

    public int NzkIdHistoriiAdresu { get; set; }

    public decimal NzkWartosc { get; set; }

    public decimal NzkWartoscWaluta { get; set; }

    public string NzkWaluta { get; set; } = null!;

    public int NzkIdPersonelu { get; set; }

    public int NzkImport { get; set; }

    public int NzkProgram { get; set; }

    public int? SsTypObiektu { get; set; }

    public int? SsTypObiektuEx { get; set; }

    public DateTime? SsDataZamkniecia { get; set; }

    public DateTime? SsDataBlokadyRach { get; set; }
}
