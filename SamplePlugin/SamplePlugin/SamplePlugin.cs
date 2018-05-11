using PluginLibrary;
using SamplePlugin.Forms;
using System;
using System.Collections.Generic;

namespace SamplePlugin
{
    public class SamplePlugin : GuiPlugin
    {
        public override string Name => "SamplePlugin";
        public override PluginTypes PluginType => PluginTypes.GUI_PLUGIN;

        public override void OnLoad()
        {
            Console.WriteLine("Loaded Plugin: " + Name);

            BeforeFormTransitionEventHandler += (PluginForm currentForm, ref string destinationForm) =>
            {
                if (destinationForm == PluginHelper.Forms.CONNECT_FORM)
                {
                    destinationForm = "TEST_FORM";
                }
            };
        }

        public override void OverrideForms(ref List<PluginForm> forms)
        {
            forms.Add(new TestForm());
        }
    }
}
