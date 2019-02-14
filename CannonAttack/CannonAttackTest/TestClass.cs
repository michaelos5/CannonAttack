﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using CannonAttack;

namespace CannonAttackTest
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestCannonIDValid()
        {
            Cannon cannon = Cannon.GetInstance();
            Assert.IsNotNull(cannon.ID);
        }

        [SetUp]
        public void ResetCannonObject()
        {
            Cannon cannon = Cannon.GetInstance();
            cannon.Reset();
        }

        [Test]
        public void TestCannonMultipleInstances()
        {
            Cannon cannon = Cannon.GetInstance();
            Cannon cannon2 = Cannon.GetInstance();
            Assert.IsTrue(cannon == cannon2);
        }

        [Test]
        public void TestCannonShootAngleIncorrect()
        {
            Cannon cannon = Cannon.GetInstance();
            var shot = cannon.Shoot(95, 100);
            Assert.IsFalse(shot.Item1);
        }

        [Test]
        public void TestCannonShootVelocityGreaterThanSpeedOfLight()
        {
            Cannon cannon = Cannon.GetInstance();
            var shot = cannon.Shoot(45, 300000001);
            Assert.IsFalse(shot.Item1);
        }

        [Test]
        public void TestCannonShootMiss()
        {
            Cannon cannon = Cannon.GetInstance();
            cannon.SetTarget(4000);
            var shot = cannon.Shoot(45, 350);
            Assert.IsTrue(shot.Item2 == "Missed cannonball landed at 12621 meters");
        }


        [Test]
        public void TestCannonShootHit()
        {
            Cannon cannon = Cannon.GetInstance();
            cannon.SetTarget(12621);
            var shot = cannon.Shoot(45, 350);
            Assert.IsTrue(shot.Item2 == "Hit - 1 Shot(s)");

        }

        [Test]
        public void TestCannonCountShots()
        {
            Cannon cannon = Cannon.GetInstance();
            cannon.SetTarget(12621);
            var shot = cannon.Shoot(45, 350);
            Assert.IsTrue(shot.Item2 == "Hit - 1 Shot(s)", "Number of shots:" + cannon.Shots);
        }

        //Additional Feature - ___
        [Test]
        public void TestCannonExplode()
        {
            Cannon cannon = Cannon.GetInstance();
            cannon.SetTarget(12621);
            var shot = cannon.Shoot(45, 100000001);
            Assert.IsTrue(shot.Item2 == "Cannon Exploded - Too much gunpowder(velocity) used");
        }

    }
}
