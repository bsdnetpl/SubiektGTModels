using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuPozDekretu
{
    public int SidId { get; set; }

    public int SidIdSchematImportu { get; set; }

    public int SidIdZrodloOpisu { get; set; }

    public string SidOpisUzytkownika { get; set; } = null!;

    public int? SidIdOpisu { get; set; }

    public string SidNrKonta { get; set; } = null!;

    public int SidStrona { get; set; }

    public int SidTypKwoty { get; set; }

    public int? SidIdKwoty { get; set; }

    public int? SidIdKwotyUzytkownika { get; set; }

    public int? SidIdSkladnikaPlacowego { get; set; }

    public int? SidIdCenyDoPrzeliczen { get; set; }

    public int? SidIdStawkiVat { get; set; }

    public decimal SidProcentKwoty { get; set; }

    public int? SidIdKartotekiPowiazanej { get; set; }

    public int SidPos { get; set; }

    public int SidTypWiersza { get; set; }

    public int? SidIdTresciOperacji { get; set; }

    public int? SidIdKategoriiPozycji { get; set; }

    public virtual SlKategorium? SidIdKategoriiPozycjiNavigation { get; set; }

    public virtual ImSchematImportuKwotyUzytkownika? SidIdKwotyUzytkownikaNavigation { get; set; }

    public virtual SlOpi? SidIdOpisuNavigation { get; set; }

    public virtual ImSchematImportu SidIdSchematImportuNavigation { get; set; } = null!;

    public virtual PlbSkladnik? SidIdSkladnikaPlacowegoNavigation { get; set; }

    public virtual SlStawkaVat? SidIdStawkiVatNavigation { get; set; }

    public virtual SlTresc? SidIdTresciOperacjiNavigation { get; set; }
}
