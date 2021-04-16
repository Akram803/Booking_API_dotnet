﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Booking_taskApi.Models
{
    public partial class Notes
    {
        [Key]
        public int Id { get; set; }
        [Column("UserID")]
        public int? UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Title { get; set; }
        [Column(TypeName = "text")]
        public string Description { get; set; }
        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }
    }
}