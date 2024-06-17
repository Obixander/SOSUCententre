using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.Entities
{
    public class SubTask
    {
        private int subTaskId;
        private string name;
        private bool isCompleted;

        public SubTask(int subTaskId, string name, bool isCompleted)
        {
            SubTaskId = subTaskId;
            Name = name;
            IsCompleted = isCompleted;
        }


        public SubTask()
        {
            
        }

        public int SubTaskId
        {
            get => subTaskId;
            set => subTaskId = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public bool IsCompleted
        {
            get => isCompleted;
            set => isCompleted = value;
        }
    }
}
