msbuild Savory.TransformService.Contract\Savory.TransformService.Contract.csproj /t:rebuild /p:configuration=release;DocumentationFile=bin\Release\Savory.TransformService.Contract.xml;DebugType=none

nuget pack Savory.TransformService.Contract.nuspec

move /y Savory.TransformService.Contract.*.nupkg ..\..\savory-app\SavoryNuget\Packages

pause