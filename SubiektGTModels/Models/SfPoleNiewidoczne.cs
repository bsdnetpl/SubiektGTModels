using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SfPoleNiewidoczne
{
    public int SfpnIdRok { get; set; }

    public int SfpnIdPole { get; set; }

    public virtual SfPole SfpnIdPoleNavigation { get; set; } = null!;

    public virtual PdRokObrotowy SfpnIdRokNavigation { get; set; } = null!;
}
