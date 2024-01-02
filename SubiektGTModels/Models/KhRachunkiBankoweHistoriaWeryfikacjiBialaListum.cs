using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhRachunkiBankoweHistoriaWeryfikacjiBialaListum
{
    public int KhrId { get; set; }

    public string KhrNumerRachunku { get; set; } = null!;

    public int? KhrIdRachunek { get; set; }

    public string KhrNip { get; set; } = null!;

    public DateTime KhrDataWeryfikacji { get; set; }

    public bool KhrNaBialejLiscie { get; set; }

    public int KhrIdUzytkownik { get; set; }

    public string KhrIdentyfikatorZapytania { get; set; } = null!;

    public int? KhrIdKontrahent { get; set; }

    public virtual KhKontrahent? KhrIdKontrahentNavigation { get; set; }

    public virtual RbRachBankowy? KhrIdRachunekNavigation { get; set; }

    public virtual PdUzytkownik KhrIdUzytkownikNavigation { get; set; } = null!;
}
