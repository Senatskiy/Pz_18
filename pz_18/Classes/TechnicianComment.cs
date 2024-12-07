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
    public class TechnicianComment : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [Key]
        public int CommentId { get; private set; }

        [Required]
        public string CommentText { get; set; }

        [Required]
        public int SpecialistId { get; set; }

        [Required]
        public int RequestId { get; set; }
    }
}