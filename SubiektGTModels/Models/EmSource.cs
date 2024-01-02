using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmSource
{
    public int EsId { get; set; }

    public int EsEmailId { get; set; }

    public string? EsSource { get; set; }

    public byte[]? EsSourceData { get; set; }

    public byte[]? EsSourceNoAtt { get; set; }

    public int? EsSize { get; set; }
}
