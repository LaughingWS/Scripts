using NexusForever.WorldServer.Game.Entity;
using System.Numerics;

namespace NexusForever.WorldServer.Script.Creature.City.Thayd
{
    [Script(67487)]
    public class TeleportTo_Walkers_Landing : CreatureScript
    {
        const ushort WLOC_Walkers_Landing = 1421;
        private Vector3 LOC_Walkers_Landing = new Vector3(5924.933f, -492.9271f, -4965.473f);
        private Vector3 ROT_Walkers_Landing = new Vector3(0f, 0f, 0f);

        public override void OnActivateSuccess(WorldEntity me, WorldEntity activator)
        {
            if (activator is not Player player)
                return;

            if (!player.CanTeleport())
                return;

            player.Rotation = ROT_Walkers_Landing;
            player.TeleportTo(WLOC_Walkers_Landing, LOC_Walkers_Landing.X, LOC_Walkers_Landing.Y, LOC_Walkers_Landing.Z);
        }
    }
}