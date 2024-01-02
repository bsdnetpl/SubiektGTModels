using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ImSchematImportuZpiK
{
    public int SipkId { get; set; }

    public int SipkIdSchematImportu { get; set; }

    public int? SipkKolumna { get; set; }

    public int? SipkImportWartosci { get; set; }

    public int? SipkZakresArt17 { get; set; }

    public bool? SipkWydPokrZdochZwoln { get; set; }

    public bool? SipkWydPokrZdochZwolnZlatUb { get; set; }

    public virtual ImSchematImportu SipkIdSchematImportuNavigation { get; set; } = null!;
}
