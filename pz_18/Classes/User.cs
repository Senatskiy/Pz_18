using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Business_logic.Classes
{
    /// <summary>
    /// класс представляющий пользователя системы
    /// </summary>
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        [Key]
        public int UserId { get; private set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Required]
        [StringLength(50)]
        public string Login { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        public int SpecialistId { get; set; }

        [Required]
        public int ClientId { get; set; }
    }
}
