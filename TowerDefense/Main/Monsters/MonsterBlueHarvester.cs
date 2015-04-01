﻿namespace TowerDefense.Main.Monsters
{
    using System;
    using System.Linq;
    using System.Windows.Media;
    using TowerDefense.Interfaces;
    using TowerDefense.Utils;
    
    class MonsterBlueHarvester : Monster//, IMonster, IGameObject, IMovable, ITarget - Commented because of team rule.
    {
        public MonsterBlueHarvester(IRoute route)
            : base(route, 80, 90, 175)
        {
            this.ImageFIles.Add("monsters/BlueHarvester/MonsterBlueHarvester0.png");
            this.ImageFIles.Add("monsters/BlueHarvester/MonsterBlueHarvester1.png");
            this.ImageFIles.Add("monsters/BlueHarvester/MonsterBlueHarvester2.png");
            this.IsDestroyed = false;
        }
    }
}