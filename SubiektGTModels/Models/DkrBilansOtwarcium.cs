using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrBilansOtwarcium
{
    public int BoId { get; set; }

    public int BoIdRoku { get; set; }

    public bool BoZatwierdzony { get; set; }

    public bool BoKorygowany { get; set; }

    public DateTime? BoData { get; set; }

    public int? BoIdUzytkownik { get; set; }

    public DateTime? BoDataZatwierdzenia { get; set; }

    public int? BoIdZatwierdzajacy { get; set; }

    public DateTime? BoDataKorekty { get; set; }

    public int? BoIdKorygujacy { get; set; }

    public virtual PdUzytkownik? BoIdKorygujacyNavigation { get; set; }

    public virtual PdRokObrotowy BoIdRokuNavigation { get; set; } = null!;

    public virtual PdUzytkownik? BoIdUzytkownikNavigation { get; set; }

    public virtual PdUzytkownik? BoIdZatwierdzajacyNavigation { get; set; }

    public virtual ICollection<DkrBilansOtwarciaZmiana> DkrBilansOtwarciaZmianas { get; set; } = new List<DkrBilansOtwarciaZmiana>();
}
