using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.CampaignBehaviors;


namespace DisableCompanionDonations
{
    //It would be less intrusive to patch FindNumberOfTroopsToLeaveToGarrison in DefaultSettlementGarrisonModel instead but unfortunately that is currently not public
    [HarmonyPatch(typeof(GarrisonTroopsCampaignBehavior), "OnSettlementEntered")]
    class DisableDonationsPatch
    {
        static bool Prefix(MobileParty mobileParty, Settlement settlement, Hero hero)
        {
            if (mobileParty!= null && mobileParty.LeaderHero != null && mobileParty.LeaderHero.Clan == Clan.PlayerClan)
            {
                return false;
            }
            return true;
        }
    }
}
