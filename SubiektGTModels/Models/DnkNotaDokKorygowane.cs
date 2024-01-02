using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DnkNotaDokKorygowane
{
    public int DnkdId { get; set; }

    public int DnkdIdNota { get; set; }

    public int DnkdIdDok { get; set; }

    public virtual DnkNotaKorygujaca DnkdIdNotaNavigation { get; set; } = null!;
}
