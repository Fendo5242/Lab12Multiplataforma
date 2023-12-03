using System;
using System.Collections.Generic;
using System.Text;

namespace DemoMVVMB.Models
{
    public class TaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public bool Status { get; set; }

        public TaskModel() { }
    }
}
