using AutoMapper;
using InternetBanking.Core.Applicacion.Intefaces.Repositories;
using InternetBanking.Core.Applicacion.Intefaces.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace InternetBanking.Core.Applicacion.Services
{
    public class GenericService<Entity, ViewModel, SaveViewModel> : IGenericService<Entity, ViewModel, SaveViewModel> 
        where Entity : class 
        where ViewModel : class
        where SaveViewModel : class
    {

        private readonly IGenericRepository<Entity> _repository;
        private readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Add(SaveViewModel vm)
        {
            Entity entity = _mapper.Map<Entity>(vm);
            await _repository.AddAsync(entity);
        }

        public async Task Delete(ViewModel vm)
        {
            Entity entity = _mapper.Map<Entity>(vm);
            await _repository.DeleteAsync(entity);
        }

        public async Task<List<ViewModel>> GetAll()
        {
            var entityList = await _repository.GetAllAsync();
            return _mapper.Map<List<ViewModel>>(entityList);
        }

        public async Task<ViewModel> GetById(int id)
        {
            Entity entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<ViewModel>(entity);
        }

        public async Task Upadate(SaveViewModel vm, int Id)
        {
            Entity entity = _mapper.Map<Entity>(vm);
            await _repository.UpdateAsync(entity, Id);
        }
    }
}
