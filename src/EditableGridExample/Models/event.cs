using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EditableGridExample.Models
{
    public partial class Event
    {
        public Event() { }

        public string ID { get; set; }
        public string contactID { get; set; }
        public string description { get; set; }
        public string typeID { get; set; }
        public string altID { get; set; }
        public string active { get; set; }
        public string createdDate { get; set; }
        public string updatedDate { get; set; }
        public string updatedBy { get; set; }
    }
}