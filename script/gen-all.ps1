
#generate all nugets of all my libs in correct order
$path = "C:\atari-monk\nugets";

#generate nugets of my libs independent from my other libs 
$libs0 = 'Xml.Generator', 'Vector.Lib'
#generate nugets of my libs dependent on my independent libs
$libs1 = 'Sim.Core'
#generate nugets of my libs dependent on my dependent libs
$libs2 = 'Shape.Model', 'Canvas'

#up from script dir
Set-Location ..

foreach ($lib in $libs0 + $libs1 + $libs2) {
  Set-Location $lib
  dotnet pack -c Release -o $path
  #up from lib dir
  Set-Location ..
}