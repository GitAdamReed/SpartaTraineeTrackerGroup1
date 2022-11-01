﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace TraineeTrackerApp.Models;

public class Spartan : IdentityUser
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }

    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }

    public Course Course { get; set; }

    public virtual ICollection<Week> Weeks { get; set; }
}