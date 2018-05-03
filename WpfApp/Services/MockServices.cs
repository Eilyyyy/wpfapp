using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Model;
using WpfApp.Services.Abstract;
using WpfApp.ViewModel;

namespace WpfApp.Services
{
    public class MockServices : IPatientServices
    {
        private readonly List<Patient> _patients;

        public MockServices()
        {
            _patients = new List<Patient>
            {
                new Patient
                {
                    Birthday = new DateTime(1993, 06, 16),
                    RegisterDay = new DateTime(2018, 4, 23),
                    Email = "eil@yyy.com",
                    Gender = Gender.Man,
                    IdNumber = "156498531656",
                    PhoneNumber = "5463156431543546465456",
                    Name = "gysl"
                }
            };
        }

        public Task<IEnumerable<Patient>> GetPatient(string filter)
        {
            return Task.FromResult(_patients.AsEnumerable());
        }

        public Task<bool> UpdatePatient(Patient patient)
        {
            return Task.FromResult(true);
        }

        public Task<bool> AddPatient(Patient patient)
        {
            _patients.Add(patient);
            return Task.FromResult(true);
        }
    }
}
