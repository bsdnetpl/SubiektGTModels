using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SySyncCmdResponse
{
    public int SycrId { get; set; }

    public string SycrPackageId { get; set; } = null!;

    public int SycrDivisionId { get; set; }

    public string SycrResponse { get; set; } = null!;

    public DateTime SycrResponseDate { get; set; }
}
