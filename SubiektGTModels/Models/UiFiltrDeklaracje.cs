using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiFiltrDeklaracje
{
    public int UidId { get; set; }

    public int UidIdModul { get; set; }

    public string UidSql { get; set; } = null!;

    public virtual UiModul UidIdModulNavigation { get; set; } = null!;
}
