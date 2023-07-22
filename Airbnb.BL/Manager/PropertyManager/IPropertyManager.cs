﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL;

public interface IPropertyManager
{
    GetPropertyDetailsDto? FindPropertyById(Guid propertyId);
    public bool AddBooking(AddBookingDto bookingDto, string userId);
    public bool AddReview(AddReviewDto addReview, string userId);
    public checkforReviewDto checkforreview(Guid propertyid, string userid);
    //public IEnumerable<BookingDto> GetBookingsByPropertyId(Guid propertyId);
}
