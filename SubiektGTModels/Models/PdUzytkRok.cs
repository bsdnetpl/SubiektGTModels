using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUzytkRok
{
    public int UzrIdUzytkownika { get; set; }

    public int? UzrIdRoku { get; set; }

    public virtual PdRokObrotowy? UzrIdRokuNavigation { get; set; }

    public virtual PdUzytkownik UzrIdUzytkownikaNavigation { get; set; } = null!;
}
