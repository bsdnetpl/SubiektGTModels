using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrGiodo
{
    public int PgiId { get; set; }

    public int PgiIdPracownika { get; set; }

    public int PgiIdUzytkownika { get; set; }

    public DateTime PgiCzas { get; set; }

    public int PgiOperacja { get; set; }

    public virtual PrPracownik PgiIdPracownikaNavigation { get; set; } = null!;

    public virtual PdUzytkownik PgiIdUzytkownikaNavigation { get; set; } = null!;
}
