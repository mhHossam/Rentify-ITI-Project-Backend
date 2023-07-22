﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL;

public class CountryDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<CityDto> Cities { get; set; } = new List<CityDto>();
}
