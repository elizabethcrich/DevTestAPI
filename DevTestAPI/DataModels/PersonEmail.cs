using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DevTestAPI.DataModels;

public partial class PersonEmail
{
    public int Id { get; set; }

    public int OrganizationId { get; set; }

    public int ExternalPersonId { get; set; }

    public string? Email { get; set; }

    [JsonIgnore]
    public virtual Person ExternalPerson { get; set; } = null!;

    [JsonIgnore]
    public virtual Organization Organization { get; set; } = null!;
}
