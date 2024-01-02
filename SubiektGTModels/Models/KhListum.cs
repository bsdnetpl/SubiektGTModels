using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhListum
{
    public int LkId { get; set; }

    public int LkTyp { get; set; }

    public string LkNazwa { get; set; } = null!;

    public string LkOpis { get; set; } = null!;

    public int LkIdPersonel { get; set; }

    public bool LkPubliczna { get; set; }

    public virtual KhListaFiltr? KhListaFiltr { get; set; }

    public virtual ICollection<KhListaKh> KhListaKhs { get; set; } = new List<KhListaKh>();

    public virtual PdUzytkownik LkIdPersonelNavigation { get; set; } = null!;
}
