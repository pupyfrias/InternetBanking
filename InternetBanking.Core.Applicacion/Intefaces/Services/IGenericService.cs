using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetBanking.Core.Applicacion.Intefaces.Services
{
    public interface IGenericService<Entity, ViewModel,SaveViewModel>
        where Entity: class 
        where ViewModel: class
        where SaveViewModel: class
    {
        Task Add(SaveViewModel vm);
        Task Upadate(SaveViewModel vm, int Id);
        Task Delete(ViewModel VM);
        Task<ViewModel> GetById(int id);
        Task<List<ViewModel>> GetAll();
    }
}
