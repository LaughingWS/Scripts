using NexusForever.WorldServer.Game.Entity;
using System.Numerics;

namespace NexusForever.WorldServer.Script.Creature.City.Thayd
{
    [Script(51207)]
    public class TeleportTo_ShinysandOasis : CreatureScript
    {
        const ushort WLOC_Shinysand_Oasis = 1061;
        private Vector3 LOC_Shinysand_Oasis = new Vector3(1690.919f, -954.847f, 4053.637f);
        private Vector3 ROT_Shinysand_Oasis = new Vector3(0f, 0f, 0f);

        public override void OnActivateSuccess(WorldEntity me, WorldEntity activator)
        {
            if (activator is not Player player)
                return;

            if (!player.CanTeleport())
                return;

            player.Rotation = ROT_Shinysand_Oasis;
            player.TeleportTo(WLOC_Shinysand_Oasis, LOC_Shinysand_Oasis.X, LOC_Shinysand_Oasis.Y, LOC_Shinysand_Oasis.Z);
        }
    }
}