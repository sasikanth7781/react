using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly Mycontext context;
        public QuestionRepository(Mycontext context)
        {
            this.context = context;
        }

        public async Task<Diet> AddDiet(Diet diet)
        {
            var obj = await context.sk_diet.AddAsync(diet);
            await context.SaveChangesAsync();
            return obj.Entity;
        }

        public async Task<Patient> add_patient(Patient p)
        {
            p.created_date = DateTime.Now;
            p.modified_date= DateTime.Now;
            p.is_deleted = false;
            var new_row=await context.sk_question.AddAsync(p);
            await context.SaveChangesAsync();
            return new_row.Entity;
      
        }

        public async  Task<Patient> delete_patient(int id)
        {
            var obj = await context.sk_question.FindAsync(id);
            obj.is_deleted = true;
            await context.SaveChangesAsync();
            return obj;
        }

        public async Task<List<City>> GetCities()
        {
            return await context.sk_City.ToListAsync<City>();
        }

        public async Task<List<City>> GetCitiesByState(int id)
        {
            return await context.sk_City.Where((city)=>city.s_id==id).ToListAsync<City>();
            
        }

        public async Task<List<Diet>> GetDiets(int id)
        {
            return await context.sk_diet.Where((d)=>d.p_id ==id).ToListAsync<Diet>();
        }

        
        public async Task<Patient> getPatient(int id)
        {
            var obj = await context.sk_question.FindAsync(id);
            return obj;
        }

        public async Task<List<Patient>> GetPatients()
        {
            return await context.sk_question.Where((row)=>row.is_deleted==false).ToListAsync <Patient>();
        }

        public async Task<State> GetState(int id)
        {
             var obj= await context.sk_State.FindAsync(id);
            return obj;
        }

        public async  Task<List<State>> GetStates()
        {
            return await context.sk_State.ToListAsync <State>();
        }

        public async Task<Patient> update_patient(int id,Patient p)
        {
            var obj = await context.sk_question.FindAsync(id);
            obj.first_name = p.first_name;
            obj.last_name = p.last_name;
            obj.gender = p.gender;
            obj.DOB = p.DOB;
            obj.Email = p.Email;
            obj.s_id = p.s_id;
            obj.height = p.height;
            obj.weight = p.weight;
            obj.question1 = p.question1;
            obj.question2 = p.question2;
            obj.question3 = p.question3;
            obj.problems = p.problems;
            obj.regular_exercise = p.regular_exercise;
            obj.need_trainer = p.need_trainer;
            await context.SaveChangesAsync();
            return p;
        }
    }
}
