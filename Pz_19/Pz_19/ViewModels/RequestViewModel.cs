using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Pz_19.ViewModels
{
    public class RequestViewModel : INotifyPropertyChanged
    {
        private int _requestId;
        private DateTime? _requestDate;
        private int? _homeTechId;
        private string? _faultType;
        private int? _userId;
        private int? _statusId;
        private DateTime? _completionDate;
        private int? _specialistId;
        private int? _clientId;

        public int RequestId
        {
            get => _requestId;
            set { _requestId = value; OnPropertyChanged(); }
        }

        public DateTime? RequestDate
        {
            get => _requestDate;
            set { _requestDate = value; OnPropertyChanged(); }
        }

        public int? HomeTechId
        {
            get => _homeTechId;
            set { _homeTechId = value; OnPropertyChanged(); }
        }

        public string? FaultType
        {
            get => _faultType;
            set { _faultType = value; OnPropertyChanged(); }
        }

        public int? UserId
        {
            get => _userId;
            set { _userId = value; OnPropertyChanged(); }
        }

        public int? StatusId
        {
            get => _statusId;
            set { _statusId = value; OnPropertyChanged(); }
        }

        public DateTime? CompletionDate
        {
            get => _completionDate;
            set { _completionDate = value; OnPropertyChanged(); }
        }

        public int? SpecialistId
        {
            get => _specialistId;
            set { _specialistId = value; OnPropertyChanged(); }
        }

        public int? ClientId
        {
            get => _clientId;
            set { _clientId = value; OnPropertyChanged(); }
        }

        public ObservableCollection<RequestViewModel> Requests { get; set; } = new ObservableCollection<RequestViewModel>();

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
