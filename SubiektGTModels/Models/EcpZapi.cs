using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EcpZapi
{
    public int EcpId { get; set; }

    public int EcpIdPrac { get; set; }

    public DateTime EcpData { get; set; }

    public DateTime EcpDataDo { get; set; }

    public int EcpRodzajZapisu { get; set; }

    public bool EcpKorekta { get; set; }

    public string EcpPrzedKorekta { get; set; } = null!;

    public DateTime? EcpKorektaKiedy { get; set; }

    public int? EcpKorektaKto { get; set; }

    public bool EcpKorektaRozliczWyplata { get; set; }

    public int? EcpKorektaIdRozliczajacejWyplaty { get; set; }

    public int? EcpKorektaPrzedRodzajZapisu { get; set; }

    public virtual ICollection<EcpGodzina> EcpGodzinas { get; set; } = new List<EcpGodzina>();

    public virtual PlbWyplatum? EcpKorektaIdRozliczajacejWyplatyNavigation { get; set; }

    public virtual ICollection<EcpObecnosc> EcpObecnoscs { get; set; } = new List<EcpObecnosc>();
}
