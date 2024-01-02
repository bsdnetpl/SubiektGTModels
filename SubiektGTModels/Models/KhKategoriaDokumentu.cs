using System;
using System.Collections.Generic;

namespace SubiektGTModels.Models;

public partial class KhKategoriaDokumentu
{
    public int KhkdId { get; set; }

    public int KhkdKontrahentId { get; set; }

    public int KhkdDokTypEx { get; set; }

    public int? KhkdKategoriaId { get; set; }

    public bool? KhkdKategoriaIdMode { get; set; }

    public virtual SlKategorium? KhkdKategoria { get; set; }

    public virtual KhKontrahent KhkdKontrahent { get; set; } = null!;
}
