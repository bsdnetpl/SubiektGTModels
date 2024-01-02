using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuRodzajFaktury
{
    public int SirfId { get; set; }

    public int SirfIdSchematImportu { get; set; }

    public int SirfRodzajFaktury { get; set; }

    public virtual ImSchematImportu SirfIdSchematImportuNavigation { get; set; } = null!;
}
