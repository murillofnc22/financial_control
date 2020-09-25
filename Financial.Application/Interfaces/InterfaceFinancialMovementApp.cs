using Financial.ApplicationApp.Interfaces.Generics;
using Financial.Entities.Entities;
using System.Threading.Tasks;

namespace Financial.ApplicationApp.Interfaces
{
    public interface InterfaceFinancialMovementApp : InterfaceGenericApp<FinancialMovement>
    {
        Task AddProduct(FinancialMovement financialMovement);
        Task UpdateProduct(FinancialMovement financialMovement);
    }
}
