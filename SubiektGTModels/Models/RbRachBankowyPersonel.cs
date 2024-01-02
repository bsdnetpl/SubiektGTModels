using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RbRachBankowyPersonel
{
    public int RbeId { get; set; }

    public int RbeIdRachunku { get; set; }

    public int RbeIdPersonelu { get; set; }

    public bool RbeSynchronizacja { get; set; }

    public int RbeSynchMinuty { get; set; }

    public bool RbeSynchWczasie { get; set; }

    public int RbeSynchOd { get; set; }

    public int RbeSynchDo { get; set; }

    public int RbeTrybLogowania { get; set; }

    public string? RbeLogin { get; set; }

    public string RbeCertyfikatHash { get; set; } = null!;

    public bool RbeBezLoginu { get; set; }

    public string RbeCertyfikatHashAutoryzacyjny { get; set; } = null!;

    public virtual PdUzytkownik RbeIdPersoneluNavigation { get; set; } = null!;

    public virtual RbRachBankowy RbeIdRachunkuNavigation { get; set; } = null!;
}
