using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwEmailTempl
{
    public int EtId { get; set; }

    public string EtName { get; set; } = null!;

    public bool EtHtml { get; set; }

    public string EtSubject { get; set; } = null!;
}
