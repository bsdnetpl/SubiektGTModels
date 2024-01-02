using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KwKartum
{
    public int KkwId { get; set; }

    public int KkwIdPracownika { get; set; }

    public DateTime KkwMiesiac { get; set; }

    public virtual PrPracownik KkwIdPracownikaNavigation { get; set; } = null!;

    public virtual ICollection<KwPozycja> KwPozycjas { get; set; } = new List<KwPozycja>();
}
