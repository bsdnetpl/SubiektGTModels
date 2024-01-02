using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RozRozszerzenieSql
{
    public int RozsId { get; set; }

    public int RozsIdKomponentuWzorcowego { get; set; }

    public string RozsNazwa { get; set; } = null!;

    public string RozsPolecenie { get; set; } = null!;

    public bool RozsMultiwybor { get; set; }

    public string? RozsKomunikat { get; set; }

    public bool RozsOdswiezanie { get; set; }

    public string RozsTytulOknaParametrow { get; set; } = null!;

    public virtual UiModul RozsIdKomponentuWzorcowegoNavigation { get; set; } = null!;
}
