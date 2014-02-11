﻿using Entropy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TurnItUp.Components;

namespace TurnItUp.Characters
{
    public class PC : IEntityTemplate
    {
        public Entity Build(IWorld world)
        {
            Entity returnValue = world.CreateEntity();

            returnValue.AddComponent(new OnBoard());
            returnValue.AddComponent(new Position());
            returnValue.AddComponent(new InTeam("PCs"));
           
            return returnValue;
        }
    }
}
