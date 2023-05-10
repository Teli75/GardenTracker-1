﻿using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using Tracker.Models;

namespace Tracker.ViewModels
{
    public class AddBedViewModel
    {
        public int BedId { get; set; }
        //[Required(ErrorMessage ="Name is required ")]
        //[StringLength(30, MinimumLength =3, ErrorMessage = "Name must be between 2 and 30 characters long")]
        public string? Name { get; set; }

        public int SeedId { get; set; }

        public Bed? Bed { get; set; }

        public Seed? Seed { get; set; }
       
        public List<SelectListItem>? Beds { get; set; }
        public string? UserId { get; set; }

        public AddBedViewModel(Seed theSeed, List<Bed> possibleBeds)
        {

            Beds = new List<SelectListItem>();
            foreach (var bed in possibleBeds)
            {
                Beds.Add(new SelectListItem
                {
                    Value = bed.Id.ToString(),
                    Text = bed.Name,
                });
            }

            Seed = theSeed;
        }

        public AddBedViewModel()
        {
        }

    }
}


