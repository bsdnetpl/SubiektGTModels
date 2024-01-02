using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlKodRodzajuOpakowanTwAkcyzowych
{
    public int SlkroId { get; set; }

    public string SlkroWartosc { get; set; } = null!;

    public bool SlkroAktywna { get; set; }

    public string SlkroWartoscXml { get; set; } = null!;

    public virtual ICollection<TwOpakowaniaAkcyzowe> TwOpakowaniaAkcyzowes { get; set; } = new List<TwOpakowaniaAkcyzowe>();
}
