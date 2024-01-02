using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiSkrotModul
{
    public int UisId { get; set; }

    public int UisIdModulu { get; set; }

    public int UisTypOperacji { get; set; }

    public int UisIdOperacji { get; set; }

    public int UisKlawisz { get; set; }

    public bool UisAlt { get; set; }

    public bool UisCtrl { get; set; }

    public bool UisShift { get; set; }

    public virtual UiModul UisIdModuluNavigation { get; set; } = null!;
}
