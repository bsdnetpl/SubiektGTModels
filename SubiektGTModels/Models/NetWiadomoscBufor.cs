using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NetWiadomoscBufor
{
    public int NebId { get; set; }

    public DateTime? NebData { get; set; }

    public string NebWersjaMin { get; set; } = null!;

    public string NebWersjaMax { get; set; } = null!;

    public byte[] NebWiadomosc { get; set; } = null!;
}
