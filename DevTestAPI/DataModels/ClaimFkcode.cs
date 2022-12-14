using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DevTestAPI.DataModels;

public partial class ClaimFkcode
{
    public int Id { get; set; }

    public int OrganizationId { get; set; }

    public int ExternalPersonId { get; set; }

    public int ExternalClaimId { get; set; }

    public int FkcodeId { get; set; }

    [JsonIgnore]
    public virtual Claim ExternalClaim { get; set; } = null!;

    [JsonIgnore]
    public virtual Person ExternalPerson { get; set; } = null!;

    public virtual Fkcode Fkcode { get; set; } = null!;

    [JsonIgnore]
    public virtual Organization Organization { get; set; } = null!;
}
