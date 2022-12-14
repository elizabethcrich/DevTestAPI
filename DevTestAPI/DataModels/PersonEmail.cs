using System;
using System.Collections.Generic;

namespace DevTestAPI.DataModels;

public partial class PersonEmail
{
    public int Id { get; set; }

    public int OrganizationId { get; set; }

    public int ExternalPersonId { get; set; }

    public string? Email { get; set; }

    public virtual Person ExternalPerson { get; set; } = null!;

    public virtual Organization Organization { get; set; } = null!;
}
