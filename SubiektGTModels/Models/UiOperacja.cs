using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiOperacja
{
    public int UioId { get; set; }

    public string Odpowiedzialny { get; set; } = null!;

    public string UioStrId { get; set; } = null!;

    public int UioTyp { get; set; }

    public string UioNazwa { get; set; } = null!;

    public string UioOpis { get; set; } = null!;

    public string UioProgId { get; set; } = null!;

    public int UioTypKontekstu { get; set; }

    public string UioKontekst { get; set; } = null!;

    public int? UioIdUprawnienia { get; set; }

    public string? UioParametr { get; set; }

    public bool UioUkryte { get; set; }

    public virtual ICollection<Sf2OperacjaSferyczna> Sf2OperacjaSferycznas { get; set; } = new List<Sf2OperacjaSferyczna>();

    public virtual ICollection<UiOperacjaModul> UiOperacjaModuls { get; set; } = new List<UiOperacjaModul>();

    public virtual PdUprawnienie? UioIdUprawnieniaNavigation { get; set; }
}
