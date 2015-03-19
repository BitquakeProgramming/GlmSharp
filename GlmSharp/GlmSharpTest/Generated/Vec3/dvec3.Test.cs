using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Vec3
{
    [TestFixture]
    public class DoubleVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec3(-9.5d);
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var v = new dvec3(-5.5d, -3.5d, -2);
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var v = new dvec3(new dvec2(8, -7.5d));
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var v = new dvec3(new dvec3(-1.5d, -9, 9.5d));
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(9.5d, v.z);
            }
            {
                var v = new dvec3(new dvec4(5, 4, -9, 0.5d));
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-9, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec3(0.0, 2, 5.5d);
            Assert.AreEqual(0.0, v[0]);
            Assert.AreEqual(2, v[1]);
            Assert.AreEqual(5.5d, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[1] = 0.0;
            Assert.AreEqual(0.0, v[1]);
            v[0] = 1.0;
            Assert.AreEqual(1.0, v[0]);
            v[2] = 2;
            Assert.AreEqual(2, v[2]);
            v[1] = 3;
            Assert.AreEqual(3, v[1]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[2] = 9;
            Assert.AreEqual(9, v[2]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[2] = -3;
            Assert.AreEqual(-3, v[2]);
            v[2] = -4;
            Assert.AreEqual(-4, v[2]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[0] = -9;
            Assert.AreEqual(-9, v[0]);
            v[2] = -9.5d;
            Assert.AreEqual(-9.5d, v[2]);
            v[1] = -8.5d;
            Assert.AreEqual(-8.5d, v[1]);
            v[1] = -7.5d;
            Assert.AreEqual(-7.5d, v[1]);
            v[1] = -6.5d;
            Assert.AreEqual(-6.5d, v[1]);
            v[2] = -5.5d;
            Assert.AreEqual(-5.5d, v[2]);
            v[1] = -4.5d;
            Assert.AreEqual(-4.5d, v[1]);
            v[1] = -3.5d;
            Assert.AreEqual(-3.5d, v[1]);
            v[1] = -2.5d;
            Assert.AreEqual(-2.5d, v[1]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[2] = -0.5d;
            Assert.AreEqual(-0.5d, v[2]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[2] = 1.5d;
            Assert.AreEqual(1.5d, v[2]);
            v[0] = 2.5d;
            Assert.AreEqual(2.5d, v[0]);
            v[1] = 3.5d;
            Assert.AreEqual(3.5d, v[1]);
            v[0] = 4.5d;
            Assert.AreEqual(4.5d, v[0]);
            v[2] = 5.5d;
            Assert.AreEqual(5.5d, v[2]);
            v[1] = 6.5d;
            Assert.AreEqual(6.5d, v[1]);
            v[0] = 7.5d;
            Assert.AreEqual(7.5d, v[0]);
            v[2] = 8.5d;
            Assert.AreEqual(8.5d, v[2]);
            v[0] = 9.5d;
            Assert.AreEqual(9.5d, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new dvec3(4.5d, 1.0, 9);
            var vals = v.Values;
            Assert.AreEqual(4.5d, vals[0]);
            Assert.AreEqual(1.0, vals[1]);
            Assert.AreEqual(9, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, dvec3.Zero.x);
            Assert.AreEqual(0.0, dvec3.Zero.y);
            Assert.AreEqual(0.0, dvec3.Zero.z);
            
            Assert.AreEqual(1.0, dvec3.Ones.x);
            Assert.AreEqual(1.0, dvec3.Ones.y);
            Assert.AreEqual(1.0, dvec3.Ones.z);
            
            Assert.AreEqual(1.0, dvec3.UnitX.x);
            Assert.AreEqual(0.0, dvec3.UnitX.y);
            Assert.AreEqual(0.0, dvec3.UnitX.z);
            
            Assert.AreEqual(0.0, dvec3.UnitY.x);
            Assert.AreEqual(1.0, dvec3.UnitY.y);
            Assert.AreEqual(0.0, dvec3.UnitY.z);
            
            Assert.AreEqual(0.0, dvec3.UnitZ.x);
            Assert.AreEqual(0.0, dvec3.UnitZ.y);
            Assert.AreEqual(1.0, dvec3.UnitZ.z);
            
            Assert.AreEqual(double.MaxValue, dvec3.MaxValue.x);
            Assert.AreEqual(double.MaxValue, dvec3.MaxValue.y);
            Assert.AreEqual(double.MaxValue, dvec3.MaxValue.z);
            
            Assert.AreEqual(double.MinValue, dvec3.MinValue.x);
            Assert.AreEqual(double.MinValue, dvec3.MinValue.y);
            Assert.AreEqual(double.MinValue, dvec3.MinValue.z);
            
            Assert.AreEqual(double.Epsilon, dvec3.Epsilon.x);
            Assert.AreEqual(double.Epsilon, dvec3.Epsilon.y);
            Assert.AreEqual(double.Epsilon, dvec3.Epsilon.z);
            
            Assert.AreEqual(double.NaN, dvec3.NaN.x);
            Assert.AreEqual(double.NaN, dvec3.NaN.y);
            Assert.AreEqual(double.NaN, dvec3.NaN.z);
            
            Assert.AreEqual(double.NegativeInfinity, dvec3.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, dvec3.NegativeInfinity.y);
            Assert.AreEqual(double.NegativeInfinity, dvec3.NegativeInfinity.z);
            
            Assert.AreEqual(double.PositiveInfinity, dvec3.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, dvec3.PositiveInfinity.y);
            Assert.AreEqual(double.PositiveInfinity, dvec3.PositiveInfinity.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new dvec3(6, 0.0, -2.5d);
            var v2 = new dvec3(6, 0.0, -2.5d);
            var v3 = new dvec3(-2.5d, 0.0, 6);
            Assert.That(v1 == new dvec3(v1));
            Assert.That(v2 == new dvec3(v2));
            Assert.That(v3 == new dvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new dvec3(8.5d, 6.5d, 1.5d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = dvec3.Parse(s0);
            var v1 = dvec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = dvec3.TryParse(s0, out v0);
            var b1 = dvec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = dvec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = dvec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = dvec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { dvec3.Parse(null); });
            Assert.Throws<FormatException>(() => { dvec3.Parse(""); });
            Assert.Throws<FormatException>(() => { dvec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = dvec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = dvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = dvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

    }
}
