using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IQuestionRepository
    {
        Task<List<City>> GetCities();
        Task<List<City>> GetCitiesByState(int id);
        Task<List<State>> GetStates();
        Task<List<Diet>> GetDiets(int id);
        Task<State> GetState(int id);
        Task<List<Patient>> GetPatients();
        Task<Patient> add_patient(Patient p);
        Task<Diet> AddDiet(Diet diet);
        Task<Patient> delete_patient(int id);
        Task<Patient> update_patient(int id,Patient p);
        Task<Patient> getPatient(int id);
    }
}
