﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    [Table("Managements_Reference")]
    public partial class ManagementsReference
    {
        [Key]
        public int Id { get; set; }
        public int Reference { get; set; }
    }
}