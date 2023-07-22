﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.DAL;

public interface IGuestSectionRepo
{

    public IEnumerable<Booking> GetGuestBookings(string UserTd);
    public Booking GetGuestBooking(Guid UserTd);

    public void RemoveFromDB(Guid booking);
    int SaveChanges();
}
