﻿using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApp.Models.Entities
{
    internal class CommentEntity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string CommentText { get; set; } = null!;

        public DateTime CommentDateTime { get; set; }


        //FK
        [Required]
        public int TicketId { get; set; }
        public TicketEntity Ticket { get; set; } = null!;
    }
}
