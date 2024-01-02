using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlTrybZakonczeniaDostawyEdd
{
    public int SltzdId { get; set; }

    public string SltzdWartosc { get; set; } = null!;

    public bool SltzdAktywna { get; set; }
}
