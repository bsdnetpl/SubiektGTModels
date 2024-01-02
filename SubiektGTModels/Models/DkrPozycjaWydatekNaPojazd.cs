using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrPozycjaWydatekNaPojazd
{
    public int DkpwIdPozycja { get; set; }

    public int DkpwIdWydatek { get; set; }

    public virtual DkrPozycja DkpwIdPozycjaNavigation { get; set; } = null!;

    public virtual DkrWydatekNaPojazd DkpwIdWydatekNavigation { get; set; } = null!;
}
