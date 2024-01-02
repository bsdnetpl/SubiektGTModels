using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class EdZfss
{
    public int ZfsId { get; set; }

    public int ZfsRok { get; set; }

    public int ZfsTyp { get; set; }

    public DateTime ZfsData { get; set; }

    public decimal ZfsKwota { get; set; }

    public string ZfsOpis { get; set; } = null!;

    public string ZfsOdbiorca { get; set; } = null!;

    public int? ZfsIdPracownika { get; set; }

    public int? ZfsIdInstytucji { get; set; }

    public virtual IsInstytucja? ZfsIdInstytucjiNavigation { get; set; }

    public virtual PrPracownik? ZfsIdPracownikaNavigation { get; set; }
}
