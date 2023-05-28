using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Vector3D
    {
        public int x; public int y; public int z;
        public void mult(int x, int y, int z)
        {
            x *= this.x;
            y *= this.y;
            z *= this.z;
        }
        public void plus(int x, int y, int z)
        {
            x += this.x;
            y += this.y;
            z += this.z;
        }
        public void minus(int x, int y, int z)
        {
            x -= this.x;
            y -= this.y;
            z -= this.z;
        }
    }
}
