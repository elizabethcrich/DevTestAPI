using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DevTestAPI.DataModels;

public partial class Claim
{
    public int Id { get; set; }

    public int OrganizationId { get; set; }

    public int ExternalPersonId { get; set; }

    public string? ExternalClaimId { get; set; }

    public int? ServiceNumber { get; set; }

    public string? ServiceName { get; set; }

    public string? ServiceAddress { get; set; }

    public string? ServiceCity { get; set; }

    public string? ServiceState { get; set; }

    public string? ServiceZip { get; set; }

    public string? ServiceZip2 { get; set; }

    public int? ClaimNumber { get; set; }

    public int? ClaimLineNumber { get; set; }

    public DateTime? PaidDate { get; set; }

    public DateTime? DateofServiceStart { get; set; }

    public DateTime? DateofServiceEnd { get; set; }

    public string? ServiceType { get; set; }

    public decimal? ChargedAmount { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? Decased { get; set; }

    public string? Policy { get; set; }

    public string? Policy2 { get; set; }

    public string? Policy3 { get; set; }

    public string? Policy4 { get; set; }

    public string? Policy5 { get; set; }

    public string? PolicyName { get; set; }

    public string? WorkCode { get; set; }

    public string? OfficeCode { get; set; }

    public string? LineCode { get; set; }

    public virtual ICollection<ClaimFkcode> ClaimFkcodes { get; } = new List<ClaimFkcode>();

    public virtual Person ExternalPerson { get; set; } = null!;

    [JsonIgnore]
    public virtual Organization Organization { get; set; } = null!;
}
