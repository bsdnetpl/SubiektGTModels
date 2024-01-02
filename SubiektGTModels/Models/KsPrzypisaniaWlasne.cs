using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KsPrzypisaniaWlasne
{
    public int KspwId { get; set; }

    public int KspwTypObiektu { get; set; }

    public int KspwIdObiektu { get; set; }

    public int KspwIdWpisu { get; set; }

    public virtual SlWlasny KspwIdWpisuNavigation { get; set; } = null!;

    public virtual GtObiekt KspwTypObiektuNavigation { get; set; } = null!;
}
