using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrBilansOtwarciaZmiana
{
    public int BozId { get; set; }

    public int BozIdBo { get; set; }

    public int BozTyp { get; set; }

    public int BozIdModyfikowal { get; set; }

    public DateTime BozDataModyfikacji { get; set; }

    public string BozHid { get; set; } = null!;

    public virtual DkrBilansOtwarcium BozIdBoNavigation { get; set; } = null!;

    public virtual PdUzytkownik BozIdModyfikowalNavigation { get; set; } = null!;

    public virtual ICollection<DkrBilansOtwarciaZmianaSzczegoly> DkrBilansOtwarciaZmianaSzczegolies { get; set; } = new List<DkrBilansOtwarciaZmianaSzczegoly>();
}
