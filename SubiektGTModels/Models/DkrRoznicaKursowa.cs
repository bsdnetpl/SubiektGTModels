using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrRoznicaKursowa
{
    public int DkrkId { get; set; }

    public DateTime DkrkData { get; set; }

    public string DkrkKonto { get; set; } = null!;

    public string DkrkOpis { get; set; } = null!;

    public decimal DkrkKwota { get; set; }

    public int DkrkTyp { get; set; }

    public int DkrkIdRoku { get; set; }

    public int? DkrkIdPozycji { get; set; }

    public int? DkrkIdPozycjiWyplaty { get; set; }

    public int? DkrkIdRoznicy { get; set; }

    public decimal? DkrkKurs { get; set; }

    public int? DkrkLiczbaJednostek { get; set; }

    public virtual DkrPozycja? DkrkIdPozycjiNavigation { get; set; }

    public virtual DkrPozycja? DkrkIdPozycjiWyplatyNavigation { get; set; }

    public virtual PdRokObrotowy DkrkIdRokuNavigation { get; set; } = null!;

    public virtual DkrRoznicaKursowa? DkrkIdRoznicyNavigation { get; set; }

    public virtual ICollection<DkrRoznicaKursowa> InverseDkrkIdRoznicyNavigation { get; set; } = new List<DkrRoznicaKursowa>();
}
