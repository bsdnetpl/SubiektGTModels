using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class TwZmiana
{
    public int ZtId { get; set; }

    public int ZtTowarId { get; set; }

    public DateTime? ZtZmianaSymbol { get; set; }

    public DateTime? ZtZmianaNazwa { get; set; }

    public DateTime? ZtZmianaOpis { get; set; }

    public DateTime? ZtZmianaOpisHtml { get; set; }

    public DateTime? ZtZmianaZdjecie { get; set; }

    public DateTime? ZtZmianaAdresWww { get; set; }

    public DateTime? ZtZmianaProducent { get; set; }

    public DateTime? ZtZmianaGrupa { get; set; }

    public DateTime? ZtZmianaCecha { get; set; }

    public DateTime? ZtZmianaCenaSprzedazy { get; set; }

    public DateTime? ZtZmianaStawkaVatsprzed { get; set; }

    public DateTime? ZtZmianaStanMinimalny { get; set; }

    public DateTime? ZtZmianaMasaTowaru { get; set; }

    public virtual TwTowar ZtTowar { get; set; } = null!;
}
