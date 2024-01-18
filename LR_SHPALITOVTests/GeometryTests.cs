using Microsoft.VisualStudio.TestTools.UnitTesting;
using LR_SHPALITOV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR_SHPALITOV.Tests
{
    [TestClass()]
    public class GeometryTests
    {
        [TestMethod()]
        public void RectAreaTest()
        {
            int a = 5;
            int b = 2;
            int exp = 10;

            Geometry rect = new Geometry();

            int actual = rect.RectArea(a,b);
            Assert.AreEqual(exp, actual);

        }

        [TestMethod()]
        public void SquareAreaTest()
        {
            int a = 5;
            int exp = 25;

            Geometry square = new Geometry();

            int actual = square.SquareArea(a);
            Assert.AreEqual(exp, actual);

        }
        [TestMethod()]
        public void TriangleAreaTest()
        {
            int a = 5;
            int h = 6;
            int exp = 15;

            Geometry triangle = new Geometry();

            int actual = triangle.TriangleArea(a,h);
            Assert.AreEqual(exp, actual);

        }
        [TestMethod()]
        public void RhombAreaTest()
        {
            int d1 = 10;
            int d2 = 10;
            int exp = 50;

            Geometry rhomb = new Geometry();

            int actual = rhomb.RhombArea(d1,d2);
            Assert.AreEqual(exp, actual);

        }
        [TestMethod()]
        public void CircleAreaTest()
        {
            int r = 6;
            int exp = 113;

            Geometry circle = new Geometry();

            int actual = circle.CircleArea(r);
            Assert.AreEqual(exp, actual);

        }
        [TestMethod()]
        public void CubeAreaTest()
        {
            int a = 5;
            int exp = 150;

            Geometry cube = new Geometry();

            int actual = cube.CubeArea(a);
            Assert.AreEqual(exp, actual);

        }
        [TestMethod()]
        public void SphereAreaTest()
        {
            int r = 6;
            int exp = 452;

            Geometry sphere = new Geometry();

            int actual = sphere.SphereArea(r);
            Assert.AreEqual(exp, actual);

        }
        [TestMethod()]
        public void PrizmAreaTest()
        {
            int h = 5;
            int w = 5;
            int l = 6;
            int exp = 170;

            Geometry prizm = new Geometry();

            int actual = prizm.PrizmArea(w,h,l);
            Assert.AreEqual(exp, actual);

        }
        [TestMethod()]
        public void TrapezoidAreaTest()
        {
            int a = 6;
            int b = 10;
            int h = 5;
            int exp = 40;

            Geometry trapezoid = new Geometry();

            int actual = trapezoid.TrapezoidArea(a,b,h);
            Assert.AreEqual(exp, actual);

        }
        [TestMethod()]
        public void ParallelogramAreaTest()
        {
            int h = 5;
            int a = 10;
            int exp = 50;

            Geometry parallelogram = new Geometry();

            int actual = parallelogram.ParallelogramArea(a,h);
            Assert.AreEqual(exp, actual);

        }

    }
}