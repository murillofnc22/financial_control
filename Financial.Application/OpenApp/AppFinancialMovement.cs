using Financial.ApplicationApp.Interfaces;
using Financial.Entities.Entities;
using Financial.Domain.Interfaces.InterfaceFinancialMovement;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Financial.Domain.Interfaces.InterfaceServices;

namespace Financial.ApplicationApp.OpenApp
{
    public class AppFinancialMovement : InterfaceFinancialMovementApp
    {
        IFinancialMovement _IFinancialMovement;
        IServiceFinancialMovement _IServiceFinancialMovement;

        public AppFinancialMovement(IFinancialMovement _IFinancialMovement, IServiceFinancialMovement _IServiceFinancialMovement)
        {
            this._IFinancialMovement = _IFinancialMovement;
            this._IServiceFinancialMovement = _IServiceFinancialMovement;
        }

        public async Task Add(FinancialMovement Objeto)
        {
            await _IFinancialMovement.Add(Objeto);
        }
        public async Task Delete(FinancialMovement Objeto)
        {
            await _IFinancialMovement.Delete(Objeto);
        }
        public async Task<FinancialMovement> GetEntityById(int id)
        {
            return await _IFinancialMovement.GetEntityById(id);
        }
        public async Task<List<FinancialMovement>> List()
        {
            return await _IFinancialMovement.List();
        }
        public async Task Update(FinancialMovement Objeto)
        {
            await _IFinancialMovement.Update(Objeto);
        }

        #region metodos customizados
        public async Task AddProduct(FinancialMovement financialMovement)
        {
            await _IServiceFinancialMovement.AddFinancialMovement(financialMovement);

        }
        public async Task UpdateProduct(FinancialMovement financialMovement)
        {
            await _IServiceFinancialMovement.UpdateFinancialMovement(financialMovement);
        }
        #endregion
    }
}
