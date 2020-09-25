using Financial.Entities.Entities;
using System.Threading.Tasks;

namespace Financial.Domain.Interfaces.InterfaceServices
{
    public interface IServiceFinancialMovement
    {
        Task AddFinancialMovement(FinancialMovement financialMovement);
        Task UpdateFinancialMovement(FinancialMovement financialMovement);
    }
}
