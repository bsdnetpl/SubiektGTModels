using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CpCelPrzetwarzanium
{
    public int CptId { get; set; }

    public string CptNazwa { get; set; } = null!;

    public string CptTresc { get; set; } = null!;

    public bool CptCzyAktywny { get; set; }

    public int CptRodzOkresowosci { get; set; }

    public int? CptCzasTrwania { get; set; }

    public DateTime? CptDataZakonczenia { get; set; }

    public bool CptCzyDrukowac { get; set; }

    public virtual ICollection<KhZgody> KhZgodies { get; set; } = new List<KhZgody>();

    public virtual ICollection<RcpRejestrCzynnosciPrzetwarzaniaCele> RcpRejestrCzynnosciPrzetwarzaniaCeles { get; set; } = new List<RcpRejestrCzynnosciPrzetwarzaniaCele>();
}
