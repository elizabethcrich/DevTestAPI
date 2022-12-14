using DevTestAPI.DataModels;

namespace DevTestAPI.Models
{
    public class PersonApi
    {
        public PersonApi(Person p)
        {
            Id = p.Id;
            OrganizationId = p.OrganizationId;
            ExternalPersonId = p.ExternalPersonId;
            Suffix = p.Suffix;
            FirstName = p.FirstName;
            Middle = p.Middle;
            LastName = p.LastName;
            Organization = p.Organization;
            PersonEmails = p.PersonEmails;
            PersonPhones = p.PersonPhones;
        }
        public int Id { get; set; }

        public int OrganizationId { get; set; }

        public string? ExternalPersonId { get; set; }

        public string? Suffix { get; set; }

        public string? FirstName { get; set; }

        public string? Middle { get; set; }

        public string? LastName { get; set; }

        public Organization Organization { get; set; }

        public ICollection<PersonEmail> PersonEmails { get; set; }

        public ICollection<PersonPhone> PersonPhones { get; set; }

    }
}
