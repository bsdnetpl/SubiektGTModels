using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrWyszukiwanieWlasne
{
    public int GrwwId { get; set; }

    public int GrwwIdGrida { get; set; }

    public string GrwwSqlSelectId { get; set; } = null!;

    public string GrwwSqlWhere { get; set; } = null!;

    public string GrwwTekstTytul { get; set; } = null!;

    public string GrwwTekstWpis { get; set; } = null!;

    public bool GrwwLaczWarunekAnd { get; set; }

    public virtual GrGrid GrwwIdGridaNavigation { get; set; } = null!;
}
