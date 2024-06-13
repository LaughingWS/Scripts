using NexusForever.WorldServer.Game.Entity;
using System.Numerics;

namespace NexusForever.WorldServer.Script.Creature.Transporters
{
    [Script(46980)]
    public class TeleportTo_Ellevar : CreatureScript
    {
        const ushort WLOC_Lightreach_Mission = 22;
        private Vector3 LOC_Lightreach_Mission = new Vector3(-2601.711f, -789.6452f, -3586.001f);
        private Vector3 ROT_Lightreach_Mission = new Vector3(0f, 0f, 0f);

        public override void OnActivateSuccess(WorldEntity me, WorldEntity activator)
        {
            if (activator is not Player player)
                return;

            if (!player.CanTeleport())
                return;

            player.Rotation = ROT_Lightreach_Mission;
            player.TeleportTo(WLOC_Lightreach_Mission, LOC_Lightreach_Mission.X, LOC_Lightreach_Mission.Y, LOC_Lightreach_Mission.Z);
        }
    }
}