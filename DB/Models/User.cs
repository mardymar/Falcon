﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB.Models
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Salt { get; set; }
        [Column("First_Name")]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Column("Last_Name")]
        [StringLength(50)]
        public string LastName { get; set; }
        [Column("Break_Minutes")]
        public int BreakMinutes { get; set; }
        [Column("Phone_Number")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public int Role { get; set; }
        public string Email { get; set; }
        [Column("Image_Id")]
        public int? ImageId { get; set; }
        public string Description { get; set; }
        [Column("Team_Id")]
        public int? TeamId { get; set; }
        public bool Active { get; set; }
    }
}