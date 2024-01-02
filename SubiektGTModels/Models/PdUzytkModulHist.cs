using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdUzytkModulHist
{
    public int UzmhIdUzytkownika { get; set; }

    public int UzmhPozycja { get; set; }

    public int? UzmhIdModulu { get; set; }

    public Guid? UzmhClsid { get; set; }

    public string UzmhNazwa { get; set; } = null!;

    public bool UzmhAktywny { get; set; }

    public int UzmhTypKontekstu { get; set; }

    public string UzmhKontekst { get; set; } = null!;

    public string UzmhTytulStrony { get; set; } = null!;

    public string UzmhAdresStrony { get; set; } = null!;

    public virtual UiModul? UzmhIdModuluNavigation { get; set; }

    public virtual PdUzytkownik UzmhIdUzytkownikaNavigation { get; set; } = null!;
}
