using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSystem
{
     class Tasko
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Assignee { get; set; } 

        public ThreadPriority Priority { get; set; } 

        public TaskStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        //enum Status
        //{
        //    ToDo,
        //    InProgress,
        //    Completed
        //}

        //enum Priority
        //{
        //    Low, 
        //    Medium, 
        //    High
        //}

    }







}
