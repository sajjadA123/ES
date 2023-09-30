using DelegationOfAuthority.Core.Biz;
using DelegationOfAuthority.Core.Contracts.Entities;
using DelegationOfAuthority.Core.DataAccess;
using DelegationOfAuthority.Services.Contracts;
using DelegationOfAuthority.Domain.Entity;
using DelegationOfAuthority.Common.DTOs;
using System.Linq;
using System.Collections.Generic;
using DelegationOfAuthority.Common.DTOs.Common;
using DelegationOfAuthority.Common.Helpers;
using System;
using Saipa.Common.Helpers;

namespace DelegationOfAuthority.Services.Modules
{
    public class UserExpertiseBiz : BaseBiz<UserExpertise, UserExpertiseDTO>, IUserExpertiseBiz
    {
        public UserExpertiseBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public void EditExpertise(UserExpertiseDTO param)
        {
            var userEx = UnitOfWork.Repository<UserExpertise>().Get(i => i.USERID == param.userId).FirstOrDefault();

            if (userEx != null)
            {
                //update
                userEx.GRADEID = Convert.ToInt32(param.gradeId);
                userEx.EXPERTISEID = Convert.ToInt32(param.expertiseId);
                UnitOfWork.Repository<UserExpertise>().Update(userEx);
            }
            else
            {
                //insert
                UnitOfWork.Repository<UserExpertise>().Insert(new UserExpertise
                {
                    GRADEID = Convert.ToInt32(param.gradeId),
                    USERID = param.userId,
                    EXPERTISEID = Convert.ToInt32(param.expertiseId)

                });
            }
            Commit();
        }

        public PaginatedResult<UserExpertiseDTO> Show(UserExpertiseSearch search)
        {
            var users = UnitOfWork.Repository<User>().Get();
            var expertise = UnitOfWork.Repository<UserExpertise>().Get();

            var query = (users.GroupJoin(
                     expertise,
                     user => user.ID,
                     exper => exper.USERID,
                     (x, y) => new { user = x, exper = y })
                  .SelectMany(
                      x => x.exper.DefaultIfEmpty(),
                      (x, y) => new UserExpertiseDTO
                      {
                          gradeId = y.GRADEID,
                          gradeTitle = y.GRADE != null ? " سطح " + y.GRADE.NUMBER : "-",
                          user_name = x.user.USER_NAME,
                          userId = x.user.ID,
                          userTitle = x.user.FULL_NAME,
                          expertiseTitle = y.EXPERTISE != null ? y.EXPERTISE.TITLE : "-",
                          expertiseId = y.EXPERTISEID,
                          job_desc = x.user.JOB_DESC,
                          dep_name = x.user.DEP_NAME
                      })).ToList();


            if (!string.IsNullOrWhiteSpace(search.fullname))
                query = query.Where(u => u.userTitle.ArabicToPersian().Contains(search.fullname.Trim()) || u.user_name.ArabicToPersian().Contains(search.fullname.Trim())).ToList();

            if (search.expertiseId > 0)
                query = query.Where(u => u.expertiseId == search.expertiseId).ToList();

            var dsResult = query.Skip(search.Skip).Take(search.Take).ToList();


            return new PaginatedResult<UserExpertiseDTO>
            {
                CurrentPage = search.Skip,
                PageSize = search.Take,
                Items = dsResult,
                TotalCount = query.Count()

            };
        }

        public List<DropdownDTO> SelectDrpData()
        {
            var data = UnitOfWork.Repository<Expertise>().Get();
            return data.Select(i => new DropdownDTO { Id = i.ID, Desc = i.TITLE }).ToList();

        }

    }
}
