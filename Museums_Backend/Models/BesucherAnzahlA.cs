﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

public class BesucherAnzahlA
{
    [Key]
    public int Id { get; set; }

    [Required]
    public int Anzahl { get; set; }

    
}
