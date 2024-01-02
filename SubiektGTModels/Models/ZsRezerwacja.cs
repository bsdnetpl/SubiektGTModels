using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class ZsRezerwacja
{
    public int ZsrId { get; set; }

    public string ZsrTemat { get; set; } = null!;

    public int ZsrIdZasobu { get; set; }

    public int ZsrIdPersonel { get; set; }

    public DateTime ZsrPoczatek { get; set; }

    public DateTime ZsrKoniec { get; set; }

    public bool ZsrKolorZasobu { get; set; }

    public string? ZsrKolor { get; set; }

    public string? ZsrUwagi { get; set; }

    public string ZsrKlienci { get; set; } = null!;

    public virtual ICollection<ZsRezerwacjaUczestnik> ZsRezerwacjaUczestniks { get; set; } = new List<ZsRezerwacjaUczestnik>();

    public virtual PdUzytkownik ZsrIdPersonelNavigation { get; set; } = null!;

    public virtual ZsZasob ZsrIdZasobuNavigation { get; set; } = null!;
}
