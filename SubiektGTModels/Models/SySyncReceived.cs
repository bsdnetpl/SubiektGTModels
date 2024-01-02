using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SySyncReceived
{
    public int SyrId { get; set; }

    public byte[] SyrPackage { get; set; } = null!;

    public int SyrPackageType { get; set; }

    public DateTime SyrReceivedDate { get; set; }

    public int SyrType { get; set; }

    public int? SyrTypeEx { get; set; }

    public string SyrSyncId { get; set; } = null!;

    public int SyrChangeType { get; set; }

    public string? SyrError { get; set; }

    public int SyrDivisionId { get; set; }

    public string SyrPackageId { get; set; } = null!;

    public int? SyrSyncStatus { get; set; }

    public DateTime? SyrInternalDate { get; set; }

    public string? SyrInternalText { get; set; }

    public int? SyrRemoteId { get; set; }

    public DateTime? SyrErrorMailSentAt { get; set; }
}
