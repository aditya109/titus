using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace WebServer.Models
{
    [Keyless]
    [Table("Division")]
    public partial class Division
    {
        [Column("ID")]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string DivisionName { get; set; }
        public byte IsActive { get; set; }
        public int ParenGroupId { get; set; }
    }
}
