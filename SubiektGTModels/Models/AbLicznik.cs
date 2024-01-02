using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class AbLicznik
{
    public int AblId { get; set; }

    public int AblWartosc { get; set; }

    public int AblInterwal { get; set; }

    public int AblDniPrzed { get; set; }

    public int AblDniPo { get; set; }
}
