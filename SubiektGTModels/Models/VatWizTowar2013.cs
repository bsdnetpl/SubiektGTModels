using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatWizTowar2013
{
    public int Vwtw2Id { get; set; }

    public int Vwtw2Wersja { get; set; }

    public int Vwtw2LiczbaUruchom { get; set; }

    public int Vwtw2IdVatSpOld { get; set; }

    public int Vwtw2IdVatSpNew { get; set; }

    public int Vwtw2IdVatZakOld { get; set; }

    public int Vwtw2IdVatZakNew { get; set; }

    public bool Vwtw2BlokadaSpr { get; set; }

    public bool Vwtw2BlokadaZak { get; set; }

    public DateTime Vwtw2Data { get; set; }
}
