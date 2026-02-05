using CSharpFunctionalExtensions;
using Task_Revit_API_10.Models;


namespace Task_Revit_API_10.Abstractions
{
    public interface IPlacementService
    {
        Result Place(PlantType selectedFurnitureType, int count);
    }
}
