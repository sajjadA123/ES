using DelegationOfAuthority.Core.Biz;
using DelegationOfAuthority.Core.Contracts.Entities;
using DelegationOfAuthority.Core.DataAccess;
using DelegationOfAuthority.Services.Contracts;
using DelegationOfAuthority.Domain.Entity;
using DelegationOfAuthority.Common.DTOs;
using System.Linq;
using DelegationOfAuthority.Common.Helpers;
using Saipa.Common.Helpers;

namespace DelegationOfAuthority.Services.Modules
{
    public class UserRoleBiz : BaseBiz<UserRole, UserRoleDTO>, IUserRoleBiz
    {
        public UserRoleBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
        public void EditRole(UserRoleDTO param)
        {
            var userRole = UnitOfWork.Repository<UserRole>().Get(i => i.USERID == param.user_Id).FirstOrDefault();

            if (userRole != null)
            {
                //update
                userRole.ROLETYPE = param.roleType == Common.Enums.RoleType.Accountant ? Common.Enums.RoleType.Accountant :
                    param.roleType == Common.Enums.RoleType.AssessmentTrustee ? Common.Enums.RoleType.AssessmentTrustee :
                    param.roleType == Common.Enums.RoleType.Admin ? Common.Enums.RoleType.Admin :
                    param.roleType == Common.Enums.RoleType.Manager ? Common.Enums.RoleType.Manager :
                    param.roleType == Common.Enums.RoleType.ContentManager ? Common.Enums.RoleType.ContentManager :
                    Common.Enums.RoleType.User;
                UnitOfWork.Repository<UserRole>().Update(userRole);
            }
            else
            {
                //insert
                UnitOfWork.Repository<UserRole>().Insert(new UserRole
                {
                    ROLETYPE = param.roleType == Common.Enums.RoleType.Accountant ? Common.Enums.RoleType.Accountant :
                    param.roleType == Common.Enums.RoleType.AssessmentTrustee ? Common.Enums.RoleType.AssessmentTrustee :
                    param.roleType == Common.Enums.RoleType.Admin ? Common.Enums.RoleType.Admin :
                    param.roleType == Common.Enums.RoleType.Manager ? Common.Enums.RoleType.Manager :
                    param.roleType == Common.Enums.RoleType.ContentManager ? Common.Enums.RoleType.ContentManager :
                    Common.Enums.RoleType.User,
                    USERID = param.user_Id,
                });
            }
            Commit();
        }

        public PaginatedResult<UserRoleDTO> Show(UserRoleSearch search)
        {

            var users = UnitOfWork.Repository<User>().Get();
            var roles = UnitOfWork.Repository<UserRole>().Get();

            var query = (users.GroupJoin(
                      roles,
                      user => user.ID,
                      role => role.USERID,
                      (x, y) => new { user = x, role = y })
                   .SelectMany(
                       x => x.role.DefaultIfEmpty(),
                       (x, y) => new UserRoleDTO
                       {
                           user_Id = x.user.ID,
                           user_name = x.user.USER_NAME,
                           titleRole = y.ROLETYPE.ToDescription() != "" ? y.ROLETYPE.ToDescription() : "-",
                           enabled = x.user.ENABLED,
                           roleType = y.ROLETYPE,
                           full_name = x.user.FULL_NAME,
                           job_desc = x.user.JOB_DESC,
                           dep_name = x.user.DEP_NAME
                       })).ToList();

            if (!string.IsNullOrWhiteSpace(search.fullname))
                query = query.Where(u => u.full_name.ArabicToPersian().Contains(search.fullname.Trim()) || u.user_name.ArabicToPersian().Contains(search.fullname.Trim())).ToList();


            if (search.roleType != null)
                query = query.Where(u => u.roleType == search.roleType).ToList();

            var dsResult = query.Skip(search.Skip).Take(search.Take).ToList();


            return new PaginatedResult<UserRoleDTO>
            {
                CurrentPage = search.Skip,
                PageSize = search.Take,
                Items = dsResult,
                TotalCount = query.Count()

            };
        }

    }
}
