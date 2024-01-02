using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ExSciezkaDomyslna
{
    public int ExId { get; set; }

    public int ExRodzaj { get; set; }

    public string ExNazwaKomputera { get; set; } = null!;

    public int ExIdUzytkownika { get; set; }

    public string ExSciezka { get; set; } = null!;
}
