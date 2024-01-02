using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UfDzialGrupa
{
    public int UdgIdKonfiguracja { get; set; }

    public int UdgIdDzialGrupaUf { get; set; }

    public int UdgIdGrupaSb { get; set; }

    public int UdgIdVatUf { get; set; }

    public virtual UfKonfiguracja UdgIdKonfiguracjaNavigation { get; set; } = null!;
}
