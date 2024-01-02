using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbSkladnikAbsencja
{
    public int SpaId { get; set; }

    public int SpaIdSkladnika { get; set; }

    public int SpaTypAbsencji { get; set; }

    public bool SpaPomniejszaj { get; set; }

    public bool SpaUwzglPodstEmRe { get; set; }

    public bool SpaUwzglPodstChWy { get; set; }

    public bool SpaUwzglKwotaChor { get; set; }

    public bool SpaUwzglPodstZdr { get; set; }

    public virtual PlbSkladnik SpaIdSkladnikaNavigation { get; set; } = null!;
}
