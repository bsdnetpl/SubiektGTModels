using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdUczestnik
{
    public int ZdkId { get; set; }

    public int ZdkIdZadania { get; set; }

    public int ZdkIdKlienta { get; set; }

    public int ZdkRodzaj { get; set; }

    public bool ZdkPrzypomniane { get; set; }

    public DateTime? ZdkNastepnePrzypomnienie { get; set; }

    public DateTime? ZdkWystapienieDoPrzypomnienia { get; set; }

    public virtual AdrEwid ZdkIdKlientaNavigation { get; set; } = null!;

    public virtual ZdZadanie ZdkIdZadaniaNavigation { get; set; } = null!;
}
