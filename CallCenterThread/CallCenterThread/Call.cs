using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterThread
{
    class Call
    {
        public Call(int number, int id, int duration)
        {
            Number = number;
            Id = id;
            Duration = duration;
            Status = Statuses.NotStarted;
        }

        public int Number { get; set; }
        public int Duration { get; set; }
        public int Id { get; set; }
        public Statuses Status { get; set; }
    }

    

}
