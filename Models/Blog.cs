using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheBlogProject.Models
{
    public class Blog
    { 
        public int Id { get; set; } 
        public string AuthorId { get; set; } // FK used for navigation property
       
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be atleast {2} and at most {1} characters", MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(500, ErrorMessage = "The {0} must be atleast {2} and at most {1} characters", MinimumLength = 2)]
        public string Description { get; set; }
        
        [DataType(DataType.Date)] // treat as just as Date on the GUI not Data-time
        [Display(Name = "Created Date")] // uses this string for the form field label instead of prop name
        public DateTime Created { get; set; }
        [DataType(DataType.Date)] // treat as just as Date on the GUI not Data-time
        [Display(Name = "Updated Date")] // uses this string for the form field label instead of prop name
        public DateTime? Updated { get; set; } // nullable date-time
        
        [Display(Name = "Blog Image")]
        public byte[] ImageData { get; set; }  // file byte stream
        [Display(Name = "Blog Type")]
        public string ContentType { get; set; } // image type
        [NotMapped] // will not create an field in table
        public IFormFile Image { get; set; } // represents the file object will derive details from to hold in other props above


        // NAVIGATION PROPERTIES
        public virtual BlogUser Author { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new HashSet<Post>();


    }
}
