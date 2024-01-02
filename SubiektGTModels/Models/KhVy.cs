using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhVy
{
    public int KhvId { get; set; }

    public int? KhvIdKh { get; set; }

    public int? KhvIdUz { get; set; }

    public bool? KhvAktywnosc { get; set; }

    public string? KhvNazwa { get; set; }

    public string? KhvPanstwoCzlonkowskie { get; set; }

    public string? KhvNumerVat { get; set; }

    public DateTime? KhvDataZapytania { get; set; }

    public string? KhvAdres { get; set; }

    public string? KhvIdentyfikatorZapytania { get; set; }

    public string? KhvZapytanie { get; set; }

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual KhKontrahent? KhvIdKhNavigation { get; set; }

    public virtual PdUzytkownik? KhvIdUzNavigation { get; set; }

    public virtual ICollection<VatEwidVat> VatEwidVats { get; set; } = new List<VatEwidVat>();
}
