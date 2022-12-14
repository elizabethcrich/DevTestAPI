using System;
using System.Collections.Generic;

namespace DevTestAPI.DataModels;

public partial class ClaimFkcode
{
    public int Id { get; set; }

    public int OrganizationId { get; set; }

    public int ExternalPersonId { get; set; }

    public int ExternalClaimId { get; set; }

    public int FkcodeId { get; set; }

    public virtual Claim ExternalClaim { get; set; } = null!;

    public virtual Person ExternalPerson { get; set; } = null!;

    public virtual Fkcode Fkcode { get; set; } = null!;

    public virtual Organization Organization { get; set; } = null!;
}
