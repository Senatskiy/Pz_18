using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_logic.Classes
{
    public class HomeTech : INotifyPropertyChanged
    {
        [Key]
        public int HomeTechId { get; set; }

        [Required]
        public string HomeTechType { get; set; }

        [Required]
        public string HomeTechModel { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;
    }

}
