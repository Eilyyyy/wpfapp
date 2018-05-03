using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp.Model;

namespace WpfApp.Services.Abstract
{
    public interface IPatientServices
    {
        Task<IEnumerable<Patient>> GetPatient(string filter);
        Task<bool> UpdatePatient(Patient patient);
        Task<bool> AddPatient(Patient patient);
    }
}
