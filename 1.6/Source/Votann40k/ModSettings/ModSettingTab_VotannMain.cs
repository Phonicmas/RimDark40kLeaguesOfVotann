using Core40k;
using UnityEngine;
using Verse;

namespace Votann40k;

public class ModSettingTab_VotannMain : ModSettingTab
{
    public override void DrawTab(Rect inRect, ModSettings settings)
    {
        if (settings is not Votann40kModSettings Votann40kModSettings)
        {
            Log.Error("Settings not correct type");
            return;
        }
        
        var viewRect = new Rect(inRect.x, inRect.y, inRect.width - 16f, scrollViewHeight);
        scrollViewHeight = 0f;
            
        Widgets.BeginScrollView(inRect, ref scrollPos, viewRect);
        var listingStandard = new Listing_Standard();
        listingStandard.Begin(viewRect);
        listingStandard.Gap(36);
        scrollViewHeight += ListingHeightIncreaseGap;
        scrollViewHeight += ListingHeightIncrease;
        
        Votann40kModSettings.minimumItemValueToTrade = (int)listingStandard.SliderLabeled("BEWH.Votann.ModSettings.KinContractMinValue".Translate(Votann40kModSettings.minimumItemValueToTrade), Votann40kModSettings.minimumItemValueToTrade, 0, 1000, tooltip: "BEWH.Votann.ModSettings.KinContractMinValueTooltip".Translate());

        scrollViewHeight += ListingHeightIncrease;
        
        //Check VEF patches
        listingStandard.GapLine(36);
        scrollViewHeight += ListingHeightIncreaseGap;
        listingStandard.Label("\n" + "BEWH.ModSettings.CheckVEFPatches".Translate());
        scrollViewHeight += ListingHeightIncrease;
        
        scrollViewHeight += ListingHeightIncrease;
        
        listingStandard.End();
        Widgets.EndScrollView();
    }
}