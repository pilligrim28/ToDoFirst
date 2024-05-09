using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Entity
{
    internal class TaskEntity
    {
        public long id { get; set;}
        
        public string Name { get; set;}
       
        public string Description { get; set;}

        public Enum.Priority Priority { get; set;}


    }
}
