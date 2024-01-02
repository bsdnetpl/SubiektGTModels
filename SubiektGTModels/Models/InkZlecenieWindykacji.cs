using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class InkZlecenieWindykacji
{
    public int InkzId { get; set; }

    public string InkzGuid { get; set; } = null!;

    public int? InkzIdDokumentu { get; set; }

    public int InkzStatus { get; set; }

    public DateTime? InkzDataPobraniaStatusu { get; set; }
}
