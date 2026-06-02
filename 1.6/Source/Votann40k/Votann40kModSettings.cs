using Verse;

namespace Votann40k;

public class Votann40kModSettings : ModSettings
{
    public int minimumItemValueToTrade = 500;
    
    public override void ExposeData()
    {
        Scribe_Values.Look(ref minimumItemValueToTrade, "minimumItemValueToTrade");
    }
}