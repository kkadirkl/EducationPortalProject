using Core.Entities.Concrete;
using Entities.Dtos;
using ResultsNetStandard.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserOperationClaimService
    {
        IResult Add(UserOperationClaim userOperationClaim);
        IResult Delete(UserOperationClaim userOperationClaim);
        IResult Update(UserOperationClaim userOperationClaim);

        IListDataResult<UserOperationClaimDto> GetDtoByUserEmail(string userEmail);
        IListDataResult<UserOperationClaim> GetUserOperationClaims();
        IListDataResult<UserOperationClaimDto> GetUserDtoOperationClaims();
        IListDataResult<UserOperationClaimDto> GetByUserClaims(User user);
    }
}
