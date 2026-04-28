using Mutagen.Bethesda.Synthesis.Settings;
using static BijinAIOPathcer.Constants;

namespace BijinAIOPathcer.Settings
{
    public class Settings
    {
        public bool UseHighPolyHead { get; set; } = false;

        public bool UseYourBodyMesh { get; set; } = false;

        public bool UseYourSkin { get; set; } = false;

        [SynthesisTooltip("Effective when Use Your Skin is enabled")]
        [SynthesisDescription("Effective when Use Your Skin is enabled")]
        public bool UseYourSkinNormalMap { get; set; } = false;


        [SynthesisTooltip("The output path must be specified when the “Use Your Skin” feature is enabled.")]
        [SynthesisDescription("The output path must be specified when the “Use Your Skin” feature is enabled.")]
        public string HeadMeshOutput { get; set; } = "";

        
        [SynthesisTooltip("When you do not check this option, it will use the color of the \"Hi babe\" hairstyle by default.")]
        [SynthesisDescription("When you do not check this option, it will use the color of the \"Hi babe\" hairstyle by default.")]
        public AdrianneOption Adrianne = new();

        public ValericaOption Valerica = new();

        [SynthesisTooltip("separate esps with a semicolon (;)")]
        [SynthesisDescription("separate esps with a semicolon (;)")]
        public string ModsToSkip { get; set; } = "";
    }

    public class AdrianneOption
    {
        public AdrianneHairColor HairColor { get; set; }

}

    public class ValericaOption
    {
        public ValericaHairColor HairColor { get; set; }

    }
}

