using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FnxNewsletter
{
    public int MtId { get; set; }

    public int? MtSubiektId { get; set; }

    public int? MtFeniksId { get; set; }

    public int? MtDirection { get; set; }

    public string? MtEmail { get; set; }

    public bool? MtDoSubscribe { get; set; }
}
