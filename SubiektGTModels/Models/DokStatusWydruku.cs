using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokStatusWydruku
{
    public int DswId { get; set; }

    public int DswIdDokumentu { get; set; }

    public int DswIdWzorca { get; set; }

    public int DswMetodaWydruku { get; set; }

    public virtual DokDokument DswIdDokumentuNavigation { get; set; } = null!;

    public virtual WyWzorzec DswIdWzorcaNavigation { get; set; } = null!;
}
