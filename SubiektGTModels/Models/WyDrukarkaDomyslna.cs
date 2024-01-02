using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WyDrukarkaDomyslna
{
    public int WydId { get; set; }

    public int WydWzorzecId { get; set; }

    public string WydNazwaKomputera { get; set; } = null!;

    public string WydNazwaDrukarki { get; set; } = null!;

    public virtual WyWzorzec WydWzorzec { get; set; } = null!;
}
