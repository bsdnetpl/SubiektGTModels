using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NotNotatka
{
    public int NtId { get; set; }

    public int NtIdObiektu { get; set; }

    public int NtTypObiektu { get; set; }

    public DateTime NtData { get; set; }

    public string NtTresc { get; set; } = null!;

    public string NtOsoba { get; set; } = null!;

    public string NtTytul { get; set; } = null!;

    public byte[] NtTrescRtf { get; set; } = null!;
}
