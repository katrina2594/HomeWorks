using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.UI;

namespace Task_RevitAPI_3
{
    [Transaction(TransactionMode.Manual)]
    public class ApplicationClass : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            application.CreateRibbonTab("ДЗ RevitAPI 3");
            var panel = application.CreateRibbonPanel("ДЗ RevitAPI 3","Общее");
            var button = new PushButtonData(
                "RunLevelsProperty",
                "Уровни",
                "C:\\Users\\kolesnikovaeiu\\Desktop\\RevitSDK\\Software Development Kit\\Samples\\LevelsProperty\\CS\\bin\\Debug\\LevelsProperty.dll",
                "Revit.SDK.Samples.LevelsProperty.CS.Command"
                );
            panel.AddItem( button );
            return Result.Succeeded;
        }
    }
}
