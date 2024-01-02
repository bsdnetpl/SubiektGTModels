using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RozZestKontekstowe
{
    public int RozzkId { get; set; }

    public int RozzkIdKomponentuWzorcowego { get; set; }

    public string RozzkNazwa { get; set; } = null!;

    public string RozzkTytulOkna { get; set; } = null!;

    public bool RozzkMultiwybor { get; set; }

    public virtual ICollection<RozZestKontekstoweZakladka> RozZestKontekstoweZakladkas { get; set; } = new List<RozZestKontekstoweZakladka>();

    public virtual UiModul RozzkIdKomponentuWzorcowegoNavigation { get; set; } = null!;
}
