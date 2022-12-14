using System;
using System.Collections.Generic;

namespace DevTestAPI.DataModels;

public partial class Organization
{
    public int Id { get; set; }

    public string OrganizationId { get; set; } = null!;

    public virtual ICollection<ClaimFkcode> ClaimFkcodes { get; } = new List<ClaimFkcode>();

    public virtual ICollection<Claim> Claims { get; } = new List<Claim>();

    public virtual ICollection<Person> People { get; } = new List<Person>();

    public virtual ICollection<PersonEmail> PersonEmails { get; } = new List<PersonEmail>();

    public virtual ICollection<PersonPhone> PersonPhones { get; } = new List<PersonPhone>();

    public virtual ICollection<PersonRelated> PersonRelateds { get; } = new List<PersonRelated>();
}
