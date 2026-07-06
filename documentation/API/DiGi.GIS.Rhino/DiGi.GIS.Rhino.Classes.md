#### [DiGi\.GIS\.Rhino](index.md 'index')

## DiGi\.GIS\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds'></a>

## AdministrativeAreal2DBuilding2Ds Class

A Grasshopper component that retrieves a list of 2D buildings associated with a specific administrative area within a GIS model\.

```csharp
public class AdministrativeAreal2DBuilding2Ds : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → AdministrativeAreal2DBuilding2Ds
### Constructors

<a name='DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds.AdministrativeAreal2DBuilding2Ds()'></a>

## AdministrativeAreal2DBuilding2Ds\(\) Constructor

Initializes a new instance of the [AdministrativeAreal2DBuilding2Ds](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds 'DiGi\.GIS\.Rhino\.Classes\.AdministrativeAreal2DBuilding2Ds') class\.

```csharp
public AdministrativeAreal2DBuilding2Ds();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds.ComponentGuid'></a>

## AdministrativeAreal2DBuilding2Ds\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds.Exposure'></a>

## AdministrativeAreal2DBuilding2Ds\.Exposure Property

Gets the exposure level of the component, determining how it is displayed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds.Inputs'></a>

## AdministrativeAreal2DBuilding2Ds\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds.Outputs'></a>

## AdministrativeAreal2DBuilding2Ds\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds.SolveInstance(IGH_DataAccess)'></a>

## AdministrativeAreal2DBuilding2Ds\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work of retrieving buildings related to the provided administrative area\.

```csharp
protected override void SolveInstance(IGH_DataAccess DA);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.AdministrativeAreal2DBuilding2Ds.SolveInstance(IGH_DataAccess).DA'></a>

`DA` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve data from inputs and store results in outputs\.

<a name='DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D'></a>

## Areal2DsByPoint2D Class

Grasshopper component that retrieves areal 2D objects, such as buildings and administrative areas, based on a point location within a GIS model\.

```csharp
public class Areal2DsByPoint2D : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Areal2DsByPoint2D
### Constructors

<a name='DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D.Areal2DsByPoint2D()'></a>

## Areal2DsByPoint2D\(\) Constructor

Initializes a new instance of the [Areal2DsByPoint2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D 'DiGi\.GIS\.Rhino\.Classes\.Areal2DsByPoint2D') class\.

```csharp
public Areal2DsByPoint2D();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D.ComponentGuid'></a>

## Areal2DsByPoint2D\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D.Exposure'></a>

## Areal2DsByPoint2D\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D.Inputs'></a>

## Areal2DsByPoint2D\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D.Outputs'></a>

## Areal2DsByPoint2D\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D.SolveInstance(IGH_DataAccess)'></a>

## Areal2DsByPoint2D\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess DA);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.Areal2DsByPoint2D.SolveInstance(IGH_DataAccess).DA'></a>

`DA` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object is used to retrieve from inputs and store in outputs\.

<a name='DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult'></a>

## Building2DGeometryCalculationResult Class

A Grasshopper component that retrieves the 2D geometry calculation result for a specific building within a GIS model\.

```csharp
public class Building2DGeometryCalculationResult : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Building2DGeometryCalculationResult
### Constructors

<a name='DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult.Building2DGeometryCalculationResult()'></a>

## Building2DGeometryCalculationResult\(\) Constructor

Initializes a new instance of the [Building2DGeometryCalculationResult](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult 'DiGi\.GIS\.Rhino\.Classes\.Building2DGeometryCalculationResult') class\.

```csharp
public Building2DGeometryCalculationResult();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult.ComponentGuid'></a>

## Building2DGeometryCalculationResult\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult.Exposure'></a>

## Building2DGeometryCalculationResult\.Exposure Property

Gets the exposure level of the component, determining how it is displayed on the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult.Inputs'></a>

## Building2DGeometryCalculationResult\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult.Outputs'></a>

## Building2DGeometryCalculationResult\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult.SolveInstance(IGH_DataAccess)'></a>

## Building2DGeometryCalculationResult\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\. It retrieves the GIS model and building, 
calculates the related geometry result, and sets it as output\.

```csharp
protected override void SolveInstance(IGH_DataAccess DA);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.Building2DGeometryCalculationResult.SolveInstance(IGH_DataAccess).DA'></a>

`DA` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve from inputs and store in outputs\.

<a name='DiGi.GIS.Rhino.Classes.BuildingGeneralFunction'></a>

## BuildingGeneralFunction Class

Represents the general function of a building within the GIS Rhino system\.

```csharp
public class BuildingGeneralFunction : DiGi.Rhino.Core.Classes.EnumComponent<DiGi.GIS.Enums.BuildingGeneralFunction>
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.EnumComponent&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.enumcomponent-1 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\`1')[DiGi\.GIS\.Enums\.BuildingGeneralFunction](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.enums.buildinggeneralfunction 'DiGi\.GIS\.Enums\.BuildingGeneralFunction')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.enumcomponent-1 'DiGi\.Rhino\.Core\.Classes\.EnumComponent\`1') → BuildingGeneralFunction
### Constructors

<a name='DiGi.GIS.Rhino.Classes.BuildingGeneralFunction.BuildingGeneralFunction()'></a>

## BuildingGeneralFunction\(\) Constructor

Initializes a new instance of the [BuildingGeneralFunction](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.BuildingGeneralFunction 'DiGi\.GIS\.Rhino\.Classes\.BuildingGeneralFunction') class\.

```csharp
public BuildingGeneralFunction();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.BuildingGeneralFunction.ComponentGuid'></a>

## BuildingGeneralFunction\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GISModel'></a>

## GISModel Class

A Grasshopper component that loads a GIS model from a specified file path\.

```csharp
public class GISModel : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → GISModel
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GISModel.GISModel()'></a>

## GISModel\(\) Constructor

Initializes a new instance of the [GISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GISModel 'DiGi\.GIS\.Rhino\.Classes\.GISModel') class\.

```csharp
public GISModel();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GISModel.ComponentGuid'></a>

## GISModel\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GISModel.Exposure'></a>

## GISModel\.Exposure Property

Gets the exposure level of the component\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.GIS.Rhino.Classes.GISModel.Inputs'></a>

## GISModel\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Rhino.Classes.GISModel.Outputs'></a>

## GISModel\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.GISModel.SolveInstance(IGH_DataAccess)'></a>

## GISModel\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\.

```csharp
protected override void SolveInstance(IGH_DataAccess DA);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GISModel.SolveInstance(IGH_DataAccess).DA'></a>

`DA` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve from inputs and store in outputs\.

<a name='DiGi.GIS.Rhino.Classes.GISModelFile'></a>

## GISModelFile Class

A Grasshopper component that loads a GIS model file from a specified file path\.

```csharp
public class GISModelFile : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → GISModelFile
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GISModelFile.GISModelFile()'></a>

## GISModelFile\(\) Constructor

Initializes a new instance of the [GISModelFile](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GISModelFile 'DiGi\.GIS\.Rhino\.Classes\.GISModelFile') class\.

```csharp
public GISModelFile();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GISModelFile.ComponentGuid'></a>

## GISModelFile\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GISModelFile.Exposure'></a>

## GISModelFile\.Exposure Property

Gets the exposure of the component, determining how it behaves in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.GIS.Rhino.Classes.GISModelFile.Inputs'></a>

## GISModelFile\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Rhino.Classes.GISModelFile.Outputs'></a>

## GISModelFile\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.GISModelFile.SolveInstance(IGH_DataAccess)'></a>

## GISModelFile\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work, loading the GIS model file from the provided path and outputting it\.

```csharp
protected override void SolveInstance(IGH_DataAccess DA);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GISModelFile.SolveInstance(IGH_DataAccess).DA'></a>

`DA` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve input data and store output data\.

<a name='DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D'></a>

## GooAdministrativeAreal2D Class

Represents a Grasshopper\-compatible wrapper for an administrative areal 2D object, enabling serialization and data transfer within the Rhino/Grasshopper environment\.

```csharp
public class GooAdministrativeAreal2D : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.GIS.Classes.AdministrativeAreal2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooAdministrativeAreal2D
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D.GooAdministrativeAreal2D()'></a>

## GooAdministrativeAreal2D\(\) Constructor

Initializes a new instance of the [GooAdministrativeAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAdministrativeAreal2D') class\.

```csharp
public GooAdministrativeAreal2D();
```

<a name='DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D.GooAdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D)'></a>

## GooAdministrativeAreal2D\(AdministrativeAreal2D\) Constructor

Initializes a new instance of the [GooAdministrativeAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAdministrativeAreal2D') class with the specified administrative areal 2D object\.

```csharp
public GooAdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D? administrativeAreal2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D.GooAdministrativeAreal2D(DiGi.GIS.Classes.AdministrativeAreal2D).administrativeAreal2D'></a>

`administrativeAreal2D` [DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')

The administrative areal 2D object to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D.Duplicate()'></a>

## GooAdministrativeAreal2D\.Duplicate\(\) Method

Creates a duplicate of the current goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicate of the current instance as an [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')\.

<a name='DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2DParam'></a>

## GooAdministrativeAreal2DParam Class

Represents a Grasshopper parameter used to handle and persist [GooAdministrativeAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAdministrativeAreal2D') objects\.

```csharp
public class GooAdministrativeAreal2DParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D, DiGi.GIS.Classes.AdministrativeAreal2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooAdministrativeAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAdministrativeAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.GIS\.Classes\.AdministrativeAreal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.administrativeareal2d 'DiGi\.GIS\.Classes\.AdministrativeAreal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooAdministrativeAreal2DParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2DParam.GooAdministrativeAreal2DParam()'></a>

## GooAdministrativeAreal2DParam\(\) Constructor

Initializes a new instance of the [GooAdministrativeAreal2DParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2DParam 'DiGi\.GIS\.Rhino\.Classes\.GooAdministrativeAreal2DParam') class\.

```csharp
public GooAdministrativeAreal2DParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooAdministrativeAreal2DParam.ComponentGuid'></a>

## GooAdministrativeAreal2DParam\.ComponentGuid Property

Gets the unique global identifier for the component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GooAreal2D'></a>

## GooAreal2D Class

Represents a Grasshopper Goo wrapper for an Areal2D GIS object, enabling its use within the Grasshopper environment\.

```csharp
public class GooAreal2D : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.GIS.Classes.Areal2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooAreal2D
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooAreal2D.GooAreal2D()'></a>

## GooAreal2D\(\) Constructor

Initializes a new instance of the [GooAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAreal2D') class\.

```csharp
public GooAreal2D();
```

<a name='DiGi.GIS.Rhino.Classes.GooAreal2D.GooAreal2D(DiGi.GIS.Classes.Areal2D)'></a>

## GooAreal2D\(Areal2D\) Constructor

Initializes a new instance of the [GooAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAreal2D') class with the specified Areal2D value\.

```csharp
public GooAreal2D(DiGi.GIS.Classes.Areal2D? areal2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooAreal2D.GooAreal2D(DiGi.GIS.Classes.Areal2D).areal2D'></a>

`areal2D` [DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')

The [DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D') object to be wrapped\.
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooAreal2D.Geometries'></a>

## GooAreal2D\.Geometries Property

Gets the geometry associated with the wrapped Areal2D object\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooAreal2D.Duplicate()'></a>

## GooAreal2D\.Duplicate\(\) Method

Creates a duplicate of the current GooAreal2D instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance that is a copy of this object\.

<a name='DiGi.GIS.Rhino.Classes.GooAreal2DParam'></a>

## GooAreal2DParam Class

Represents the Grasshopper parameter type for Areal2D objects\.

```csharp
public class GooAreal2DParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.GIS.Rhino.Classes.GooAreal2D, DiGi.GIS.Classes.Areal2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooAreal2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAreal2D 'DiGi\.GIS\.Rhino\.Classes\.GooAreal2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.GIS\.Classes\.Areal2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.areal2d 'DiGi\.GIS\.Classes\.Areal2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooAreal2DParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooAreal2DParam.GooAreal2DParam()'></a>

## GooAreal2DParam\(\) Constructor

Initializes a new instance of the [GooAreal2DParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooAreal2DParam 'DiGi\.GIS\.Rhino\.Classes\.GooAreal2DParam') class\.

```csharp
public GooAreal2DParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooAreal2DParam.ComponentGuid'></a>

## GooAreal2DParam\.ComponentGuid Property

Gets the unique global identifier for the Areal2D component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2D'></a>

## GooBuilding2D Class

Represents a Grasshopper Goo wrapper for a 2D building object, enabling serialization and bake\-aware functionality within the Rhino environment\.

```csharp
public class GooBuilding2D : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.GIS.Classes.Building2D>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooBuilding2D
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2D.GooBuilding2D()'></a>

## GooBuilding2D\(\) Constructor

Initializes a new instance of the [GooBuilding2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2D 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2D') class\.

```csharp
public GooBuilding2D();
```

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2D.GooBuilding2D(DiGi.GIS.Classes.Building2D)'></a>

## GooBuilding2D\(Building2D\) Constructor

Initializes a new instance of the [GooBuilding2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2D 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2D') class with the specified 2D building object\.

```csharp
public GooBuilding2D(DiGi.GIS.Classes.Building2D? building2D);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2D.GooBuilding2D(DiGi.GIS.Classes.Building2D).building2D'></a>

`building2D` [DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')

The 2D building object to be wrapped\.
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2D.Geometries'></a>

## GooBuilding2D\.Geometries Property

Gets the geometric representations associated with the 2D building, used for baking into the Rhino document\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2D.Duplicate()'></a>

## GooBuilding2D\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing a copy of the building data\.

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult'></a>

## GooBuilding2DGeometryCalculationResult Class

Represents a Goo wrapper for the building 2D geometry calculation result, enabling its use within the Grasshopper environment\.

```csharp
public class GooBuilding2DGeometryCalculationResult : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.GIS.Classes.Building2DGeometryCalculationResult>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooBuilding2DGeometryCalculationResult
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult.GooBuilding2DGeometryCalculationResult()'></a>

## GooBuilding2DGeometryCalculationResult\(\) Constructor

Initializes a new instance of the [GooBuilding2DGeometryCalculationResult](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2DGeometryCalculationResult') class\.

```csharp
public GooBuilding2DGeometryCalculationResult();
```

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult.GooBuilding2DGeometryCalculationResult(DiGi.GIS.Classes.Building2DGeometryCalculationResult)'></a>

## GooBuilding2DGeometryCalculationResult\(Building2DGeometryCalculationResult\) Constructor

Initializes a new instance of the [GooBuilding2DGeometryCalculationResult](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2DGeometryCalculationResult') class with the specified building 2D geometry calculation result\.

```csharp
public GooBuilding2DGeometryCalculationResult(DiGi.GIS.Classes.Building2DGeometryCalculationResult? building2DGeometryCalculationResult);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult.GooBuilding2DGeometryCalculationResult(DiGi.GIS.Classes.Building2DGeometryCalculationResult).building2DGeometryCalculationResult'></a>

`building2DGeometryCalculationResult` [DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')

The building 2D geometry calculation result to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult.Duplicate()'></a>

## GooBuilding2DGeometryCalculationResult\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicated [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance\.

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResultParam'></a>

## GooBuilding2DGeometryCalculationResultParam Class

Represents a persistent Grasshopper parameter for handling building 2D geometry calculation results\.

```csharp
public class GooBuilding2DGeometryCalculationResultParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult, DiGi.GIS.Classes.Building2DGeometryCalculationResult>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooBuilding2DGeometryCalculationResult](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResult 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2DGeometryCalculationResult')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2dgeometrycalculationresult 'DiGi\.GIS\.Classes\.Building2DGeometryCalculationResult')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooBuilding2DGeometryCalculationResultParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResultParam.GooBuilding2DGeometryCalculationResultParam()'></a>

## GooBuilding2DGeometryCalculationResultParam\(\) Constructor

Initializes a new instance of the [GooBuilding2DGeometryCalculationResultParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResultParam 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2DGeometryCalculationResultParam') class\.

```csharp
public GooBuilding2DGeometryCalculationResultParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DGeometryCalculationResultParam.ComponentGuid'></a>

## GooBuilding2DGeometryCalculationResultParam\.ComponentGuid Property

Gets the unique global identifier of the component parameter\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DParam'></a>

## GooBuilding2DParam Class

Represents the Grasshopper parameter type used to handle and transport [GooBuilding2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2D 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2D') objects\.

```csharp
public class GooBuilding2DParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.GIS.Rhino.Classes.GooBuilding2D, DiGi.GIS.Classes.Building2D>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooBuilding2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2D 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooBuilding2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2D 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooBuilding2D](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2D 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2D')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.GIS\.Classes\.Building2D](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.building2d 'DiGi\.GIS\.Classes\.Building2D')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooBuilding2DParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DParam.GooBuilding2DParam()'></a>

## GooBuilding2DParam\(\) Constructor

Initializes a new instance of the [GooBuilding2DParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooBuilding2DParam 'DiGi\.GIS\.Rhino\.Classes\.GooBuilding2DParam') class\.

```csharp
public GooBuilding2DParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooBuilding2DParam.ComponentGuid'></a>

## GooBuilding2DParam\.ComponentGuid Property

Gets the unique global identifier for the building 2D parameter component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GooGISModel'></a>

## GooGISModel Class

Represents a Grasshopper Goo wrapper for the [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel') class, 
enabling its use within the Grasshopper environment\.

```csharp
public class GooGISModel : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.GIS.Classes.GISModel>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooGISModel
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.GooGISModel()'></a>

## GooGISModel\(\) Constructor

Initializes a new instance of the [GooGISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel') class\.

```csharp
public GooGISModel();
```

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.GooGISModel(DiGi.GIS.Classes.GISModel)'></a>

## GooGISModel\(GISModel\) Constructor

Initializes a new instance of the [GooGISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel') class with a specified GIS model\.

```csharp
public GooGISModel(DiGi.GIS.Classes.GISModel? gISModel);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.GooGISModel(DiGi.GIS.Classes.GISModel).gISModel'></a>

`gISModel` [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')

The GIS model to wrap\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.CastFrom(object)'></a>

## GooGISModel\.CastFrom\(object\) Method

Attempts to cast a source object into the [GooGISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel') type\.

```csharp
public override bool CastFrom(object? source);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.CastFrom(object).source'></a>

`source` [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object')

The object to cast from\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the casting was successful; otherwise, `false`\.

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.CastTo_T_(T)'></a>

## GooGISModel\.CastTo\<T\>\(T\) Method

Attempts to cast the wrapped value into a specified type\.

```csharp
public override bool CastTo<T>(ref T target);
```
#### Type parameters

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.CastTo_T_(T).T'></a>

`T`

The target type for casting\.
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.CastTo_T_(T).target'></a>

`target` [T](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel.CastTo_T_(T).T 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel\.CastTo\<T\>\(T\)\.T')

A reference to the target variable where the result will be stored\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
`true` if the casting was successful; otherwise, `false`\.

<a name='DiGi.GIS.Rhino.Classes.GooGISModel.Duplicate()'></a>

## GooGISModel\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A duplicate of the current [GooGISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel') as an [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')\.

<a name='DiGi.GIS.Rhino.Classes.GooGISModelFile'></a>

## GooGISModelFile Class

Represents a Grasshopper\-compatible wrapper for a GIS model file, enabling its use and serialization within the Grasshopper environment\.

```csharp
public class GooGISModelFile : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.GIS.Classes.GISModelFile>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.GIS\.Classes\.GISModelFile](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodelfile 'DiGi\.GIS\.Classes\.GISModelFile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.GIS\.Classes\.GISModelFile](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodelfile 'DiGi\.GIS\.Classes\.GISModelFile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooGISModelFile
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooGISModelFile.GooGISModelFile()'></a>

## GooGISModelFile\(\) Constructor

Initializes a new instance of the [GooGISModelFile](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModelFile 'DiGi\.GIS\.Rhino\.Classes\.GooGISModelFile') class\.

```csharp
public GooGISModelFile();
```

<a name='DiGi.GIS.Rhino.Classes.GooGISModelFile.GooGISModelFile(DiGi.GIS.Classes.GISModelFile)'></a>

## GooGISModelFile\(GISModelFile\) Constructor

Initializes a new instance of the [GooGISModelFile](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModelFile 'DiGi\.GIS\.Rhino\.Classes\.GooGISModelFile') class with the specified GIS model file\.

```csharp
public GooGISModelFile(DiGi.GIS.Classes.GISModelFile? gISModelFile);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.GooGISModelFile.GooGISModelFile(DiGi.GIS.Classes.GISModelFile).gISModelFile'></a>

`gISModelFile` [DiGi\.GIS\.Classes\.GISModelFile](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodelfile 'DiGi\.GIS\.Classes\.GISModelFile')

The GIS model file to be wrapped in this Goo object\.
### Methods

<a name='DiGi.GIS.Rhino.Classes.GooGISModelFile.Duplicate()'></a>

## GooGISModelFile\.Duplicate\(\) Method

Creates a duplicate of the current Goo wrapper\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the duplicated value\.

<a name='DiGi.GIS.Rhino.Classes.GooGISModelFileParam'></a>

## GooGISModelFileParam Class

Represents a persistent Grasshopper parameter used to handle and store [GooGISModelFile](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModelFile 'DiGi\.GIS\.Rhino\.Classes\.GooGISModelFile') objects\.

```csharp
public class GooGISModelFileParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.GIS.Rhino.Classes.GooGISModelFile, DiGi.GIS.Classes.GISModelFile>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooGISModelFile](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModelFile 'DiGi\.GIS\.Rhino\.Classes\.GooGISModelFile')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.GIS\.Classes\.GISModelFile](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodelfile 'DiGi\.GIS\.Classes\.GISModelFile')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooGISModelFileParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooGISModelFileParam.GooGISModelFileParam()'></a>

## GooGISModelFileParam\(\) Constructor

Initializes a new instance of the [GooGISModelFileParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModelFileParam 'DiGi\.GIS\.Rhino\.Classes\.GooGISModelFileParam') class\.

```csharp
public GooGISModelFileParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooGISModelFileParam.ComponentGuid'></a>

## GooGISModelFileParam\.ComponentGuid Property

Gets the unique global identifier for the GIS model file component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.GooGISModelParam'></a>

## GooGISModelParam Class

Represents a Grasshopper parameter that handles [GooGISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel') objects and persists [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel') data\.

```csharp
public class GooGISModelParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.GIS.Rhino.Classes.GooGISModel, DiGi.GIS.Classes.GISModel>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooGISModel](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModel 'DiGi\.GIS\.Rhino\.Classes\.GooGISModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooGISModelParam
### Constructors

<a name='DiGi.GIS.Rhino.Classes.GooGISModelParam.GooGISModelParam()'></a>

## GooGISModelParam\(\) Constructor

Initializes a new instance of the [GooGISModelParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModelParam 'DiGi\.GIS\.Rhino\.Classes\.GooGISModelParam') class\.

```csharp
public GooGISModelParam();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.GooGISModelParam.ComponentGuid'></a>

## GooGISModelParam\.ComponentGuid Property

Gets the unique global identifier for the [GooGISModelParam](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.GooGISModelParam 'DiGi\.GIS\.Rhino\.Classes\.GooGISModelParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the DiGi\.GIS\.Rhino Grasshopper plugin\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.GIS.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets a string representing the preferred contact details of the author or company\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets a string identifying the author or company that created this GHA library\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets a short string describing the purpose of this GHA library\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets a 24x24 pixel bitmap to represent this GHA library\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')

<a name='DiGi.GIS.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier for the GHA library\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the GHA library\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.Rhino.Classes.ToEPSG2180'></a>

## ToEPSG2180 Class

A Grasshopper component that converts coordinates from the EPSG:4326 \(WGS 84\) coordinate system to the EPSG:2180 \(Korea Central Belt\) coordinate system\.

```csharp
public class ToEPSG2180 : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ToEPSG2180
### Constructors

<a name='DiGi.GIS.Rhino.Classes.ToEPSG2180.ToEPSG2180()'></a>

## ToEPSG2180\(\) Constructor

Initializes a new instance of the [ToEPSG2180](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.ToEPSG2180 'DiGi\.GIS\.Rhino\.Classes\.ToEPSG2180') class\.

```csharp
public ToEPSG2180();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.ToEPSG2180.ComponentGuid'></a>

## ToEPSG2180\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.ToEPSG2180.Exposure'></a>

## ToEPSG2180\.Exposure Property

Gets the exposure level of the component, which determines how it is highlighted in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.GIS.Rhino.Classes.ToEPSG2180.Inputs'></a>

## ToEPSG2180\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Rhino.Classes.ToEPSG2180.Outputs'></a>

## ToEPSG2180\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.ToEPSG2180.SolveInstance(IGH_DataAccess)'></a>

## ToEPSG2180\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work of converting a point from EPSG:4326 to EPSG:2180\.

```csharp
protected override void SolveInstance(IGH_DataAccess DA);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.ToEPSG2180.SolveInstance(IGH_DataAccess).DA'></a>

`DA` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve input data and store output results\.

<a name='DiGi.GIS.Rhino.Classes.ToEPSG4326'></a>

## ToEPSG4326 Class

A Grasshopper component that converts coordinates from the EPSG 2180 coordinate system to the EPSG 4326 coordinate system\.

```csharp
public class ToEPSG4326 : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → ToEPSG4326
### Constructors

<a name='DiGi.GIS.Rhino.Classes.ToEPSG4326.ToEPSG4326()'></a>

## ToEPSG4326\(\) Constructor

Initializes a new instance of the [ToEPSG4326](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.ToEPSG4326 'DiGi\.GIS\.Rhino\.Classes\.ToEPSG4326') class\.

```csharp
public ToEPSG4326();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.ToEPSG4326.ComponentGuid'></a>

## ToEPSG4326\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.ToEPSG4326.Exposure'></a>

## ToEPSG4326\.Exposure Property

Gets the exposure of the component, determining how it is executed in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.GIS.Rhino.Classes.ToEPSG4326.Inputs'></a>

## ToEPSG4326\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Rhino.Classes.ToEPSG4326.Outputs'></a>

## ToEPSG4326\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.ToEPSG4326.SolveInstance(IGH_DataAccess)'></a>

## ToEPSG4326\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work of converting a point from EPSG 2180 to EPSG 4326\.

```csharp
protected override void SolveInstance(IGH_DataAccess DA);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.ToEPSG4326.SolveInstance(IGH_DataAccess).DA'></a>

`DA` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve input data and store output results\.