﻿using Airbnb.BL;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using Airbnb.DAL;

namespace Airbnb.API;

//public class NoCollidingDateRangeAttribute : ActionFilterAttribute
//{
//    private readonly IPropertyManager _propertyManager;

//    public NoCollidingDateRangeAttribute(IPropertyManager propertyManager)
//    {
//        _propertyManager = propertyManager;
//    }

//    public override void OnActionExecuting(ActionExecutingContext context)
//    {
//        var bookingDto = context.ActionArguments["booking"] as AddBookingDto;

//        if (bookingDto != null)
//        {
//            IEnumerable<BookingDto> propertyBookings = _propertyManager.GetBookingsByPropertyId(bookingDto.PropertyId);

//            if (propertyBookings != null && propertyBookings.Any(range =>
//                (bookingDto.StartDate < range.CheckOutDate && bookingDto.EndDate > range.CheckInDate) ||
//                (bookingDto.StartDate < range.CheckInDate && bookingDto.EndDate > range.CheckInDate) ||
//                (bookingDto.StartDate < range.CheckOutDate && bookingDto.EndDate > range.CheckOutDate) ||
//                (bookingDto.StartDate == range.CheckInDate && bookingDto.EndDate == range.CheckInDate) ||
//                (bookingDto.StartDate == range.CheckOutDate && bookingDto.EndDate == range.CheckOutDate)))
//            {
//                context.ModelState.AddModelError("Booking", "The booking date range is colliding with existing bookings.");
//            }
//        }

//        base.OnActionExecuting(context);
//    }
//}


