using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuOpisy
{
    public int SioId { get; set; }

    public int SioIdSchematu { get; set; }

    public int SioTypOpisu { get; set; }

    public int SioZrodloOpisu { get; set; }

    public string? SioTrescOpisu { get; set; }

    public int? SioIdSlOpisOperacji { get; set; }

    public int? SioIdSlTrescOperacji { get; set; }

    public virtual ImSchematImportu SioIdSchematuNavigation { get; set; } = null!;
}
