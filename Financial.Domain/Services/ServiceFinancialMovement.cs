using Financial.Domain.Interfaces.InterfaceFinancialMovement;
using Financial.Domain.Interfaces.InterfaceServices;
using Financial.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Financial.Domain.Services
{
    public class ServiceFinancialMovement : IServiceFinancialMovement
    {
        private readonly IFinancialMovement _IFinancialMovement;
        public ServiceFinancialMovement(IFinancialMovement _IFinancialMovement)
        {
            this._IFinancialMovement = _IFinancialMovement;
        }

        public async Task AddFinancialMovement(FinancialMovement financialMovement)
        {
            //faz as validações

            await _IFinancialMovement.Add(financialMovement);
        }

        public async Task UpdateFinancialMovement(FinancialMovement financialMovement)
        {
            //faz as validações

            await _IFinancialMovement.Update(financialMovement);
        }
    }
}
