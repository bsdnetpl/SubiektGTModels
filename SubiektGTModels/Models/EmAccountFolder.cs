using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EmAccountFolder
{
    public int EafId { get; set; }

    public int EafAccountId { get; set; }

    public string EafEntryId { get; set; } = null!;

    public bool EafOdbiorcza { get; set; }

    public string EafStoreId { get; set; } = null!;
}
