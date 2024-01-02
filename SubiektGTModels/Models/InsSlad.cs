using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class InsSlad
{
    public int SladId { get; set; }

    public int SladTypObiektu { get; set; }

    public int? SladIdObiektu { get; set; }

    public int SladZdarzenie { get; set; }

    public DateTime SladCzasZdarzenia { get; set; }

    public int SladIdUzytkownika { get; set; }

    public virtual PdUzytkownik SladIdUzytkownikaNavigation { get; set; } = null!;
}
