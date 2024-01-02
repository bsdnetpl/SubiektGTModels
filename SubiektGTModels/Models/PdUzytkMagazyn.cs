using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUzytkMagazyn
{
    public int UzmIdUzytkownika { get; set; }

    public int? UzmIdMagazynu { get; set; }

    public virtual SlMagazyn? UzmIdMagazynuNavigation { get; set; }

    public virtual PdUzytkownik UzmIdUzytkownikaNavigation { get; set; } = null!;
}
