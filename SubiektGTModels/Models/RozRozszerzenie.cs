using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RozRozszerzenie
{
    public int RozId { get; set; }

    public string RozGuid { get; set; } = null!;

    public string RozNazwa { get; set; } = null!;

    public byte[]? RozSkryptPrzedInstalacja { get; set; }

    public byte[]? RozSkryptPoInstalacji { get; set; }

    public byte[]? RozSkryptPrzedAktualizacja { get; set; }

    public byte[]? RozSkryptPoAktualizacji { get; set; }

    public virtual ICollection<RozPlikRozszerzenium> RozPlikRozszerzenia { get; set; } = new List<RozPlikRozszerzenium>();
}
