using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbIdent
{
    public int HbiId { get; set; }

    public int HbiIdPrzedrostka { get; set; }

    public int HbiIdTransakcji { get; set; }

    public virtual HbPrzedrostekHist HbiIdPrzedrostkaNavigation { get; set; } = null!;
}
