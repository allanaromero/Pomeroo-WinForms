using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pomeroo.Models
{
    public static class TimerModel
    {
        public static int workTime { get; set; } = 1500;
        public static int shortRest { get; set; } = 300;
        public static int longRest { get; set; } = 900;
        public static int cycleCount { get; set; } = 4;
    }
}
