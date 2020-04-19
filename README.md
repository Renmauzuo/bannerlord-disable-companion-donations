#Bannerlord Disable Companion Donations

This is a mod for Mount and Blade Bannerlord that prevents heroes in the player's clan from donating troops to settlement garrisons, stopping them from giving away any high tier troops given to them by the player.

This mod uses Harmony to patch the OnSettlementEntered method of GarrisonTroopsCampaignBehavion, so it may conflict with other mods that patch that method. Ideally this mod would patch FindNumberOfTroopsToLeaveToGarrison in DefaultSettlementGarrisonModel instead but unfortunately that is currently not public.

Feel free to fork and modify this mod, or incorporate it into a mod of your own.
