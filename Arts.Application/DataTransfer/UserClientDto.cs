﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arts.Application.DataTransfer
{
    public class UserClientDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public CountryDto Country { get; set; }
    }
}
