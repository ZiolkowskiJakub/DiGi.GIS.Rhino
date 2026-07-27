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

<a name='DiGi.GIS.Rhino.Inspect.Code(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Inspect\.Code\(this BuildingModel\) Method

Retrieves the administrative area code for the specified building model\.

```csharp
public static GH_String? Code(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Code(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the administrative area code, or `null` if the value is not found or the building model is null\.

<a name='DiGi.GIS.Rhino.Inspect.Reference(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Inspect\.Reference\(this BuildingModel\) Method

Retrieves the reference GUID for the specified building model\.

```csharp
public static GH_String? Reference(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Reference(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the reference GUID, or `null` if the value is not found or the building model is null\.

<a name='DiGi.GIS.Rhino.Inspect.Source(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Inspect\.Source\(this BuildingModel\) Method

Retrieves the data source information for the specified building model\.

```csharp
public static GH_String? Source(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Source(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the source information, or `null` if the value is not found or the building model is null\.