using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;

namespace Task_RevitAPI_5
{
    [Transaction(TransactionMode.Manual)]
    public class CommandClass : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIApplication uiApp = commandData.Application;
            Application app = uiApp.Application;
            UIDocument uiDoc = uiApp.ActiveUIDocument;
            Document doc = uiDoc.Document;

            try
            {
                IList<Reference> pickedRefs = uiDoc.Selection.PickObjects(ObjectType.Element,
                    new FamilyInstanceFilter(), "Выберите элементы");
                List<FamilyInstance> familyInstances = new List<FamilyInstance>();
                foreach (var pickedRef in pickedRefs)
                {
                    Element element = doc.GetElement(pickedRef);
                    familyInstances.Add(element as FamilyInstance);
                }
                Dictionary<string,int> dictionary = familyInstances
                    .GroupBy(item => item.Category.Name)
                    .ToDictionary(p => p.Key, p => p.Count());
                List<string> l = dictionary.Select(d => $"{d.Key}: {d.Value}").ToList();
                String s = String.Join( "\n", l );
                TaskDialog.Show("Информация", $"Общее кол-во элементов: {familyInstances.Count}" +
                    $"\nРаспределение по категориям:" +
                    $"\n{s}");
            }
            catch
            {
                TaskDialog.Show("Ошибка", "Элементы не выбраны");
            }
            return Result.Succeeded;
        }
    }
}
