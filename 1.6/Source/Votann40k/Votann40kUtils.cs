using System.Collections.Generic;
using Verse;

namespace Votann40k;

public static class Votann40kUtils
{
    private static readonly List<Pawn> tmpPawns = new List<Pawn>();
    
    public static readonly CachedTexture RefreshIcon = new ("UI/Misc/BEWH_Refresh");
    
    public static int TotalBuriedKin()
    {
        var result = 0;
        var maps = Find.Maps;
        foreach (var map in maps)
        {
            var thing = map.listerThings.ThingsOfDef(Votann40kDefOf.BEWH_AncestorCore).FirstOrFallback();
            if (thing is not Building_AncestorCore core)
            {
                continue;
            }
            
            result += core.StoredKin;
        }
        return result;
    }
}