using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterCapstone.FormApp.Models
{
    public class Servo
    {
        public int CurrentPostion { get; set; }

        private string _status;
        public string Status
        {
            get { return _status; }
            set
            {
                // Set B to some new value
                _status = value;

                // Assign C
                Status = CurrentPostion == 120 ? _status = "OPEN" : _status = "CLOSED";
            }
        }
    }
}
