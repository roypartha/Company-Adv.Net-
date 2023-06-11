using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab2_task_2.Models
{
    public class Teams
    {
      
        public string ServiceName{ get; set; }
        public string Name { get; set; }

        public Member[] Members { get; set; }
    }
}