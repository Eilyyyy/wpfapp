using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AutoMapper;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using WpfApp.Model;
using WpfApp.Services.Abstract;

namespace WpfApp.ViewModel
{
    public class InspectionInformationViewModel : ViewModelBase
    {
        public string Filter { get; set; }
        public PatientViewModel CurrentPatient { get; set; }
        public ObservableCollection<PatientViewModel> Patients { get; set; }
        private readonly IPatientServices _patientServices;
        private readonly IEntityMapper _entityMapper;

        public InspectionInformationViewModel(IPatientServices patientServices, IEntityMapper entityMapper)
        {
            _patientServices = patientServices;
            _entityMapper = entityMapper;
            Patients = new ObservableCollection<PatientViewModel>();
            RegisterCommand();
        }

        public ICommand FilterCommand { get; set; }
        public ICommand UpdateCommand { get; set; }

        private void RegisterCommand()
        {
            FilterCommand  = new RelayCommand(async () =>
            {
                await _patientServices.GetPatient(Filter).ContinueWith(tResult =>
                {
                    Patients.Clear();
                    foreach (var patient in tResult.Result)
                    {
                        Patients.Add(_entityMapper.Map<Patient, PatientViewModel>(patient));
                    }
                }, TaskScheduler.FromCurrentSynchronizationContext());
            });

            UpdateCommand = new RelayCommand(async () =>
            {
                await _patientServices.UpdatePatient(_entityMapper.Map<PatientViewModel, Patient>(CurrentPatient)).ConfigureAwait(false);
            });
        }
    }
}
