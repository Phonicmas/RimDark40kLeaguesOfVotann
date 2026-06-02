using RimWorld;
using Verse;


namespace Votann40k;

[DefOf]
public static class Votann40kDefOf
{
    //JobDef
    public static JobDef BEWH_CarryKinToAncestorCore;
    public static JobDef BEWH_OpenContractWindow;
    
    //GeneDef
    public static GeneDef BEWH_KinGrudgy;
    public static GeneDef BEWH_KinClanLoyalty;
    public static GeneDef BEWH_KinCloneskein;
    
    //ThingDef
    public static ThingDef BEWH_AncestorCore;
    public static ThingDef BEWH_KinCrucible;
    
    //XenotypeDef
    public static XenotypeDef BEWH_Kin;
    
    //ResearchProjectDef
    public static ResearchProjectDef TransportPod;
    
    //FactionDef
    public static FactionDef BEWH_OffworldKinFaction;

    static Votann40kDefOf()
    {
        DefOfHelper.EnsureInitializedInCtor(typeof(Votann40kDefOf));
    }
}