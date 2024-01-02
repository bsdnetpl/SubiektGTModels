using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class UiModulPosdok
{
    public int UiposdId { get; set; }

    public int UiposdModulPosid { get; set; }

    public int UiposdTyp { get; set; }

    public int UiposdPodtyp { get; set; }

    public int UiposdDefiniowalnyId { get; set; }

    public bool UiposdWidoczny { get; set; }

    public int UiposdPozycja { get; set; }

    public bool UiposdNiedostepnyJakoDomyslny { get; set; }
}
