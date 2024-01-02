using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWlasny
{
    public int SwId { get; set; }

    public int SwSlownikId { get; set; }

    public string SwNazwa { get; set; } = null!;

    public virtual ICollection<KsPrzypisaniaWlasne> KsPrzypisaniaWlasnes { get; set; } = new List<KsPrzypisaniaWlasne>();

    public virtual SlSlownik SwSlownik { get; set; } = null!;
}
