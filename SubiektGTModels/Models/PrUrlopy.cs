using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PrUrlopy
{
    public int PurId { get; set; }

    public int PurIdPracownika { get; set; }

    public int PurRok { get; set; }

    public int PurZaleglyUrlop { get; set; }

    public int PurWymiarUrlopu { get; set; }

    public virtual PrPracownik PurIdPracownikaNavigation { get; set; } = null!;
}
