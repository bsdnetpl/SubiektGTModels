using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DokDokumentDefiniowalnyOperacja
{
    public int DdoIdDd { get; set; }

    public int DdoIdUio { get; set; }

    public int? DdoTypOperacji { get; set; }

    public virtual DokDokumentDefiniowalny DdoIdDdNavigation { get; set; } = null!;

    public virtual UiOperacja DdoIdUioNavigation { get; set; } = null!;
}
