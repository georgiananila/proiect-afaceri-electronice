﻿using System.ComponentModel.DataAnnotations;

namespace FurnitureWebStore.Models.DTOs.VM
{
    public class ProductTypeVM
    {
        public int Id { get; set; }
        //validari
        [Required]//null,empty
        [MaxLength(255)]//lungime
        public string Name { get; set; }
    }
}
