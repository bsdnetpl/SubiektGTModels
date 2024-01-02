using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class FoObiektDefinicja
{
    public int FodId { get; set; }

    public string FodNazwa { get; set; } = null!;

    public string FodTabela { get; set; } = null!;

    public string FodTabelaParametr { get; set; } = null!;

    public int FodIdModulu { get; set; }

    public string FodTytulModulu { get; set; } = null!;

    public int FodPolaWlasneTyp { get; set; }

    public int FodFlagiWlasneTyp { get; set; }

    public int FodWydrukTyp { get; set; }

    public int FodParTyp { get; set; }

    public int FodUpidDodaj { get; set; }

    public int FodUpidPopraw { get; set; }

    public int FodUpidPokaz { get; set; }

    public int FodUpidUsun { get; set; }

    public int FodUpidDrukuj { get; set; }

    public int FodTypKontekstu { get; set; }

    public int FodBiblDokTyp { get; set; }

    public int FodUpidBiblDok { get; set; }

    public int FodUpidBiblDokEdycja { get; set; }

    public int FodUpidBiblDokUsun { get; set; }

    public int FodUpidBiblDokDoei { get; set; }

    public int FodUpidBiblDokBlokady { get; set; }

    public int? FodFormatNumeracji { get; set; }

    public string FodIdentyfikator { get; set; } = null!;

    public int FodTypObiektu { get; set; }

    public bool? FodPokazLicznik { get; set; }

    public bool FodKomponentWielogridowy { get; set; }

    public virtual ICollection<FoObiektZakladka> FoObiektZakladkas { get; set; } = new List<FoObiektZakladka>();
}
