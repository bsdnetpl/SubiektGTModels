using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhListaFiltr
{
    public int LkfId { get; set; }

    public int LkfIdLista { get; set; }

    public byte[]? LkfFiltr { get; set; }

    public virtual KhListum LkfIdListaNavigation { get; set; } = null!;
}
