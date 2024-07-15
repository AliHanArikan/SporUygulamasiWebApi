using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ExerciseManager : IExerciseService
    {
        private readonly IExerciseDal _exerciseDal;

        public ExerciseManager(IExerciseDal exerciseDal)
        {
            _exerciseDal = exerciseDal;
        }

        public async Task TAddAsync(Exercise entity)
        {
           await _exerciseDal.AddAsync(entity);

        }

        public async Task TDeleteAsync(Exercise entity)
        {
           await _exerciseDal.DeleteAsync(entity);
        }

        public async Task<IEnumerable<Exercise>> TGetAllAsync()
        {
           return await _exerciseDal.GetAllAsync();
        }

        public async Task<Exercise> TGetByIdAsync(int id)
        {
            return await _exerciseDal.GetByIdAsync(id);
        }

        public async Task TUpdateAsync(Exercise entity)
        {
           await _exerciseDal.UpdateAsync(entity);
        }
    }
}
