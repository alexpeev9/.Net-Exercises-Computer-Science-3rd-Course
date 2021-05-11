using LoginDesktopForm.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LoginDesktopForm.Models
{
    public class Role : BaseModel 
    {
        public string Name { get; set; }
        // Admin 
        public string Description { get; set; }
        // Add,Update,Delete
        // See users logs
        public ICollection<User> Users { get; set; }
    }
}
