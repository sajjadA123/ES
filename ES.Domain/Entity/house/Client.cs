using ES.Core.Contracts.Entities;
using ES.Domain.Entity.baseInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ES.Domain.Entity.house
{
    public class Client:StrongEntity
    {
        [MaxLength(100)]
		public string FirstName { get; set; }
        [MaxLength(100)]
		public string LastName { get; set; }
        [MaxLength(20)]
		public string Telephone { get; set; }
        [MaxLength (200)]
		public string StreetAddress { get; set; }
        [MaxLength(50)]
		public string UnitNumber { get; set; }
        [MaxLength(200)]
		public string City { get; set; }
		public int? RegionId { get; set; }
        public Regions Regions { get; set; }
        [MaxLength(20)]
        public string PostalCode { get; set; }
        [MaxLength(100)]
        public string MailAddressName { get; set; }
        [MaxLength(100)]
        public string MailAddress { get; set; }
        [MaxLength(50)]
        public string UnitNumber2 { get; set; }
        [MaxLength(200)]
        public string City2 { get; set; }

        public int? RegionId2 { get; set; }
        public Regions Regions2 { get; set; }

        [MaxLength(50)]
        public string PostalCode2 { get; set; }


    }
}
