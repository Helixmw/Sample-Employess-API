﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Employees_API.Models
{
    public class EmployeeRole
    {
        public int Id { get; set; }

        public int EmployeeId { get; set; }

        public int RoleId { get; set; }

    }
}