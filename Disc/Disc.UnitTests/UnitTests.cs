using System;
using NUnit.Framework;

namespace Disc.UnitTests
{
    public class UnitTests
    {
        [Test(Description = "Позитивный тест геттера MainDiameter")]
        public void TestMainDiameterGet_CorrectValue()
        {
            var expected = 200;
            var discParams = new DiscParams(200, 250, 300, 10, 50, 100, 130, 100);
            discParams.MainDiameter = expected;
            var actual = discParams.MainDiameter;
            Assert.AreEqual(expected, actual, "Геттер MainDiameter возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера MainDiameter")]
        public void TestMainDiameterGet_BadValue()
        {
            var wrongMainDiameter = 99999;
            var discParams = new DiscParams(200, 250, 300, 10, 50, 100, 130, 100);
            Assert.Throws<ArgumentException>(() => { discParams.MainDiameter = wrongMainDiameter; }, "-");
        }

        [Test(Description = "Позитивный тест геттера Width")]
        public void TestWidthGet_CorrectValue()
        {
            var expected = 30;
            var discParams = new DiscParams(10, 30, 34, 5, 20, 60, 65, 1);
            discParams.Width = expected;
            var actual = discParams.Width;
            Assert.AreEqual(expected, actual, "Геттер Width возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера Length")]
        public void TestWidthGet_BadValue()
        {
            var wrongWidth = 99999;
            var discParams = new DiscParams(10, 30, 34, 5, 20, 60, 65, 1);
            Assert.Throws<ArgumentException>(() => { discParams.Width = wrongWidth; }, "-");
        }

        [Test(Description = "Позитивный тест геттера Width")]
        public void TestInsideDiameterGet_CorrectValue()
        {
            var expected = 30;
            var discParams = new DiscParams(10, 30, 34, 5, 20, 28, 65, 1);
            discParams.InsideDiameter = expected;
            var actual = discParams.InsideDiameter;
            Assert.AreEqual(expected, actual, "Геттер InsideDiameter возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера InsideDiameter")]
        public void TestInsideDiameterGet_BadValue()
        {
            var wrongInsideDiameter = 99999;
            var discParams = new DiscParams(10, 30, 34, 5, 20, 28, 65, 1);
            Assert.Throws<ArgumentException>(() => { discParams.InsideDiameter = wrongInsideDiameter; }, "-");
        }

        [Test(Description = "Позитивный тест геттера CentralCut")]
        public void TestCentralCutGet_CorrectValue()
        {
            var expected = 80;
            var discParams = new DiscParams(100, 1, 80, 10, 90, 85, 40, 90);
            discParams.CentralCut = expected;
            var actual = discParams.CentralCut;
            Assert.AreEqual(expected, actual, "Геттер CentralCut возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера CentralCut")]
        public void TestCentralCutGet_BadValue()
        {
            var wrongCentralCut = 99999;
            var discParams = new DiscParams(100, 1, 80, 10, 90, 85, 40, 90);
            Assert.Throws<ArgumentException>(() => { discParams.CentralCut = wrongCentralCut; }, "-");
        }

        [Test(Description = "Позитивный тест геттера DepthCut")]
        public void TestDepthCutGet_CorrectValue()
        {
            var expected = 5;
            var discParams = new DiscParams(20, 10, 5, 1, 4, 6, 8, 7);
            discParams.DepthCut = expected;
            var actual = discParams.DepthCut;
            Assert.AreEqual(expected, actual, "Геттер DepthCut возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера DepthCut")]
        public void TestDepthCutGet_BadValue()
        {
            var wrongDepthCut = 99999;
            var discParams = new DiscParams(20, 10, 5, 1, 4, 6, 8, 7);
            Assert.Throws<ArgumentException>(() => { discParams.DepthCut = wrongDepthCut; }, "-");
        }

        [Test(Description = "Позитивный тест геттера Angle")]
        public void TestAngleGet_CorrectValue()
        {
            var expected = 5;
            var discParams = new DiscParams(20, 10, 5, 1, 40, 6, 8, 7);
            discParams.Angle = expected;
            var actual = discParams.Angle;
            Assert.AreEqual(expected, actual, "Геттер Angle возвращает неправильное значение.");
        }

        [Test(Description = "Негативный тест геттера Angle")]
        public void TestAngleGet_BadValue()
        {
            var wrongAngle = 5;
            var discParams = new DiscParams(20, 10, 5, 1, 40, 6, 8, 7);
            Assert.Throws<ArgumentException>(() => { discParams.Angle = wrongAngle; }, "-");
        }
    }
}
