namespace Millwright.ModConfig
{
    public class ModConfig
    {
        public static ModConfig Loaded { get; set; } = new ModConfig();

        #if (AddSampleCode)
        public bool ExampleBoolean { get; set; } = true;
        public double ExampleDouble { get; set; } = 10.5;
        #endif
    }
}