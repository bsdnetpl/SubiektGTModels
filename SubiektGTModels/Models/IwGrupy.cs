using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class IwGrupy
{
    public int IwgId { get; set; }

    public int IwgIdGrupy { get; set; }

    public int IwgDoIwId { get; set; }

    public virtual IwDokument IwgDoIw { get; set; } = null!;

    public virtual SlGrupaTw IwgIdGrupyNavigation { get; set; } = null!;
}
