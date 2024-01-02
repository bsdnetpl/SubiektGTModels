using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PlbListaPlac
{
    public int LpId { get; set; }

    public int? LpIdDefinicjiLp { get; set; }

    public bool LpAutomatyczna { get; set; }

    public string LpTytul { get; set; } = null!;

    public string LpNumer { get; set; } = null!;

    public DateTime LpMiesiac { get; set; }

    public DateTime LpDataWyplaty { get; set; }

    public DateTime LpDataSkladek { get; set; }

    public DateTime LpDataZaliczek { get; set; }

    public int? LpIdKategorii { get; set; }

    public int LpStatusKsiegowyLp { get; set; }

    public int LpStatusKsiegowySkladki { get; set; }

    public int LpStatusKsiegowyZaliczki { get; set; }

    public bool LpZatwierdzona { get; set; }

    public DateTime? LpZmianaDatyWyplatyData { get; set; }

    public int? LpZmianaDatyWyplatyKto { get; set; }

    public bool LpCzyPrzychodZaInnyRok { get; set; }

    public int? LpRokPrzychodu { get; set; }

    public DateTime LpDataWplatyPpk { get; set; }

    public int LpStatusKsiegowyPpk { get; set; }

    public virtual SlKategorium? LpIdKategoriiNavigation { get; set; }

    public virtual PdUzytkownik? LpZmianaDatyWyplatyKtoNavigation { get; set; }

    public virtual ICollection<PlbWyplatum> PlbWyplata { get; set; } = new List<PlbWyplatum>();
}
