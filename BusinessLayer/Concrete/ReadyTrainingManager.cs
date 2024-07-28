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

    public class ReadyTrainingManager : IReadyTrainingService
    {
        private readonly IReadyTrainingDal _readyTrainingDal;

        public ReadyTrainingManager(IReadyTrainingDal readyTrainingDal)
        {
            _readyTrainingDal = readyTrainingDal;
        }

        public async Task TAddAsync(ReadyTraining entity)
        {
            await _readyTrainingDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(ReadyTraining entity)
        {
            await _readyTrainingDal.DeleteAsync(entity);
        }

        public async Task<IEnumerable<ReadyTraining>> TGetAllAsync()
        {
           return await _readyTrainingDal.GetAllAsync();
        }

        public async Task<ReadyTraining> TGetByIdAsync(int id)
        {
            return await _readyTrainingDal.GetByIdAsync(id);
        }

        public async Task TUpdateAsync(ReadyTraining entity)
        {
             await _readyTrainingDal.UpdateAsync(entity);
        }
    }
}
