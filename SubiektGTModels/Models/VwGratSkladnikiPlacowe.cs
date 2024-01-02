using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratSkladnikiPlacowe
{
    public int SpId { get; set; }

    public bool SpAktywny { get; set; }

    public int SpTyp { get; set; }

    public string SpNazwa { get; set; } = null!;

    public string SpOpis { get; set; } = null!;

    public int SpRodzaj { get; set; }

    public int SpPlatnyPrzez { get; set; }

    public bool SpOpodatkowany { get; set; }

    public bool SpDoPodstEmRe { get; set; }

    public bool SpDoPodstChWy { get; set; }

    public bool SpDoPodstZdr { get; set; }

    public DateTime? SpdDataOd { get; set; }

    public DateTime? SpdDataDo { get; set; }

    public string? Wartosc { get; set; }

    public string? AdrNazwa { get; set; }

    public bool SpZwolnienieZpodatku { get; set; }

    public bool SpZwolnienieZpodatkuDlaMlodych { get; set; }
}
