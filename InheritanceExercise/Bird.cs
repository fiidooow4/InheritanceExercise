using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class Bird : Animal
    {
        public Bird()
        {
           
        }

        public string WingColor { get; set; }
        public bool CanFly { get; set; }
        public bool DoMigrate { get; set; }
        public double BeakLength { get; set; }

        // Additional methods or properties specific to Bird can be added here
    }
}
