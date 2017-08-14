using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingColorClasses
{
    class Ball
    {
        private Color color;

        private float radius;

        private int timesThrown;

        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.timesThrown = 0;
        }

        public void Pop()
        {
            radius = 0;
        }

        public void Throw()
        {
            if (radius > 0)
            {
                timesThrown++;
            }
        }

        public int GetTimesThrown()
        {
            return timesThrown;
        }
    }
}
