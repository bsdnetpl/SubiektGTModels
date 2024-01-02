using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class DeklPfron
{
    public int DpfId { get; set; }

    public int DpfIdDeklaracji { get; set; }

    public DateTime DpfData { get; set; }

    public decimal DpfZog { get; set; }

    public decimal DpfZs { get; set; }

    public decimal DpfZsp { get; set; }

    public decimal DpfZu { get; set; }

    public decimal DpfZup { get; set; }

    public decimal DpfZl { get; set; }

    public decimal DpfZb { get; set; }

    public decimal DpfZon { get; set; }

    public decimal DpfOzog { get; set; }

    public decimal DpfOzs { get; set; }

    public decimal DpfOzsp { get; set; }

    public decimal DpfOzu { get; set; }

    public decimal DpfOzup { get; set; }

    public decimal DpfOzl { get; set; }

    public decimal DpfOzb { get; set; }

    public decimal DpfOzon { get; set; }

    public virtual DeklEwid DpfIdDeklaracjiNavigation { get; set; } = null!;
}
