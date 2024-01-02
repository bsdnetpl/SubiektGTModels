using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUzytkOkre
{
    public int UzoIdUzytkownika { get; set; }

    public int? UzoIdOkresu { get; set; }

    public virtual PdOkre? UzoIdOkresuNavigation { get; set; }

    public virtual PdUzytkownik UzoIdUzytkownikaNavigation { get; set; } = null!;
}
