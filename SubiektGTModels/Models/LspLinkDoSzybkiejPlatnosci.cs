using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class LspLinkDoSzybkiejPlatnosci
{
    public int LspId { get; set; }

    public string LspIdApi { get; set; } = null!;

    public int LspStatus { get; set; }

    public string? LspIdPlatnosci { get; set; }

    public string LspLink { get; set; } = null!;

    public decimal LspKwota { get; set; }

    public string LspNumerDokumentu { get; set; } = null!;

    public int LspIdKonfiguracjiSp { get; set; }

    public int? LspIdDokumentu { get; set; }

    public int? LspIdCesji { get; set; }

    public int LspIdKontrahenta { get; set; }

    public DateTime? LspDataZaplaty { get; set; }

    public virtual NzCesja? LspIdCesjiNavigation { get; set; }

    public virtual DokDokument? LspIdDokumentuNavigation { get; set; }

    public virtual SlSzybkiePlatnosci LspIdKonfiguracjiSpNavigation { get; set; } = null!;

    public virtual KhKontrahent LspIdKontrahentaNavigation { get; set; } = null!;
}
