using InternetBanking.Core.Applicacion.Intefaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetBanking.Core.Applicacion.Services
{
    public class GenericService<Model, ViewModel, SaveViewModel> : IGenericService<Model, ViewModel, SaveViewModel> 
        where Model : class 
        where ViewModel : class
        where SaveViewModel : class
    {
        public Task Add(SaveViewModel vm)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(ViewModel VM)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ViewModel>> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ViewModel> GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Upadate(SaveViewModel vm)
        {
            throw new System.NotImplementedException();
        }
    }
}
