using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiModulPowiazany
{
    public int UimpId { get; set; }

    public int UimpIdModulu { get; set; }

    public int UimpTyp { get; set; }

    public int UimpIdObiektu { get; set; }

    public int UimpPozycja { get; set; }

    public int UimpStyl { get; set; }

    public string UimpNapis { get; set; } = null!;

    public virtual UiModul UimpIdModuluNavigation { get; set; } = null!;
}
