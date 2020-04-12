using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disc
{
    /// <summary>
    /// Класс, который содержит в себе поля для параметров диска.
    /// </summary>
    class DiscParams
    {
        private int _mainDiameter;
        private int _width;
        private int _insideDiameter;
        private int _centralCut;
        private int _depthCut;
        private int _angle;

        /// <summary>
        /// Конструктор класса HiveParams
        /// </summary>
        /// <param name="mainDiameter"> Внешний диаметр диска</param>
        /// <param name="width"> Толщина диска</param>
        /// <param name="insideDiameter"> Внутренний диаметр диска</param>
        /// <param name="centralCut"> Центральны вырез диска</param>
        /// <param name="depthCut"> Глубина выреза диска</param>
        /// <param name="angle"> Угол скругления рёбер диска</param>
        public DiscParams(int mainDiameter, int width, int insideDiameter, int centralCut, int depthCut, int angle)
        {
            MainDiameter = mainDiameter;
            Width = width;
            InsideDiameter = insideDiameter;
            CentralCut = centralCut;
            DepthCut = depthCut;
            Angle = angle;
        }

        //Property;

        public int MainDiameter
        {
            get => _mainDiameter;
            set
            {
                if (value < 137 || value > 251)
                {
                    throw new ArgumentException("Значение должно находиться в диапазоне от 137 до 251");
                }

                _mainDiameter = value;
            }
        }
        public int Width
        {
            get => _width;
            set
            {
                if (value < 26 || value > 69)
                {
                    throw new ArgumentException("Значение должно находится в диапазоне от 26 до 69");
                }

                _width = value;
            }

        }
        public int InsideDiameter
        {
            get => _insideDiameter;
            set
            {
                if (value < 26 || value > 31)
                {
                    throw new ArgumentException("Значение должно находится в диапазоне от 28 до 31");
                }

                _insideDiameter = value;
            }
        }
        public int CentralCut
        {
            get => _centralCut;
            set
            {
                if (value < 80 || value > (MainDiameter - 30))
                {
                    throw new ArgumentException("Значение должно находится в диапазоне от 80 до D - 30");
                }

                _centralCut = value;
            }
        }
        public int DepthCut
        {
            get => _depthCut;
            set
            {
                if (value < 5 || value > 10)
                {
                    throw new ArgumentException("Значение должно находится в диапазоне от 5 до 10");
                }

                _depthCut = value;
            }
        }
        public int Angle
        {
            get => _angle;
            set
            {
                if (value < 1 || value > 10)
                {
                    throw new ArgumentException("Значение должно находиться в диапазоне от 1 до 10");
                }

                _angle = value;
            }
        }
    }
}

