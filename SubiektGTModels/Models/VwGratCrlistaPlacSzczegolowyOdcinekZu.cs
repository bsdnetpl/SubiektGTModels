using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class VwGratCrlistaPlacSzczegolowyOdcinekZu
{
    public int IdWyplaty { get; set; }

    public decimal PodstUbEmerRent { get; set; }

    public decimal PodstUbChorWyp { get; set; }

    public decimal ZusUbEmeryt1prac { get; set; }

    public decimal ZusUbEmeryt1firma { get; set; }

    public decimal ZusUbEmeryt2prac { get; set; }

    public decimal ZusUbRentowePrac { get; set; }

    public decimal ZusUbRentoweFirma { get; set; }

    public decimal ZusUbChorobowePrac { get; set; }

    public decimal ZusUbWypFirma { get; set; }

    public decimal Fp { get; set; }

    public decimal Fgsp { get; set; }

    public decimal Fep { get; set; }
}
