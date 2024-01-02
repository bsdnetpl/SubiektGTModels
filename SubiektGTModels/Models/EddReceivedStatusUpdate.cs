using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EddReceivedStatusUpdate
{
    public int EruId { get; set; }

    public int EruUpdateType { get; set; }

    public DateTime EruReceivedDate { get; set; }

    public string EruEddMessageId { get; set; } = null!;

    public int? EruSourceMailId { get; set; }

    public string? EruAssignedDdarc { get; set; }

    public int? EruInitialMatchingEddId { get; set; }

    public DateTime EruSentDate { get; set; }
}
