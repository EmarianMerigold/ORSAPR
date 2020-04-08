using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disc
{
    class DiscParams
    {
        private int _mainDiameter;
        private int _width;
        private int _insideDiameter;
        private int _centralCut;
        private int _depthCut;
        private int _angle;
        

        //Property;

        public int MainDiameter { get; set; }
        public int Width { get; set; }
        public int InsideDiameter { get; set; }
        public int CentralCut { get; set; }
        public int DepthCut { get; set; }
        public int Angle { get; set; }
    }
}
