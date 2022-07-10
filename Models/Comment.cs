using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;
using TheBlogProject.Enums;

namespace TheBlogProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int PostId { get; set; }
        public string AuthorId { get; set; }
        public string ModeratorId { get; set; }

        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be atleast {2} and no more than {1} character long", MinimumLength = 2)]
        [Display(Name = "Comment")]
        public string Body { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Created Date")]
        public DateTime Created { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Updated Date")]
        public DateTime? Updated { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Moderated Date")]
        public DateTime? Moderated { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Deleted Date")]
        public DateTime? Deleted { get; set; }
        
        [StringLength(500, ErrorMessage = "The {0} must be atleast {2} and no more than {1} character long", MinimumLength = 2)]
        [Display(Name = "Moderated Comment")]
        public string ModeratedBody { get; set; }

        public ModerationType ModerationType { get; set; }

        // Navigation properties - used to navigate the relationships b/w entities
        public virtual Post Post { get; set; }  // holds the record referenced by FK PostId 
        public virtual BlogUser Author { get; set; }
        public virtual BlogUser Moderator { get; set; }
    }
}
