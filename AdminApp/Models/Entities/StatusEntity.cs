using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApp.Models.Entities
{
    public enum TicketStatus
    {
        NotStarted = 1,
        InProgress = 2,
        Complete = 3
    }

    public class StatusEntity
    {
        [Key]
        public int Id { get; set; }
        public TicketStatus Status { get; set; }
    }
}
