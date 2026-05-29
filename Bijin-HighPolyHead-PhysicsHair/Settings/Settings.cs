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

        [SynthesisTooltip("separate with (;), Valid names: Aela Brelyna Iona Beleval Frea Aranea Borgakh Njada Ria Rayya Uthgerd Delphine Ingjard Illia Lydia Annekke Adelaisa Jenassa Jordis Eola Mjoll Beleval Ugor Grelkai Grelka Muiri Morwen Muiri Senna Sennai Senna Camilla Sylgja Taarie Temba Ysolda Ingun Rikke Hulda Irileth Lisette Sapphire Karliah Tonilia Carlotta Maven Gerdur Idgrod Idgord Adrianne Vex")]
        [SynthesisDescription("separate with (;), Valid names: Aela Brelyna Iona Beleval Frea Aranea Borgakh Njada Ria Rayya Uthgerd Delphine Ingjard Illia Lydia Annekke Adelaisa Jenassa Jordis Eola Mjoll Beleval Ugor Grelkai Grelka Muiri Morwen Muiri Senna Sennai Senna Camilla Sylgja Taarie Temba Ysolda Ingun Rikke Hulda Irileth Lisette Sapphire Karliah Tonilia Carlotta Maven Gerdur Idgrod Idgord Adrianne Vex")]
        public string NamsToSkip { get; set; } = "";
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

