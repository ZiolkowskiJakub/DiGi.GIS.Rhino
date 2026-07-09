#### [DiGi\.GIS\.Analytical\.Rhino](DiGi.GIS.Analytical.Rhino.Overview.md 'DiGi\.GIS\.Analytical\.Rhino\.Overview')

## DiGi\.GIS\.Rhino Namespace
### Classes

<a name='DiGi.GIS.Rhino.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.GIS.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Inspect\.Guid\(this BuildingModel\) Method

Retrieves the reference GUID for the specified building model\.

```csharp
public static GH_String? Guid(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the reference GUID, or `null` if the value is not found or the building model is null\.

<a name='DiGi.GIS.Rhino.Inspect.LOD(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Inspect\.LOD\(this BuildingModel\) Method

Retrieves the Level of Detail \(LOD\) for the specified building model\.

```csharp
public static DiGi.Rhino.Core.Classes.GooEnum? LOD(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.LOD(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to inspect\.

#### Returns
[DiGi\.Rhino\.Core\.Classes\.GooEnum](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum 'DiGi\.Rhino\.Core\.Classes\.GooEnum')  
A [DiGi\.Rhino\.Core\.Classes\.GooEnum](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum 'DiGi\.Rhino\.Core\.Classes\.GooEnum') representing the LOD, or `null` if the value is not found or the building model is null\.