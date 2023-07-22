﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airbnb.BL;

    public interface IUserMangers
    {
    Usertypedto GetUserType(string Id);
    GuestProfileReedDTO GuestProfileRead(string userId);
    bool UpdateGuestInfo(GuestProfileUpdateDto guestInfo, string userId);
}

