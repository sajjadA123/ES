using ES.Core.Biz;
using ES.Core.Contracts.Entities;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain.Entity.baseInfo;
using ES.DTOs.baseInfo;
using ES.Service.Contracts.baseinfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES.Service.Modules.baseinfo
{
    public class BaseDetailBiz : BaseBiz<TbDetail, TbDetailDTO>, IBaseDetailBiz
    {
        public BaseDetailBiz(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<TbDetailDTO> GetByHeadCode(string code)
        {
            System.Linq.Expressions.Expression<Func<TbDetail,bool>> body = s => s.Head.HeadCode == code;
            return Extensions.ToDTOList<TbDetailDTO>( base.Get(body));
        }

        public TbDetailDTO getByHeadCodeAndDetailCode(string headCode, string detailCode)
        {
            System.Linq.Expressions.Expression<Func<TbDetail, bool>> body = s => s.Head.HeadCode == headCode && s.DETAIL_CODE==detailCode;
            return Extensions.ToDTO<TbDetailDTO>(base.Get(body).FirstOrDefault());
        }

        public PaginatedResult<CodeSelectorDTO> Show(CodeSelectorSearch search)
        {
            throw new NotImplementedException();
        }
    }
}
