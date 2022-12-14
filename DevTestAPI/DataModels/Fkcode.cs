using System;
using System.Collections.Generic;

namespace DevTestAPI.DataModels;

public partial class Fkcode
{
    public int Id { get; set; }

    public string Code { get; set; } = null!;

    public int CodeType { get; set; }

    public int? Version { get; set; }

    public virtual ICollection<ClaimFkcode> ClaimFkcodes { get; } = new List<ClaimFkcode>();
}
