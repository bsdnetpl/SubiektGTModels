using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZdAlarmyRezerwacja
{
    public int ZdrdId { get; set; }

    public int ZdrdIdDzialania { get; set; }

    public DateTime ZdrdData { get; set; }

    public string ZdrdInstancja { get; set; } = null!;

    public virtual ZdZadanie ZdrdIdDzialaniaNavigation { get; set; } = null!;
}
