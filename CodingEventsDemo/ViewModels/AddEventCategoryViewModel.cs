using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventCategoryViewModel
    {

        [Required(ErrorMessage ="Name required")]
        [StringLength(20, ErrorMessage = "Name must be between 3 and 20 characters", MinimumLength = 3)]
        public string Name { get; set; }
    }
}
