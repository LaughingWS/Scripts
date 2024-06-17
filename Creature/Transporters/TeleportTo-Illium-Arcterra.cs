using NexusForever.WorldServer.Game.Entity;
using System.Numerics;

namespace NexusForever.WorldServer.Script.Creature.Transporters
{
    [Script(70781)]
    public class TeleportTo_Illium_Arcterra : CreatureScript
    {
        const ushort WLOC_Illium_Arcterra = 22;
        private Vector3 LOC_Illium_Arcterra = new Vector3(3535.93f, -878.0894f, -850.208f);
        private Vector3 ROT_Illium_Arcterra = new Vector3(0f, 0f, 0f);

        public override void OnActivateSuccess(WorldEntity me, WorldEntity activator)
        {
            if (activator is not Player player)
                return;

            if (!player.CanTeleport())
                return;

            player.Rotation = ROT_Illium_Arcterra;
            player.TeleportTo(WLOC_Illium_Arcterra, LOC_Illium_Arcterra.X, LOC_Illium_Arcterra.Y, LOC_Illium_Arcterra.Z);
        }
    }
}