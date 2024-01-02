using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhWeryfikacjaNip
{
    public int KhwnId { get; set; }

    public int? KhwnIdKh { get; set; }

    public int KhwnIdUz { get; set; }

    public int KhwnAktywnosc { get; set; }

    public string KhwnNumerNip { get; set; } = null!;

    public DateTime KhwnDataZapytania { get; set; }

    public int KhwnAktywnoscPortalPodatkowy { get; set; }

    public bool? KhwnZnalezionoWwykazieWykreslonych { get; set; }

    public DateTime? KhwnDataZapytaniaWykazWykreslonych { get; set; }

    public bool? KhwnZnalezionoWwykaziePrzywroconych { get; set; }

    public DateTime? KhwnDataZapytaniaWykazPrzywroconych { get; set; }

    public int KhwnGdzieSprawdzono { get; set; }

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual KhKontrahent? KhwnIdKhNavigation { get; set; }

    public virtual PdUzytkownik KhwnIdUzNavigation { get; set; } = null!;

    public virtual ICollection<VatEwidVat> VatEwidVats { get; set; } = new List<VatEwidVat>();
}
