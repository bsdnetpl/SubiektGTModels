using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VatPrzypomnienium
{
    public int PrzyId { get; set; }

    public int PrzyStatusPrzypomnieniaZmianyVat { get; set; }

    public DateTime? PrzyDataPonownegoPrzypomnienia { get; set; }

    public int PrzyProgram { get; set; }
}
