﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthWithPhotoMVC.Data
{
    public class ApplicationUser : IdentityUser
    {
        public byte[] Photo { get; set; }
    }
}
