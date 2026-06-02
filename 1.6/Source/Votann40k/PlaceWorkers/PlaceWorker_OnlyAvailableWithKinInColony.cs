using System.Linq;
using Verse;

namespace Votann40k;

public class PlaceWorker_OnlyAvailableWithKinInColony : PlaceWorker
{
    public override AcceptanceReport AllowsPlacing(BuildableDef checkingDef, IntVec3 loc, Rot4 rot, Map map, Thing thingToIgnore = null, Thing thing = null)
    {
        if (map.mapPawns.FreeColonistsSpawned.Where(pawn => pawn.genes != null).Any(pawn => pawn.genes.HasActiveGene(Votann40kDefOf.BEWH_KinCloneskein)))
        {
            return true;
        }
        
        return "BEWH.Votann.PlacementLimit.RequiresKin".Translate(((ThingDef)checkingDef).label.CapitalizeFirst());
    }
}