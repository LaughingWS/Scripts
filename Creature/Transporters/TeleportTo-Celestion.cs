﻿using NexusForever.WorldServer.Game.Entity;
using System.Numerics;

namespace NexusForever.WorldServer.Script.Creature.Transporters
{
    [Script(32269)]
    public class TeleportTo_Celestion : CreatureScript
    {
        const ushort WLOC_Greenbough Glen = 51; // no world location, so this is 1 or 2 X or Z from the real spot
        private Vector3 LOC_Greenbough Glen = new Vector3(881.554f, -909.42f, -3130.06f);
        private Vector3 ROT_Greenbough Glen = new Vector3(0f, 0f, 0f);

        public override void OnActivateSuccess(WorldEntity me, WorldEntity activator)
        {
            if (activator is not Player player)
                return;

            if (!player.CanTeleport())
                return;

            player.Rotation = ROT_Greenbough Glen;
            player.TeleportTo(WLOC_Greenbough Glen, LOC_Greenbough Glen.X, LOC_Greenbough Glen.Y, LOC_Greenbough Glen.Z);

        }
    }
}
