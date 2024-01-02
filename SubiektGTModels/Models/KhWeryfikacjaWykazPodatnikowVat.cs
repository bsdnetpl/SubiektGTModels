using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhWeryfikacjaWykazPodatnikowVat
{
    public int KhwpId { get; set; }

    public int KhwpIdUz { get; set; }

    public int? KhwpIdKh { get; set; }

    public string KhwpNumerNip { get; set; } = null!;

    public int KhwpAktywnosc { get; set; }

    public DateTime KhwpDataZapytania { get; set; }

    public string KhwpIdentyfikatorZapytania { get; set; } = null!;

    public DateTime KhwpDataWeryfikacji { get; set; }

    public DateTime? KhwpDataRejestracji { get; set; }

    public DateTime? KhwpDataOdmowyRejestracji { get; set; }

    public string KhwpPowodOdmowyRejestracji { get; set; } = null!;

    public DateTime? KhwpDataWykreslenia { get; set; }

    public string KhwpPowodWykreslenia { get; set; } = null!;

    public DateTime? KhwpDataPrzywrocenia { get; set; }

    public string KhwpPowodPrzywrocenia { get; set; } = null!;

    public virtual KhKontrahent? KhwpIdKhNavigation { get; set; }
}
