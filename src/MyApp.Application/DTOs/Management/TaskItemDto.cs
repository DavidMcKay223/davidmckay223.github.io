﻿using MyApp.Domain.Enums.Management;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Application.DTOs.Management
{
    public class TaskItemDto
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public bool IsCompleted { get; set; }
        public TaskType TaskType { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedDate { get; set; }
    }
}
