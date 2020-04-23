using System;
using Disc_Kompas.Logic;
using NUnit.Framework;

namespace Disc_Kompas.UnitTests
{
    public class UnitTests
    {
        [Test(Description = "Позитивный тест геттера MainDiameter")]
        public void TestMainDiameterGet_CorrectValue()
        {
            var expected = 200;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            discParams.MainDiameter = expected;
            var actual = discParams.MainDiameter;
            Assert.AreEqual(expected, actual, "Геттер MainDiameter возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера MainDiameter")]
        public void TestMainDiameterGet_BadValue()
        {
            var wrongMainDiameter = 99999;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            Assert.Throws<ArgumentException>(() => { discParams.MainDiameter = wrongMainDiameter; }, "-");
        }

        [Test(Description = "Позитивный тест геттера Width")]
        public void TestWidthGet_CorrectValue()
        {
            var expected = 30;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            discParams.Width = expected;
            var actual = discParams.Width;
            Assert.AreEqual(expected, actual, "Геттер Width возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера Length")]
        public void TestWidthGet_BadValue()
        {
            var wrongWidth = 99999;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            Assert.Throws<ArgumentException>(() => { discParams.Width = wrongWidth; }, "-");
        }

        [Test(Description = "Позитивный тест геттера Width")]
        public void TestInsideDiameterGet_CorrectValue()
        {
            var expected = 30;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            discParams.InsideDiameter = expected;
            var actual = discParams.InsideDiameter;
            Assert.AreEqual(expected, actual, "Геттер InsideDiameter возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера InsideDiameter")]
        public void TestInsideDiameterGet_BadValue()
        {
            var wrongInsideDiameter = 99999;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            Assert.Throws<ArgumentException>(() => { discParams.InsideDiameter = wrongInsideDiameter; }, "-");
        }

        [Test(Description = "Позитивный тест геттера CentralCut")]
        public void TestCentralCutGet_CorrectValue()
        {
            var expected = 80;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            discParams.CentralCut = expected;
            var actual = discParams.CentralCut;
            Assert.AreEqual(expected, actual, "Геттер CentralCut возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера CentralCut")]
        public void TestCentralCutGet_BadValue()
        {
            var wrongCentralCut = 99999;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            Assert.Throws<ArgumentException>(() => { discParams.CentralCut = wrongCentralCut; }, "-");
        }

        [Test(Description = "Позитивный тест геттера DepthCut")]
        public void TestDepthCutGet_CorrectValue()
        {
            var expected = 5;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            discParams.DepthCut = expected;
            var actual = discParams.DepthCut;
            Assert.AreEqual(expected, actual, "Геттер DepthCut возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера DepthCut")]
        public void TestDepthCutGet_BadValue()
        {
            var wrongDepthCut = 99999;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            Assert.Throws<ArgumentException>(() => { discParams.DepthCut = wrongDepthCut; }, "-");
        }

        [Test(Description = "Позитивный тест геттера Angle")]
        public void TestAngleGet_CorrectValue()
        {
            var expected = 5;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            discParams.Angle = expected;
            var actual = discParams.Angle;
            Assert.AreEqual(expected, actual, "Геттер Angle возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера Angle")]
        public void TestAngleGet_BadValue()
        {
            var wrongAngle = 99999;
            var discParams = new DiscParams(250, 69, 26, 200, 10, 4);
            Assert.Throws<ArgumentException>(() => { discParams.Angle = wrongAngle; }, "-");
        }
    }
}
