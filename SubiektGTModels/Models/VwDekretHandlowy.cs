using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwDekretHandlowy
{
    public int DkrId { get; set; }

    public string DkrNrPelny { get; set; } = null!;

    public int? DkrIdDokImport { get; set; }
}
