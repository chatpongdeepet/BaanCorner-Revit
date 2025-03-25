using Nice3point.Revit.Toolkit.External;
using BaanCorner.Commands;

namespace BaanCorner;


[UsedImplicitly]
public class Application : ExternalApplication
{
    public override void OnStartup()
    {
        CreateRibbon();
    }

    private void CreateRibbon()
    {
        var panel = Application.CreatePanel("Commands", "BaanCorner");
        var unitsPanel = Application.CreatePanel("Units", "BaanCorner");

        panel.AddPushButton<StartupCommand>("Execute")
            .SetImage("/BaanCorner;component/Resources/Icons/RibbonIcon16.png")
            .SetLargeImage("/BaanCorner;component/Resources/Icons/RibbonIcon32.png");

        unitsPanel.AddPushButton<SaveProjectUnitsCommand>("Save")
            .SetImage("/BaanCorner;component/Resources/Icons/RibbonIcon16.png")
                .SetLargeImage("/BaanCorner;component/Resources/Icons/RibbonIcon32.png");
        
        unitsPanel.AddPushButton<LoadProjectUnitsCommand>("Load")
            .SetImage("/BaanCorner;component/Resources/Icons/RibbonIcon16.png")
            .SetLargeImage("/BaanCorner;component/Resources/Icons/RibbonIcon32.png");
    }
}