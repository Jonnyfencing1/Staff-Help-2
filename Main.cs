using Rocket.Core.Plugins;


namespace coolpuppy24.staffhelp
{
    public class Main : RocketPlugin<Configuration>
    {
        public static Main Instance = null;


        protected override void Load()
        {
            Instance = this; 

            Rocket.Core.Logging.Logger.LogWarning("[StaffHelp] Made by: Coolpuppy24 || Revised by Jonny");
            Rocket.Core.Logging.Logger.LogWarning("[StaffHelp] Chat Color: " + Configuration.Instance.ChatColorName);
            Rocket.Core.Logging.Logger.LogWarning("[StaffHelp] Successfully Loaded StaffHelp!");
        }

        protected override void Unload()
        {
            Rocket.Core.Logging.Logger.Log("Unload");
        }
    }
}
