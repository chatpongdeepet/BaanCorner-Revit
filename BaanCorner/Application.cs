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

        panel.AddPushButton<StartupCommand>("baancorner")
            .SetImage("/BaanCorner;component/Resources/Icons/BaancornerIcon16.png")
            .SetLargeImage("/BaanCorner;component/Resources/Icons/BaancornerIcon32.png");

        unitsPanel.AddPushButton<SaveProjectUnitsCommand>("Project Unit")
            .SetImage("/BaanCorner;component/Resources/Icons/UnitIcon16.png")
                .SetLargeImage("/BaanCorner;component/Resources/Icons/UnitIcon32.png");
        
        unitsPanel.AddPushButton<LoadProjectUnitsCommand>("Unit Test")
            .SetImage("/BaanCorner;component/Resources/Icons/TestIcon16.png")
            .SetLargeImage("/BaanCorner;component/Resources/Icons/TestIcon32.png");
    }
}