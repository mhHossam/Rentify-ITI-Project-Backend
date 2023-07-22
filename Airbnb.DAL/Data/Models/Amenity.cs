﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;
public class Amenity
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MinLength(5)]
    [MaxLength(10)]
    public string Name { get; set; } = string.Empty;
    public string Icon { get; set; } = string.Empty;    //Url
    public IEnumerable<PropertyAmenity> AmenitiesProperty { get; set; } = new List<PropertyAmenity>();
}
