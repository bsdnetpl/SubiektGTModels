using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokDokumentDefiniowalnyWzw
{
    public int DdwId { get; set; }

    public int DdwDokDefId { get; set; }

    public string DdwNazwaKomputera { get; set; } = null!;

    public int DdwWzorzecId { get; set; }
}
