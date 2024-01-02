using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class PdWspolnikSposobSkladka
{
    public int PwssId { get; set; }

    public int PwssIdWspolnika { get; set; }

    public DateTime? PwssOd { get; set; }

    public DateTime? PwssDo { get; set; }

    public int PwssTypSkladki { get; set; }

    public bool PwssSklUbezpEm { get; set; }

    public bool PwssSklUbezpRent { get; set; }

    public bool PwssSklUbezpChor { get; set; }

    public bool PwssSklUbezpWyp { get; set; }

    public bool PwssSklFp { get; set; }

    public bool PwssSklUbezpZdr { get; set; }

    public decimal? PwssRocznyPrzychod { get; set; }

    public int? PwssLiczbaDni { get; set; }

    public decimal? PwssMiesiecznyPrzychod { get; set; }

    public decimal? PwssWspolczynnik { get; set; }

    public decimal? PwssPodstawa { get; set; }

    public decimal? PwssRocznyDochod { get; set; }

    public decimal? PwssMiesiecznyDochod { get; set; }

    public int PwssTypSkladkiZdr { get; set; }

    public decimal? PwssPodstawaZdr { get; set; }

    public decimal? PwssRocznyPrzychodZdr { get; set; }

    public virtual PdWspolnik PwssIdWspolnikaNavigation { get; set; } = null!;
}
