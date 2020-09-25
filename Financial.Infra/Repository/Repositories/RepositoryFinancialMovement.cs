using Financial.Domain.Interfaces.InterfaceFinancialMovement;
using Financial.Entities.Entities;
using Financial.Infra.Repository.Generic;

namespace Financial.Infra.Repository.Repositories
{
    public class RepositoryFinancialMovement : RespositoryGeneric<FinancialMovement>, IFinancialMovement
    {
    }
}