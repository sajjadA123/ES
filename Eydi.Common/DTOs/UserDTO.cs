using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;
using System;

namespace ES.DTOs
{
    public class UserDTO : StrongEntityDTO
    {
        public string user_name { get; set; }
        public int user_Id { get; set; }
        public string full_name { get; set; }
        public string expertiseTitle { get; set; }
        public int? expertiseId { get; set; }
        public string enabled { get; set; }
        public string titleRole { get; set; }
        public string score { get; set; }
        public string scorPerWeight { get; set; }
        public RoleType? roleType { get; set; }
        public string job_desc { get; set; }
        public string dep_name { get; set; }
    }

    public class UserInfoDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PersonelCode { get; set; }
        public string access { get; set; }
    }

    public class UserSearch : BaseSearch
    {
        public string fullname { get; set; }
    }
}
