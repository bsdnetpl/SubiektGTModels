using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class SlCrmpodTypZadanium
{
    public int PtzId { get; set; }

    public int PtzZadanie { get; set; }

    public string PtzNazwa { get; set; } = null!;

    public virtual ICollection<SlSzablonDzialanium> SlSzablonDzialania { get; set; } = new List<SlSzablonDzialanium>();
}
