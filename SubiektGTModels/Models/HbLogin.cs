using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class HbLogin
{
    public int HblId { get; set; }

    public int HblIdRachunku { get; set; }

    public int HblIdUzytkownia { get; set; }

    public int HblTrybLogowania { get; set; }

    public string HblLogin { get; set; } = null!;

    public string? HblCertyfikatHash { get; set; }

    public virtual RbRachBankowy HblIdRachunkuNavigation { get; set; } = null!;

    public virtual PdUzytkownik HblIdUzytkowniaNavigation { get; set; } = null!;
}
