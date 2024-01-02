using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlZespolPrac
{
    public int SlzpId { get; set; }

    public string SlzpNazwa { get; set; } = null!;

    public virtual ICollection<PlbPracownikZespol> PlbPracownikZespols { get; set; } = new List<PlbPracownikZespol>();
}
