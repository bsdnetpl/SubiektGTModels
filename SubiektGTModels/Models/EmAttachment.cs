using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmAttachment
{
    public int EtId { get; set; }

    public int EtEmailId { get; set; }

    public string EtFilename { get; set; } = null!;

    public string EtFilepath { get; set; } = null!;
}
