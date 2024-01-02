using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokPozycja
{
    public int ObId { get; set; }

    public int? ObDoId { get; set; }

    public short ObZnak { get; set; }

    public int? ObStatus { get; set; }

    public int? ObDokHanId { get; set; }

    public int? ObDokMagId { get; set; }

    public int? ObTowId { get; set; }

    public int ObTowRodzaj { get; set; }

    public string? ObOpis { get; set; }

    public int? ObDokHanLp { get; set; }

    public int? ObDokMagLp { get; set; }

    public decimal ObIlosc { get; set; }

    public decimal ObIloscMag { get; set; }

    public string? ObJm { get; set; }

    public decimal ObCenaMag { get; set; }

    public decimal ObCenaWaluta { get; set; }

    public decimal ObCenaNetto { get; set; }

    public decimal ObCenaBrutto { get; set; }

    public decimal ObRabat { get; set; }

    public decimal ObWartMag { get; set; }

    public decimal ObWartNetto { get; set; }

    public decimal ObWartVat { get; set; }

    public decimal ObWartBrutto { get; set; }

    public int? ObVatId { get; set; }

    public decimal ObVatProc { get; set; }

    public DateTime? ObTermin { get; set; }

    public int? ObMagId { get; set; }

    public string? ObNumerSeryjny { get; set; }

    public int? ObKategoriaId { get; set; }

    public bool? ObAkcyza { get; set; }

    public decimal? ObAkcyzaKwota { get; set; }

    public decimal? ObAkcyzaWartosc { get; set; }

    public decimal? ObCenaNabycia { get; set; }

    public decimal? ObWartNabycia { get; set; }

    public int? ObPrzyczynaKorektyId { get; set; }

    public int? ObCenaPobranaZcennika { get; set; }

    public string? ObTowPkwiu { get; set; }

    public string? ObTowKodCn { get; set; }

    public string? ObSyncId { get; set; }

    public bool? ObOplCukrowaPodlega { get; set; }

    public decimal? ObOplCukrowaObj { get; set; }

    public decimal? ObOplCukrowaKwCukier { get; set; }

    public decimal? ObOplCukrowaKwKofeina { get; set; }

    public decimal? ObOplCukrowaKwSuma { get; set; }

    public decimal? ObOplCukrowaWartCukier { get; set; }

    public decimal? ObOplCukrowaWartKofeina { get; set; }

    public decimal? ObOplCukrowaWartSuma { get; set; }

    public decimal? ObOplCukrowaKwCukierEx { get; set; }

    public int? ObOplCukrowaParametry { get; set; }

    public decimal? ObOplCukrowaCukierZawartoscEx { get; set; }

    public int? ObOznaczenieGtu { get; set; }

    public string? ObKsefUuid { get; set; }

    public string ObWegielOpisPochodzenia { get; set; } = null!;

    public string ObWegielDataWprowadzeniaLubNabycia { get; set; } = null!;

    public virtual ICollection<DokMagRuch> DokMagRuches { get; set; } = new List<DokMagRuch>();

    public virtual ICollection<DokPozycja> InverseObDo { get; set; } = new List<DokPozycja>();

    public virtual DokPozycja? ObDo { get; set; }

    public virtual DokDokument? ObDokHan { get; set; }

    public virtual DokDokument? ObDokMag { get; set; }

    public virtual TwTowar? ObTow { get; set; }
}
