﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airbnb.DAL;
using Microsoft.AspNetCore.Identity;

namespace Airbnb.DAL;

public class User: IdentityUser
{

    [MaxLength(30)] 
    
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(30)]

    public string LasttName { get; set; } = string.Empty;
    public UserType UserType { get; set; }

    public string About { get; set; } = string.Empty;
    public string UserImage { get; set; } = string.Empty;
    public string? Code { get; set; }

    public IEnumerable<PropertyImage> UserPropertyImages { get; set; } = new List<PropertyImage>();
    public IEnumerable<Booking> UserBookings { get; set; } = new List<Booking>();
    public IEnumerable<Property> UserProperties { get; set; } = new List<Property>();
    public IEnumerable<Review> Reviews { get; set; } = new List<Review>();


}
