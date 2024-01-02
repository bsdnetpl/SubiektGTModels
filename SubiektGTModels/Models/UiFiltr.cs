using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiFiltr
{
    public int UilId { get; set; }

    public int UilIdModulu { get; set; }

    public string UilNazwa { get; set; } = null!;

    public string UilSql { get; set; } = null!;

    public virtual UiModul UilIdModuluNavigation { get; set; } = null!;
}
