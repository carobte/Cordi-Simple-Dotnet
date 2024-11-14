using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CordiSimpleDotnet.Models
{
    [Table("events")] // Especifica la tabla en la base de datos
    public class Event
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Column("name")]
        public string Name { get; set; }
        [Required]
        [StringLength(255)]
        [Column("description")]
        public string Description { get; set; }

        [Required]
        [Column("start_date", TypeName = "datetime")]
        public DateTime StartDate { get; set; }

        [Required]
        [Column("end_date", TypeName = "datetime")]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(255)]
        [Column("location")]
        public string Location { get; set; }

        [Required]
        [Column("capacity")]
        public int Capacity { get; set; }

        [Column("occupied_slots")]
        public int OccupiedSlots { get; set; } = 0;

        [Required]
        [Column("status")]
        public bool Status { get; set; }
    
    }
}