using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DkrWydatekNaPojazd
{
    public int DkwpId { get; set; }

    public int DkwpMalyPojazd { get; set; }

    public int DkwpPrzypadekSzczegolnyPit { get; set; }

    public int DkwpNettoBrutto { get; set; }

    public decimal DkwpWartoscZfaktury { get; set; }

    public int DkwpIdStawkiVat { get; set; }

    public decimal DkwpNetto { get; set; }

    public decimal DkwpNettoNpo { get; set; }

    public decimal DkwpVat { get; set; }

    public decimal DkwpVatNpo { get; set; }

    public virtual ICollection<DkrPozycjaWydatekNaPojazd> DkrPozycjaWydatekNaPojazds { get; set; } = new List<DkrPozycjaWydatekNaPojazd>();

    public virtual SlStawkaVat DkwpIdStawkiVatNavigation { get; set; } = null!;
}
