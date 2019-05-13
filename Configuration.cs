using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace coolpuppy24.staffhelp
{

    public class Configuration : IRocketPluginConfiguration
    {
        public string ChatColorName;
        public string receivePerm;
        public string sendPerm;

        public void LoadDefaults()
        {
            ChatColorName = "Blue";
            receivePerm = "staff.receive";
            sendPerm = "staff.send";
        }
    }
}
