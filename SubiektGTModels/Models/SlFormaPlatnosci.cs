using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlFormaPlatnosci
{
    public int FpId { get; set; }

    public string FpNazwa { get; set; } = null!;

    public int FpTermin { get; set; }

    public int FpTyp { get; set; }

    public int? FpRachBankId { get; set; }

    public int? FpCentId { get; set; }

    public int? FpInstKredytId { get; set; }

    public bool? FpGlowna { get; set; }

    public bool FpAktywna { get; set; }

    public bool FpTerminalPlatniczy { get; set; }

    public int? FpFormaPlatnosciWysylajJako { get; set; }

    public string? FpOpisPlatnosciInna { get; set; }

    public virtual ICollection<KhKontrahent> KhKontrahents { get; set; } = new List<KhKontrahent>();

    public virtual ICollection<KhParametr> KhParametrs { get; set; } = new List<KhParametr>();

    public virtual ICollection<OssEwid> OssEwids { get; set; } = new List<OssEwid>();

    public virtual ICollection<SlEwidVatOss> SlEwidVatOsses { get; set; } = new List<SlEwidVatOss>();

    public virtual ICollection<SlSubKonto> SlSubKontos { get; set; } = new List<SlSubKonto>();

    public virtual ICollection<SlTypEwidVat> SlTypEwidVats { get; set; } = new List<SlTypEwidVat>();

    public virtual ICollection<VatEwidVat> VatEwidVats { get; set; } = new List<VatEwidVat>();
}
