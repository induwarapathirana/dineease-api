﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace webapi.Models;

[PrimaryKey("MealId", "FoodId")]
[Table("Meal_foods")]
[Index("FoodId", Name = "IX_Meal_foods_food_id")]
public partial class MealFoods
{
    [Key]
    [Column("meal_id")]
    public int MealId { get; set; }

    [Key]
    [Column("food_id")]
    public Guid FoodId { get; set; }

    [Column("quantity")]
    public int Quantity { get; set; }

    [Column("total_price")]
    public double TotalPrice { get; set; }

    [ForeignKey("FoodId")]
    [InverseProperty("MealFoods")]
    public virtual Food Food { get; set; }

    [ForeignKey("MealId")]
    [InverseProperty("MealFoods")]
    public virtual Meal Meal { get; set; }
}