using System;
using Disc_Kompas.Logic;
using NUnit.Framework;

namespace Disc_Kompas.UnitTests
{
    public class DiscParamsUnitTests
    {
        private DiscParams discParams;
        [SetUp]
        public void SetUp()
        {
            discParams = new DiscParams(250, 69, 26, 200, 10, 4);
        }

        [Test(Description = "Проерка диаметра диска")]
        public void TestMainDiameterGet_CorrectValue()
        {
            var expected = 200;
            discParams.MainDiameter = expected;
            var actual = discParams.MainDiameter;
            Assert.AreEqual(expected, actual,
                "Проверка на правильные значения.");
        }

        [Test(Description = "Проверка толщины диска")]
        public void TestWidthGet_CorrectValue()
        {
            var expected = 30;
            discParams.Width = expected;
            var actual = discParams.Width;
            Assert.AreEqual(expected, actual, 
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка диаметра отверстия диска")]
        public void TestInsideDiameterGet_CorrectValue()
        {
            var expected = 30;
            discParams.InsideDiameter = expected;
            var actual = discParams.InsideDiameter;
            Assert.AreEqual(expected, actual, 
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка диаметра выреза граней")]
        public void TestCentralCutGet_CorrectValue()
        {
            var expected = 80;
            discParams.CentralCut = expected;
            var actual = discParams.CentralCut;
            Assert.AreEqual(expected, actual, 
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка глубины выреза граней")]
        public void TestDepthCutGet_CorrectValue()
        {
            var expected = 5;
            discParams.DepthCut = expected;
            var actual = discParams.DepthCut;
            Assert.AreEqual(expected, actual, 
                "Проверка на правильные значения");
        }

        [Test(Description = "Проверка угла скругления рёбер")]
        public void TestAngleGet_CorrectValue()
        {
            var expected = 5;
            discParams.Angle = expected;
            var actual = discParams.Angle;
            Assert.AreEqual(expected, actual, 
                "Проверка на правильные значения");
        }

        [TestCase(136, "Исключение, если число меньше граничных значений",
          TestName = "Присвоение меньшего числа - Диаметр диска")]
        [TestCase(252, "Исключение, если число больше граничных значений",
          TestName = "Присвоение большего числа - Диаметр диска")]
        public void TestBorderMainDiameterSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { discParams.MainDiameter = wrongParam; },
                message);
        }

        [TestCase(25, "Исключение, если число меньше граничных значений",
          TestName = "Присвоение меньшего числа - Толщина диска")]
        [TestCase(70, "Исключение, если число больше граничных значений",
          TestName = "Присвоение большего числа - Толщина диска")]
        public void TestBorderWidthSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { discParams.Width = wrongParam; },
                message);
        }

        [TestCase(25, "Исключение, если число меньше граничных значений",
          TestName = "Присвоение меньшего числа - Диаметр отверстия")]
        [TestCase(32, "Исключение, если число больше граничных значений",
          TestName = "Присвоение большего числа - Диаметр отверстия")]
        public void TestBorderInsideDiameterSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { discParams.InsideDiameter = wrongParam; },
                message);
        }

        [TestCase(79, "Исключение, если число меньше граничных значений",
          TestName = "Присвоение меньшего числа - Диаметр выреза граней")]
        [TestCase(222, "Исключение, если число больше граничных значений",
          TestName = "Присвоение большего числа - Диаметр выреза граней")]
        public void TestBorderCentralCutSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { discParams.CentralCut = wrongParam; },
                message);
        }

        [TestCase(4, "Исключение, если число меньше граничных значений",
         TestName = "Присвоение меньшего числа - Глубина выреза граней")]
        [TestCase(11, "Исключение, если число больше граничных значений",
         TestName = "Присвоение большего числа - Глубина выреза граней")]
        public void TestBorderDepthCutSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { discParams.DepthCut = wrongParam; },
                message);
        }

        [TestCase(0, "Исключение, если число меньше граничных значений",
         TestName = "Присвоение меньшего числа - Угол скругления рёбер")]
        [TestCase(11, "Исключение, если число больше граничных значений",
         TestName = "Присвоение большего числа - Угол скругления рёбер")]
        public void TestBorderAngleSet_ArgumentException(int wrongParam, string message)
        {
            Assert.Throws<ArgumentException>(
                () => { discParams.Angle = wrongParam; },
                message);
        }
    }
}

