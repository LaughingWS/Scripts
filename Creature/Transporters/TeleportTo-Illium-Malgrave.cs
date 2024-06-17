using NexusForever.WorldServer.Game.Entity;
using System.Numerics;

namespace NexusForever.WorldServer.Script.Creature.Transporters
{
    [Script(51204)]
    public class TeleportTo_Illium_Malgrave : CreatureScript
    {
        const ushort WLOC_Illium_Malgrave = 22;
        private Vector3 LOC_Illium_Malgrave = new Vector3(-3624.016f, -878.0894f, -640.4051f);
        private Vector3 ROT_Illium_Malgrave = new Vector3(0f, 0f, 0f);

        public override void OnActivateSuccess(WorldEntity me, WorldEntity activator)
        {
            if (activator is not Player player)
                return;

            if (!player.CanTeleport())
                return;

            player.Rotation = ROT_Illium_Malgrave;
            player.TeleportTo(WLOC_Illium_Malgrave, LOC_Illium_Malgrave.X, LOC_Illium_Malgrave.Y, LOC_Illium_Malgrave.Z);
        }
    }
}
