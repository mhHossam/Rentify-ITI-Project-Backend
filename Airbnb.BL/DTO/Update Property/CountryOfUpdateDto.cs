﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL;

public class CountryOfUpdateDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<CityofUpdateDto> Cities { get; set; } = new List<CityofUpdateDto>();
}