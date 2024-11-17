using System;
using System.Collections.Generic;

namespace BorNaplo;

public partial class BorNaplo
{
    public int Id { get; set; }

    public string? BorNev { get; set; }

    public string? BorFajta { get; set; }

    public DateOnly? EvJarat { get; set; }

    public string? SzoloFajta { get; set; }

    public string? PinceszetNev { get; set; }

    public DateTime? KostolasIdopont { get; set; }

    public string? KostolasHelyszin { get; set; }

    public string? RovidJellemzes { get; set; }

    public byte? Ertekeles { get; set; }
}
