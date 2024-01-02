using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class NzWyciagBankowyOperacjaBankowa
{
    public int WboId { get; set; }

    public int WboIdWb { get; set; }

    public int WboIdOb { get; set; }

    public string WboTytulem { get; set; } = null!;

    public virtual NzFinanse WboIdObNavigation { get; set; } = null!;

    public virtual NzWyciagBankowy WboIdWbNavigation { get; set; } = null!;
}
