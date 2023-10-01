using ES.Common.Enums;
using ES.Core.Contracts.DTOs;
using ES.Core.Contracts.Entities;

namespace ES.DTOs
{
    public class UserRoleDTO : StrongEntityDTO
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
    
    public class UserRoleSearch : BaseSearch
    {
        public string fullname { get; set; }
        public RoleType? roleType { get; set; }
    }
}
