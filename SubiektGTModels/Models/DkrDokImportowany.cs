using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrDokImportowany
{
    public int DiId { get; set; }

    public int DiIdDekretu { get; set; }

    public int DiTypDokumentu { get; set; }

    public int DiIdDokumentu { get; set; }

    public virtual DkrDokument DiIdDekretuNavigation { get; set; } = null!;
}
