using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DevTestAPI.DataModels;

public partial class Organization
{
    public int Id { get; set; }

    public string OrganizationId { get; set; } = null!;

    [JsonIgnore]
    public virtual ICollection<ClaimFkcode> ClaimFkcodes { get; } = new List<ClaimFkcode>();

    [JsonIgnore]
    public virtual ICollection<Claim> Claims { get; } = new List<Claim>();

    [JsonIgnore]
    public virtual ICollection<Person> People { get; } = new List<Person>();

    [JsonIgnore]
    public virtual ICollection<PersonEmail> PersonEmails { get; } = new List<PersonEmail>();

    [JsonIgnore]
    public virtual ICollection<PersonPhone> PersonPhones { get; } = new List<PersonPhone>();

    [JsonIgnore]
    public virtual ICollection<PersonRelated> PersonRelateds { get; } = new List<PersonRelated>();
}
