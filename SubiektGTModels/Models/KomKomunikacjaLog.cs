using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KomKomunikacjaLog
{
    public int LkId { get; set; }

    public int LkIdKomunikacji { get; set; }

    public string LkTypDok { get; set; } = null!;

    public string LkDokument { get; set; } = null!;

    public string LkBlad { get; set; } = null!;

    public string LkUwagi { get; set; } = null!;

    public int LkNrBledu { get; set; }

    public virtual KomKomPrzeprowadzona LkIdKomunikacjiNavigation { get; set; } = null!;
}
