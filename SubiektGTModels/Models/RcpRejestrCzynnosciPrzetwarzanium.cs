using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RcpRejestrCzynnosciPrzetwarzanium
{
    public int RcpId { get; set; }

    public int RcpProwadzonyPrzez { get; set; }

    public string RcpNazwaZbioru { get; set; } = null!;

    public string RcpKategorieOsob { get; set; } = null!;

    public string RcpKategorieDanych { get; set; } = null!;

    public string RcpOdbiorcyDanych { get; set; } = null!;

    public string RcpPanstwaTrzecie { get; set; } = null!;

    public string RcpPlanowaneTerminyUsuniecia { get; set; } = null!;

    public string RcpOpisSrodkow { get; set; } = null!;

    public virtual ICollection<RcpRejestrCzynnosciPrzetwarzaniaCele> RcpRejestrCzynnosciPrzetwarzaniaCeles { get; set; } = new List<RcpRejestrCzynnosciPrzetwarzaniaCele>();
}
