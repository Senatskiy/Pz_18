using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Classes
{
    public class SpecialistTypeм : INotifyPropertyChanged
    {
        [Key]
        public int SpecialistId { get; set; }

        [Required]
        public string Type { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
