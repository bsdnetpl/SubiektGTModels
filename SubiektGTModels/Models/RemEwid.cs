using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class RemEwid
{
    public int RemId { get; set; }

    public DateTime RemData { get; set; }

    public int RemZaksiegowany { get; set; }

    public int? RemIdKsiegi { get; set; }

    public decimal RemWartosc { get; set; }

    public string RemOpis { get; set; } = null!;

    public bool RemNaZaliczce { get; set; }

    public decimal RemWartoscKorektyKup { get; set; }

    public int? RemPowiazanyId { get; set; }

    public virtual KprKsiega? RemIdKsiegiNavigation { get; set; }

    public virtual ICollection<RemPozycja> RemPozycjas { get; set; } = new List<RemPozycja>();
}
