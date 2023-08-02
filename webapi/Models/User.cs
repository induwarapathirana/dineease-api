﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

[Table("User", Schema = "userMGT")]
[Index("Email", Name = "IX_User", IsUnique = true)]
public partial class User
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Required]
    [Column("username")]
    [StringLength(10)]
    [Unicode(false)]
    public string Username { get; set; }

    [Required]
    [Column("name")]
    [StringLength(20)]
    public string Name { get; set; }

    [Column("address")]
    public string Address { get; set; }

    [Column("phone")]
    [StringLength(12)]
    [Unicode(false)]
    public string Phone { get; set; }

    [Required]
    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string Email { get; set; }

    [Column("user_image", TypeName = "text")]
    public string UserImage { get; set; }

    [Column("user_image_type")]
    [StringLength(6)]
    [Unicode(false)]
    public string UserImageType { get; set; }

    [Column("created_date", TypeName = "date")]
    public DateTime CreatedDate { get; set; }

    [InverseProperty("User")]
    public virtual Authentication Authentication { get; set; }

    [InverseProperty("User")]
    public virtual Customer Customer { get; set; }

    [InverseProperty("User")]
    public virtual Staff Staff { get; set; }

    [ForeignKey("UserId")]
    [InverseProperty("User")]
    public virtual ICollection<Food> Food { get; set; } = new List<Food>();
}