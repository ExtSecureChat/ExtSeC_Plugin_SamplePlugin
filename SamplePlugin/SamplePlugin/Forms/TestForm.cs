using PluginLibrary;

namespace SamplePlugin.Forms
{
    public partial class TestForm : PluginForm
    {
        public override string GetName()
        {
            return "TEST_FORM";
        }

        public TestForm()
        {
            InitializeComponent();
        }
    }
}
