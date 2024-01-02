using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDokumentyCzastkoweKfsCr
{
    public int? DokId { get; set; }

    public string DokNrPelny { get; set; } = null!;

    public decimal DokWartBrutto { get; set; }

    public DateTime DokDataWyst { get; set; }

    public int? DoDokId { get; set; }

    public decimal DokWalutaKurs { get; set; }
}
