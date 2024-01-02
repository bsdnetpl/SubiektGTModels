using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCrmEtap
{
    public int TrdId { get; set; }

    public string TrdNazwa { get; set; } = null!;

    public int TrdScenariusz { get; set; }

    public int TrdKolejnosc { get; set; }

    public int TrdProcentSukcesu { get; set; }

    public bool TrdZamowienie { get; set; }

    public bool TrdKoncowy { get; set; }
}
