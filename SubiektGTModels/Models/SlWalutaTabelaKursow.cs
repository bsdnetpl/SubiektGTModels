using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlWalutaTabelaKursow
{
    public int WtkId { get; set; }

    public DateTime WtkData { get; set; }

    public int WtkIdBanku { get; set; }

    public string WtkSymbol { get; set; } = null!;

    public string WtkNazwa { get; set; } = null!;

    public virtual ICollection<SlWalutaKur> SlWalutaKurs { get; set; } = new List<SlWalutaKur>();

    public virtual SlWalutaBank WtkIdBankuNavigation { get; set; } = null!;
}
