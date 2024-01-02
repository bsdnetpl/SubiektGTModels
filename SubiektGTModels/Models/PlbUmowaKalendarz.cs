using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbUmowaKalendarz
{
    public int UkId { get; set; }

    public int UkIdUmowy { get; set; }

    public int UkIdKalendarza { get; set; }

    public DateTime UkDataOd { get; set; }

    public DateTime? UkDataDo { get; set; }

    public int UkWymiarLicznik { get; set; }

    public int UkWymiarMianownik { get; set; }

    public int UkWymiarDobowy { get; set; }

    public int UkDodatekZaNadgodzinyPo { get; set; }

    public virtual PlbUmowa UkIdUmowyNavigation { get; set; } = null!;
}
