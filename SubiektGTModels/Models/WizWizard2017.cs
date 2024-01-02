using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class WizWizard2017
{
    public int WwId { get; set; }

    public string? WwKrok { get; set; }

    public int? WwWersja { get; set; }

    public DateTime? WwData { get; set; }

    public DateTime? WwPrzypomnijData { get; set; }

    public int? WwPrzypomnijStatus { get; set; }
}
