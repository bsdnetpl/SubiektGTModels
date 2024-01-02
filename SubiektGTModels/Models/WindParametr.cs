using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WindParametr
{
    public int WpaId { get; set; }

    public int WpaRodzajDzialaniaWezwanie { get; set; }

    public int WpaRodzajDzialaniaNota { get; set; }

    public int? WpaSzablonDzialanie { get; set; }

    public int? WpaSzablonNota { get; set; }

    public virtual SlSzablonDzialanium? WpaSzablonDzialanieNavigation { get; set; }

    public virtual SlSzablonDzialanium? WpaSzablonNotaNavigation { get; set; }
}
