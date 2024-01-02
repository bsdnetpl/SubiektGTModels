using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlStawkaAkordowaProg
{
    public int SapId { get; set; }

    public int SapIdStawkiAkordowej { get; set; }

    public int SapLp { get; set; }

    public decimal SapProg { get; set; }

    public decimal SapWartosc { get; set; }
}
