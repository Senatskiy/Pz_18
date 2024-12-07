using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Business_logic.Classes
{
    /// <summary>
    /// класс представляет комментарии оставленные мастерами
    /// </summary>
    public class Request : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        [Key]
        public int RequestId { get; private set; }

        [Required]
        public DateTime RequestDate { get; set; }

        [Required]
        public int HomeTechId { get; set; }

        [Required]
        public string FaultType { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int StatusId { get; set; }

        public DateTime? CompletionDate { get; set; }

        [Required]
        public int SpecialistId { get; set; }

        [Required]
        public int ClientId { get; set; }

        public void UpdateStatus(int newStatusId)
        {
            StatusId = newStatusId;
            OnPropertyChanged(nameof(StatusId));
        }

        public void AssignSpecialist(int specialistId)
        {
            SpecialistId = specialistId;
            OnPropertyChanged(nameof(SpecialistId));
        }
    }
}
