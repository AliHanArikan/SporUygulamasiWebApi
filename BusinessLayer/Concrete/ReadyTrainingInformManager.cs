using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ReadyTrainingInformManager : IReadyTrainingInformService
    {
        private readonly IReadyTrainingInformDal _readyTrainingInformDal;

        public ReadyTrainingInformManager(IReadyTrainingInformDal readyTrainingInformDal)
        {
            _readyTrainingInformDal = readyTrainingInformDal;
        }

        public async Task TAddAsync(ReadyTrainingInform entity)
        {
           await _readyTrainingInformDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(ReadyTrainingInform entity)
        {
            await _readyTrainingInformDal.DeleteAsync(entity);
        }

        public async Task<IEnumerable<ReadyTrainingInform>> TGetAllAsync()
        {
          return await _readyTrainingInformDal.GetAllAsync();
        }

        public async Task<ReadyTrainingInform> TGetByIdAsync(int id)
        {
            return await _readyTrainingInformDal.GetByIdAsync(id);
        }

        public async Task TUpdateAsync(ReadyTrainingInform entity)
        {
            await _readyTrainingInformDal.UpdateAsync(entity);
        }
    }
}
