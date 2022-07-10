using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IGenericService<Model, ViewModel,SaveViewModel>
        where Model: class 
        where ViewModel: class
        where SaveViewModel: class
    {
        Task Add(SaveViewModel vm);
        Task Upadate(SaveViewModel vm);
        Task Delete(ViewModel VM);
        Task<ViewModel> GetById(int id);
        Task<List<ViewModel>> GetAll();
    }
}
