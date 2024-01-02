using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NetWiadomoscFlaga
{
    public int NefId { get; set; }

    public int NefIdWiadomosci { get; set; }

    public int NefIdUzytkownika { get; set; }

    public DateTime? NefDataPrzypomnienia { get; set; }

    public string NefWersjaOdczytania { get; set; } = null!;

    public bool NefPobrano { get; set; }
}
