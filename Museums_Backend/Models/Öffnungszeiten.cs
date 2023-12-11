using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

public class Öffnungszeiten
{
    [Key]
    public int Id { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime Wochentag { get; set; }

    [Required]
    [DataType(DataType.Time)]
    public DateTime Öffnungszeit { get; set; }

    [Required]
    [DataType(DataType.Time)]
    public DateTime Schließungszeit { get; set; }

   
}
