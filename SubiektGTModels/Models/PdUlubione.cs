using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUlubione
{
    public int UlId { get; set; }

    public int UlIdUzytkownika { get; set; }

    public int UlIdElementu { get; set; }

    public int UlRodzajElementu { get; set; }

    public virtual PdUzytkownik UlIdUzytkownikaNavigation { get; set; } = null!;
}
