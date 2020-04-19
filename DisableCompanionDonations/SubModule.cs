using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HarmonyLib;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;

namespace DisableCompanionDonations
{
    public class SubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad() {
            base.OnSubModuleLoad();

            try
            {
                new Harmony("mod.DisableCompanionDonations.bannerlord").PatchAll();
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("Error patching:\n" + ex.Message + " \n\n" + ex.InnerException?.Message);
            }
        }
    }
}
