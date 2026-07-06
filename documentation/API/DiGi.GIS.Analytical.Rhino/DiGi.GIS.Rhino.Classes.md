#### [DiGi\.GIS\.Analytical\.Rhino](index.md 'index')

## DiGi\.GIS\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.GIS.Rhino.Classes.BuildingModels'></a>

## BuildingModels Class

A Grasshopper component that loads building models from a GIS model file, 
optionally filtering by specific 2D building geometries\.

```csharp
public class BuildingModels : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → BuildingModels
### Constructors

<a name='DiGi.GIS.Rhino.Classes.BuildingModels.BuildingModels()'></a>

## BuildingModels\(\) Constructor

Initializes a new instance of the [BuildingModels](DiGi.GIS.Rhino.Classes.md#DiGi.GIS.Rhino.Classes.BuildingModels 'DiGi\.GIS\.Rhino\.Classes\.BuildingModels') class\.

```csharp
public BuildingModels();
```
### Properties

<a name='DiGi.GIS.Rhino.Classes.BuildingModels.ComponentGuid'></a>

## BuildingModels\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.GIS.Rhino.Classes.BuildingModels.Exposure'></a>

## BuildingModels\.Exposure Property

Gets the exposure level of the component, determining its execution priority\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.GIS.Rhino.Classes.BuildingModels.Inputs'></a>

## BuildingModels\.Inputs Property

Registers all the input parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.GIS.Rhino.Classes.BuildingModels.Outputs'></a>

## BuildingModels\.Outputs Property

Registers all the output parameters for this component\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.GIS.Rhino.Classes.BuildingModels.SolveInstance(IGH_DataAccess)'></a>

## BuildingModels\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\. It retrieves the GIS model file and 
optional building 2D data to generate a list of analytical building models\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.GIS.Rhino.Classes.BuildingModels.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve from inputs and store in outputs\.