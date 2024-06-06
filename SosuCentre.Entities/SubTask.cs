using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class SubTask
    {
        public int SubTaskId
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public bool IsCompleted
        { 
            get;
            set;
        }
    }
}
