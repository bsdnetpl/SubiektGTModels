using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrBadaniaOkresowe
{
    public int PboId { get; set; }

    public int PboIdPracownika { get; set; }

    public int PboIdBadania { get; set; }

    public DateTime PboDataWykonania { get; set; }

    public DateTime PboDataWaznosci { get; set; }

    public virtual SlBadanieOkresowe PboIdBadaniaNavigation { get; set; } = null!;

    public virtual PrPracownik PboIdPracownikaNavigation { get; set; } = null!;
}
