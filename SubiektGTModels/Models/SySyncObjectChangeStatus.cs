using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SySyncObjectChangeStatus
{
    public int SycsId { get; set; }

    public int SycsChangeId { get; set; }

    public int SycsDivisionId { get; set; }

    public int SycsSyncStatus { get; set; }

    public DateTime? SycsSyncDate { get; set; }

    public int SycsConfirmationStatus { get; set; }

    public DateTime? SycsConfirmationDate { get; set; }

    public string? SycsConfirmationDetails { get; set; }
}
