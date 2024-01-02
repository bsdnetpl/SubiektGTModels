using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlOddzialKasa
{
    public int SokId { get; set; }

    public int SokIdOddzial { get; set; }

    public int SokIdKasa { get; set; }

    public virtual DksKasa SokIdKasaNavigation { get; set; } = null!;

    public virtual SlOddzialy SokIdOddzialNavigation { get; set; } = null!;
}
