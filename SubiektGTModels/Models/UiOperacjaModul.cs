using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiOperacjaModul
{
    public int UiomId { get; set; }

    public int UiomIdOperacji { get; set; }

    public int UiomIdWzorcaModulu { get; set; }

    public virtual UiOperacja UiomIdOperacjiNavigation { get; set; } = null!;

    public virtual UiModul UiomIdWzorcaModuluNavigation { get; set; } = null!;
}
