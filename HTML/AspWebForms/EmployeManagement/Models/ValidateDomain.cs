﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace EmployeManagement.Models
{
    public class ValidateDomain:ValidationAttribute
    {
        private readonly string allowDomain;
        public ValidateDomain(string allowDomain) {
            this.allowDomain = allowDomain;
        }
        public override bool IsValid(object value)
        {
            string[] email = value.ToString().Split('@');
            if (email[1] == this.allowDomain)
            {
                return true;
            }
            return false;
        }
    }
}
