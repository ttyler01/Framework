msbuild.exe ..\sources\Framework.sln /property:Configuration=Release /m 
sn -R "..\bin\Release\Portable\OutcoldSolutions.Diagnostics.ObjectReleaseVerification.dll" D:\SkyDrive\PC\Tools\OutcoldSolutions.snk
sn -R "..\bin\Release\Portable\OutcoldSolutions.InversionOfControl.dll" D:\SkyDrive\PC\Tools\OutcoldSolutions.snk
sn -R "..\bin\Release\Portable\OutcoldSolutions.Framework.dll" D:\SkyDrive\PC\Tools\OutcoldSolutions.snk
nuget pack "..\sources\Portable\OutcoldSolutions.Framework\OutcoldSolutions.Framework.csproj" -basepath "..\bin\Release\Portable" -prop Configuration=Release
nuget pack "..\sources\Portable\OutcoldSolutions.Diagnostics.ObjectReleaseVerification\OutcoldSolutions.Diagnostics.ObjectReleaseVerification.csproj" -basepath "..\bin\Release\Portable" -prop Configuration=Release
nuget pack "..\sources\Portable\OutcoldSolutions.InversionOfControl\OutcoldSolutions.InversionOfControl.csproj" -basepath "..\bin\Release\Portable" -prop Configuration=Release