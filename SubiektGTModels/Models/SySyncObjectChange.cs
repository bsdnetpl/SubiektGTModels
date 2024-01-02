using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SySyncObjectChange
{
    public int SycId { get; set; }

    public int SycObjectId { get; set; }

    public int SycObjectType { get; set; }

    public int? SycObjectTypeEx { get; set; }

    public int SycChangeType { get; set; }

    public DateTime SycChangeDate { get; set; }

    public int SycChangeOwner { get; set; }

    public string SycSyncId { get; set; } = null!;

    public string? SycPackageId { get; set; }

    public bool SycBlockSync { get; set; }
}
