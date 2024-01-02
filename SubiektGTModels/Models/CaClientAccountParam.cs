using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class CaClientAccountParam
{
    public int CapId { get; set; }

    public byte[]? CapData { get; set; }

    public DateTime? CapPodlaczKontoInsertPrzypominaj { get; set; }
}
