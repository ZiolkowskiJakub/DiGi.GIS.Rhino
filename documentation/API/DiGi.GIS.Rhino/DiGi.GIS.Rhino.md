#### [DiGi\.GIS\.Rhino](DiGi.GIS.Rhino.Overview.md 'DiGi\.GIS\.Rhino\.Overview')

## DiGi\.GIS\.Rhino Namespace
### Classes

<a name='DiGi.GIS.Rhino.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.GIS.Rhino.Inspect.AdministrativeAreal2Ds(thisDiGi.GIS.Classes.GISModel)'></a>

## Inspect\.AdministrativeAreal2Ds\(this GISModel\) Method

Gets a collection of administrative areas associated with the specified GIS model, converted to Goo wrappers\.

```csharp
public static System.Collections.IEnumerable? AdministrativeAreal2Ds(this DiGi.GIS.Classes.GISModel? gISModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.AdministrativeAreal2Ds(thisDiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of GooAdministrativeAreal2D objects, or null if the model is null\.

<a name='DiGi.GIS.Rhino.Inspect.AdministrativeSubdivisionType(thisDiGi.GIS.Classes.AdministrativeSubdivision)'></a>

## Inspect\.AdministrativeSubdivisionType\(this AdministrativeSubdivision\) Method

Gets the administrative subdivision type of the specified administrative subdivision\.

```csharp
public static DiGi.Rhino.Core.Classes.GooEnum<DiGi.GIS.Enums.AdministrativeSubdivisionType>? AdministrativeSubdivisionType(this DiGi.GIS.Classes.AdministrativeSubdivision? administrativeSubdivision);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.AdministrativeSubdivisionType(thisDiGi.GIS.Classes.AdministrativeSubdivision).administrativeSubdivision'></a>

`administrativeSubdivision` [DiGi\.GIS\.Classes\.AdministrativeSubdivision](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativesubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')

The administrative subdivision to inspect\.

#### Returns
[DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1')[DiGi\.GIS\.Enums\.AdministrativeSubdivisionType](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.administrativesubdivisiontype 'DiGi\.GIS\.Enums\.AdministrativeSubdivisionType')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1')  
A [DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1') containing the administrative subdivision type, or `null` if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.Area(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Inspect\.Area\(this Building2DGeometryCalculationResult\) Method

Gets the area of the building 2D geometry calculation result\.

```csharp
public static GH_Number? Area(this DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Area(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the area, or null if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.Building2Ds(thisDiGi.GIS.Classes.GISModel)'></a>

## Inspect\.Building2Ds\(this GISModel\) Method

Gets a collection of 2D buildings associated with the specified GIS model, converted to Goo wrappers\.

```csharp
public static System.Collections.IEnumerable? Building2Ds(this DiGi.GIS.Classes.GISModel? gISModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Building2Ds(thisDiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of GooBuilding2D objects, or null if the model is null\.

<a name='DiGi.GIS.Rhino.Inspect.BuildingGeneralFunction(thisDiGi.GIS.Classes.Building2D)'></a>

## Inspect\.BuildingGeneralFunction\(this Building2D\) Method

Retrieves the general function of a given Building2D object as a GooEnum\.

```csharp
public static DiGi.Rhino.Core.Classes.GooEnum<DiGi.GIS.Enums.BuildingGeneralFunction>? BuildingGeneralFunction(this DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.BuildingGeneralFunction(thisDiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The Building2D instance to inspect\.

#### Returns
[DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1')[DiGi\.GIS\.Enums\.BuildingGeneralFunction](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.buildinggeneralfunction 'DiGi\.GIS\.Enums\.BuildingGeneralFunction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1')  
A [DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1') of [BuildingGeneralFunction\(this Building2D\)](DiGi.GIS.Rhino.md#DiGi.GIS.Rhino.Inspect.BuildingGeneralFunction(thisDiGi.GIS.Classes.Building2D) 'DiGi\.GIS\.Rhino\.Inspect\.BuildingGeneralFunction\(this DiGi\.GIS\.Classes\.Building2D\)') representing the building's general function, or null if the building or its function is null\.

<a name='DiGi.GIS.Rhino.Inspect.BuildingPhase(thisDiGi.GIS.Classes.Building2D)'></a>

## Inspect\.BuildingPhase\(this Building2D\) Method

Retrieves the construction phase of a given Building2D object as a GooEnum\.

```csharp
public static DiGi.Rhino.Core.Classes.GooEnum<DiGi.GIS.Enums.BuildingPhase>? BuildingPhase(this DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.BuildingPhase(thisDiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The Building2D instance to inspect\.

#### Returns
[DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1')[DiGi\.GIS\.Enums\.BuildingPhase](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.buildingphase 'DiGi\.GIS\.Enums\.BuildingPhase')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1')  
A [DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1') of [BuildingPhase\(this Building2D\)](DiGi.GIS.Rhino.md#DiGi.GIS.Rhino.Inspect.BuildingPhase(thisDiGi.GIS.Classes.Building2D) 'DiGi\.GIS\.Rhino\.Inspect\.BuildingPhase\(this DiGi\.GIS\.Classes\.Building2D\)') representing the building's phase, or null if the building or its phase is null\.

<a name='DiGi.GIS.Rhino.Inspect.BuildingSpecificFunctions(thisDiGi.GIS.Classes.Building2D)'></a>

## Inspect\.BuildingSpecificFunctions\(this Building2D\) Method

Retrieves the specific functions of a given Building2D object as a collection of GooEnums\.

```csharp
public static System.Collections.IEnumerable? BuildingSpecificFunctions(this DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.BuildingSpecificFunctions(thisDiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The Building2D instance to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of [DiGi\.Rhino\.Core\.Classes\.GooEnum&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooenum-1 'DiGi\.Rhino\.Core\.Classes\.GooEnum\`1') of [DiGi\.GIS\.Enums\.BuildingSpecificFunction](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.buildingspecificfunction 'DiGi\.GIS\.Enums\.BuildingSpecificFunction'), or null if the building or its functions are null\.

<a name='DiGi.GIS.Rhino.Inspect.Centroid(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Inspect\.Centroid\(this Building2DGeometryCalculationResult\) Method

Gets the centroid of the building 2D geometry calculation result\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? Centroid(this DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Centroid(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result\.

#### Returns
[DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.planar.classes.goopoint2d 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.planar.classes.goopoint2d 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the centroid, or null if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.GISModel(thisDiGi.GIS.Classes.GISModelFile)'></a>

## Inspect\.GISModel\(this GISModelFile\) Method

Extracts the GIS model from the specified GIS model file\.

```csharp
public static DiGi.GIS.Rhino.Classes.GooGISModel? GISModel(this DiGi.GIS.Classes.GISModelFile? gISModelFile);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.GISModel(thisDiGi.GIS.Classes.GISModelFile).gISModelFile'></a>

`gISModelFile` [DiGi\.GIS\.Classes\.GISModelFile](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodelfile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file to inspect\.

#### Returns
[GooGISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel')  
A [GooGISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel') representing the GIS model, or `null` if the input file is null\.

<a name='DiGi.GIS.Rhino.Inspect.Guid(thisDiGi.GIS.Classes.Areal2D)'></a>

## Inspect\.Guid\(this Areal2D\) Method

Extracts the unique global identifier \(GUID\) from an [DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D') object and wraps it in a Grasshopper GUID type\.

```csharp
public static GH_Guid? Guid(this DiGi.GIS.Classes.Areal2D? areal2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Guid(thisDiGi.GIS.Classes.Areal2D).areal2D'></a>

`areal2D` [DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')

The areal 2D object to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')  
A [Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid') containing the GUID of the object, or `null` if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.Guid(thisDiGi.GIS.Classes.GISModel)'></a>

## Inspect\.Guid\(this GISModel\) Method

Gets the unique identifier of the specified GIS model as a Grasshopper GUID\.

```csharp
public static GH_Guid? Guid(this DiGi.GIS.Classes.GISModel? gISModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Guid(thisDiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')  
The GH\_Guid representing the model's identity, or null if the model is null\.

<a name='DiGi.GIS.Rhino.Inspect.InternalPoint(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Inspect\.InternalPoint\(this Building2DGeometryCalculationResult\) Method

Gets the internal point of the building 2D geometry calculation result\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPoint2D? InternalPoint(this DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.InternalPoint(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result\.

#### Returns
[DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.planar.classes.goopoint2d 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D')  
A [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.planar.classes.goopoint2d 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPoint2D') representing the internal point, or null if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.IsOccupied(thisDiGi.GIS.Classes.Building2D)'></a>

## Inspect\.IsOccupied\(this Building2D\) Method

Checks whether a given Building2D object is occupied and returns the result as a Grasshopper boolean\.

```csharp
public static GH_Boolean? IsOccupied(this DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.IsOccupied(thisDiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The Building2D instance to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Boolean](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_boolean 'Grasshopper\.Kernel\.Types\.GH\_Boolean')  
A [Grasshopper\.Kernel\.Types\.GH\_Boolean](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_boolean 'Grasshopper\.Kernel\.Types\.GH\_Boolean') indicating if the building is occupied, or null if the building is null\.

<a name='DiGi.GIS.Rhino.Inspect.IsoperimetricRatio(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Inspect\.IsoperimetricRatio\(this Building2DGeometryCalculationResult\) Method

Gets the isoperimetric ratio of the building 2D geometry calculation result\.

```csharp
public static GH_Number? IsoperimetricRatio(this DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.IsoperimetricRatio(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the isoperimetric ratio, or null if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.Name(thisDiGi.GIS.Classes.AdministrativeAreal2D)'></a>

## Inspect\.Name\(this AdministrativeAreal2D\) Method

Retrieves the name of the administrative areal 2D object as a Grasshopper string\.

```csharp
public static GH_String? Name(this DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Name(thisDiGi.GIS.Classes.AdministrativeAreal2D).administrativeAreal2D'></a>

`administrativeAreal2D` [DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The administrative areal 2D object to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the name, or `null` if the input object is null\.

<a name='DiGi.GIS.Rhino.Inspect.Name(thisDiGi.GIS.Classes.AdministrativeSubdivision)'></a>

## Inspect\.Name\(this AdministrativeSubdivision\) Method

Gets the name of the specified administrative subdivision\.

```csharp
public static GH_String? Name(this DiGi.GIS.Classes.AdministrativeSubdivision? administrativeSubdivision);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Name(thisDiGi.GIS.Classes.AdministrativeSubdivision).administrativeSubdivision'></a>

`administrativeSubdivision` [DiGi\.GIS\.Classes\.AdministrativeSubdivision](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativesubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')

The administrative subdivision to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the name, or `null` if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.Occupancy(thisDiGi.GIS.Classes.AdministrativeSubdivision)'></a>

## Inspect\.Occupancy\(this AdministrativeSubdivision\) Method

Gets the occupancy of the specified administrative subdivision\.

```csharp
public static GH_Integer? Occupancy(this DiGi.GIS.Classes.AdministrativeSubdivision? administrativeSubdivision);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Occupancy(thisDiGi.GIS.Classes.AdministrativeSubdivision).administrativeSubdivision'></a>

`administrativeSubdivision` [DiGi\.GIS\.Classes\.AdministrativeSubdivision](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativesubdivision 'DiGi\.GIS\.Classes\.AdministrativeSubdivision')

The administrative subdivision to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Integer](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_integer 'Grasshopper\.Kernel\.Types\.GH\_Integer')  
A [Grasshopper\.Kernel\.Types\.GH\_Integer](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_integer 'Grasshopper\.Kernel\.Types\.GH\_Integer') containing the occupancy value, or `null` if the input or its occupancy is null\.

<a name='DiGi.GIS.Rhino.Inspect.Path(thisDiGi.GIS.Classes.GISModelFile)'></a>

## Inspect\.Path\(this GISModelFile\) Method

Extracts the file path from the specified GIS model file\.

```csharp
public static GH_String? Path(this DiGi.GIS.Classes.GISModelFile? gISModelFile);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Path(thisDiGi.GIS.Classes.GISModelFile).gISModelFile'></a>

`gISModelFile` [DiGi\.GIS\.Classes\.GISModelFile](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodelfile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the path, or `null` if the input file is null\.

<a name='DiGi.GIS.Rhino.Inspect.Perimeter(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Inspect\.Perimeter\(this Building2DGeometryCalculationResult\) Method

Gets the perimeter of the building 2D geometry calculation result\.

```csharp
public static GH_Number? Perimeter(this DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Perimeter(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the perimeter, or null if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.PolygonalFace2D(thisDiGi.GIS.Classes.Areal2D)'></a>

## Inspect\.PolygonalFace2D\(this Areal2D\) Method

Extracts the polygonal face representation from an [DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D') object and wraps it in a Goo wrapper\.

```csharp
public static DiGi.Rhino.Geometry.Planar.Classes.GooPolygonalFace2D? PolygonalFace2D(this DiGi.GIS.Classes.Areal2D? areal2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.PolygonalFace2D(thisDiGi.GIS.Classes.Areal2D).areal2D'></a>

`areal2D` [DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')

The areal 2D object to inspect\.

#### Returns
[DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.planar.classes.goopolygonalface2d 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D')  
A [DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.planar.classes.goopolygonalface2d 'DiGi\.Rhino\.Geometry\.Planar\.Classes\.GooPolygonalFace2D') containing the polygonal face of the object, or `null` if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.Rectangularity(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Inspect\.Rectangularity\(this Building2DGeometryCalculationResult\) Method

Gets the rectangularity of the building 2D geometry calculation result\.

```csharp
public static GH_Number? Rectangularity(this DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Rectangularity(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the rectangularity, or null if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.RectangularThinnessRatio(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Inspect\.RectangularThinnessRatio\(this Building2DGeometryCalculationResult\) Method

Gets the rectangular thinness ratio of the building 2D geometry calculation result\.

```csharp
public static GH_Number? RectangularThinnessRatio(this DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.RectangularThinnessRatio(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the rectangular thinness ratio, or null if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.Reference(thisDiGi.GIS.Classes.Areal2D)'></a>

## Inspect\.Reference\(this Areal2D\) Method

Extracts the reference string from an [DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D') object and wraps it in a Grasshopper string type\.

```csharp
public static GH_String? Reference(this DiGi.GIS.Classes.Areal2D? areal2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Reference(thisDiGi.GIS.Classes.Areal2D).areal2D'></a>

`areal2D` [DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')

The areal 2D object to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the reference of the object, or `null` if the input is null\.

<a name='DiGi.GIS.Rhino.Inspect.Storeys(thisDiGi.GIS.Classes.Building2D)'></a>

## Inspect\.Storeys\(this Building2D\) Method

Retrieves the number of storeys for a given Building2D object as a Grasshopper integer\.

```csharp
public static GH_Integer? Storeys(this DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.Storeys(thisDiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The Building2D instance to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Integer](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_integer 'Grasshopper\.Kernel\.Types\.GH\_Integer')  
A [Grasshopper\.Kernel\.Types\.GH\_Integer](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_integer 'Grasshopper\.Kernel\.Types\.GH\_Integer') representing the number of storeys, or null if the building is null\.

<a name='DiGi.GIS.Rhino.Inspect.ThinnessRatio(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## Inspect\.ThinnessRatio\(this Building2DGeometryCalculationResult\) Method

Gets the thinness ratio of the building 2D geometry calculation result\.

```csharp
public static GH_Number? ThinnessRatio(this DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Inspect.ThinnessRatio(thisDiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number')  
A [Grasshopper\.Kernel\.Types\.GH\_Number](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_number 'Grasshopper\.Kernel\.Types\.GH\_Number') representing the thinness ratio, or null if the input is null\.