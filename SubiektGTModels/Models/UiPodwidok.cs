using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiPodwidok
{
    public int UigId { get; set; }

    public int UigIdWidoku { get; set; }

    public int UigIdModulu { get; set; }

    public string UigNazwa { get; set; } = null!;

    public string UigKonfiguracja { get; set; } = null!;

    public virtual UiModul UigIdModuluNavigation { get; set; } = null!;
}
