using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RfPozycja
{
    public int RfpId { get; set; }

    public int RfpIdRapFisk { get; set; }

    public int? RfpDokId { get; set; }

    public DateTime RfpDokDataZakonczenia { get; set; }

    public DateTime RfpDokDataWyst { get; set; }

    public string RfpDokNrPelny { get; set; } = null!;

    public decimal RfpWartNetto { get; set; }

    public decimal RfpWartVat { get; set; }

    public decimal RfpWartBrutto { get; set; }

    public int? RfpPrzyczynaZwrotu { get; set; }

    public virtual DokDokument? RfpDok { get; set; }

    public virtual RfRaportyFiskalne RfpIdRapFiskNavigation { get; set; } = null!;
}
