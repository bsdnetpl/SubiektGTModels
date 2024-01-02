using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhListaKh
{
    public int LkkId { get; set; }

    public int LkkIdLista { get; set; }

    public int LkkIdKlient { get; set; }

    public virtual AdrEwid LkkIdKlientNavigation { get; set; } = null!;

    public virtual KhListum LkkIdListaNavigation { get; set; } = null!;
}
