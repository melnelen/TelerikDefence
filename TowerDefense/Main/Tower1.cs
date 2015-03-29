﻿using System.Collections.Generic;
using System.Windows.Media;
using TowerDefense.Interfaces;
using TowerDefense.Utils;

namespace TowerDefense.Main
{
    public class Tower1 : Tower
    {

        public Tower1(Point position)
            : base(position)
        {
            this.range = 4000;
            this.rate = 1000;
            this.damage = 10;
            this.price = 100;
        }

        public override IEnumerable<IGameObject> ProducedObjects
        {
            get{ return projectilesToAdd; }
        }

        public override ImageSource ImageSource
        {
            get{ return ImageFactory.CreateImage("cpp.png"); }
        }

        public override void Update()
        {
            projectileTimerCounter--;
            projectilesToAdd.Clear();
            if (this.Target != null && this.Target.IsDestroyed == true)
            {
                this.Target = null;
            }
        }

        public override void Shoot(IEnumerable<ITarget> targetsSet)
        {
            base.Shoot(targetsSet);
            if (this.Target != null && projectileTimerCounter < 0)
            {
                Projectile projectile = new Projectile(new Point(this.Position.X, this.Position.Y),
                                                        this.Damage,
                                                        10,
                                                        this.Target);
                projectileTimerCounter = rate / 100; //async timer value
                projectilesToAdd.Add(projectile);
            }
        }
    }
}
