using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class GrFormatowanieUzytkownik
{
    public int GrfwuIdFormatowania { get; set; }

    public int GrfwuIdUzytkownika { get; set; }

    public virtual GrFormatowanie GrfwuIdFormatowaniaNavigation { get; set; } = null!;

    public virtual PdUzytkownik GrfwuIdUzytkownikaNavigation { get; set; } = null!;
}
