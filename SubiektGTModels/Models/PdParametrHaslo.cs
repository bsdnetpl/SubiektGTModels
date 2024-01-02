using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdParametrHaslo
{
    public int PhaId { get; set; }

    public int PhaDlugosc { get; set; }

    public bool PhaMaleLitery { get; set; }

    public bool PhaWielkieLitery { get; set; }

    public bool PhaCyfry { get; set; }

    public bool PhaZnakiSpecjalne { get; set; }

    public bool PhaZmiana { get; set; }

    public int PhaZmianaDni { get; set; }

    public int PhaParamEwidId { get; set; }

    public virtual ParEwid PhaParamEwid { get; set; } = null!;
}
