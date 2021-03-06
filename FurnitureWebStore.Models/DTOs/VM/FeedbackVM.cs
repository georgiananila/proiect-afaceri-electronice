using FurnitureWebStore.Models.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FurnitureWebStore.Models.DTOs.VM
{
    public class FeedbackVM
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string CommentTitle { get; set; }
        public string Comment { get; set; }

        [Required]
        public int Rating { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public Guid? UserId { get; set; }

    }
}
