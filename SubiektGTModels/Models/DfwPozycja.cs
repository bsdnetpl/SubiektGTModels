using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DfwPozycja
{
    public int FwpId { get; set; }

    public int? FwpDoId { get; set; }

    public int? FwpStatus { get; set; }

    public int? FwpLp { get; set; }

    public int FwpIdFaktWewn { get; set; }

    public int? FwpDokId { get; set; }

    public int? FwpPozId { get; set; }

    public int? FwpTowId { get; set; }

    public int FwpTowRodzaj { get; set; }

    public string? FwpOpis { get; set; }

    public decimal FwpIlosc { get; set; }

    public string? FwpJm { get; set; }

    public decimal FwpCenaWaluta { get; set; }

    public decimal FwpWartWaluta { get; set; }

    public string? FwpWaluta { get; set; }

    public decimal FwpWalutaKurs { get; set; }

    public int FwpWalutaLiczbaJednostek { get; set; }

    public int? FwpWalutaRodzajKursu { get; set; }

    public DateTime? FwpWalutaDataKursu { get; set; }

    public int? FwpWalutaIdBanku { get; set; }

    public int? FwpVatId { get; set; }

    public decimal FwpVatProc { get; set; }

    public decimal FwpCenaNetto { get; set; }

    public decimal FwpCenaBrutto { get; set; }

    public decimal FwpRabat { get; set; }

    public decimal FwpWartNetto { get; set; }

    public decimal FwpWartVat { get; set; }

    public decimal FwpWartBrutto { get; set; }

    public int? FwpKategoriaId { get; set; }

    public int? FwpPozDoId { get; set; }

    public string? FwpPkwiu { get; set; }

    public string? FwpTowKodCn { get; set; }

    public virtual DokDokument? FwpDok { get; set; }

    public virtual DfwFakturyWewnetrzne FwpIdFaktWewnNavigation { get; set; } = null!;

    public virtual TwTowar? FwpTow { get; set; }
}
