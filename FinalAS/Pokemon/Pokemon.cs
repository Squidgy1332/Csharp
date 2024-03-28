using System;
using System.Collections.Generic;

namespace Pokemon;

public partial class Pokemon
{
    public ulong Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type1 { get; set; } = null!;

    public string? Type2 { get; set; }

    public string Ability1 { get; set; } = null!;

    public string? Ability2 { get; set; }

    public string? HiddenAbility { get; set; }
}
