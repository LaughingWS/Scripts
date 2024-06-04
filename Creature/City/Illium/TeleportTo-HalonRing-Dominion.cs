using NexusForever.WorldServer.Game.Entity;
using System.Numerics;

namespace NexusForever.WorldServer.Script.Creature.City.Illium
{
    [Script(46182)]
    public class TeleportTo_HalonRing : CreatureScript
    {
        const ushort WLOC_Graylight = 1068;
        private Vector3 LOC_Graylight = new Vector3(-11881.4f, 79.80159f, -3934.09f);
        private Vector3 ROT_Graylight = new Vector3(0f, 0f, 0f);

        public override void OnActivateSuccess(WorldEntity me, WorldEntity activator)
        {
            if (activator is not Player player)
                return;

            if (!player.CanTeleport())
                return;

            player.Rotation = ROT_Graylight;
            player.TeleportTo(WLOC_Graylight, LOC_Graylight.X, LOC_Graylight.Y, LOC_Graylight.Z);
        }
    }
}
