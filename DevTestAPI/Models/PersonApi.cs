﻿using DevTestAPI.DataModels;

namespace DevTestAPI.Models
{
    public class PersonApi
    {
        public PersonApi(Person p)
        {
            Id = p.Id;
            OrganizationId = p.OrganizationId;
            ExternalPersonId = p.ExternalPersonId;
            SubscriberNumber = p.SubscriberNumber;
            SubscriberId = p.SubscriberId;
            Suffix = p.Suffix;
            FirstName = p.FirstName;
            Middle = p.Middle;
            LastName = p.LastName;
        }
        public int Id { get; set; }

        public int OrganizationId { get; set; }

        public string? ExternalPersonId { get; set; }

        public string? SubscriberNumber { get; set; }

        public string? SubscriberId { get; set; }

        public string? Suffix { get; set; }

        public string? FirstName { get; set; }

        public string? Middle { get; set; }

        public string? LastName { get; set; }

    }
}