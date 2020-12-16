#Remove-Item ..\QuickLook.Plugin.HelloWorld.qlplugin -ErrorAction SilentlyContinue

$ql = "C:\Users\perso\scoop\apps\quicklook\current\UserData\QuickLook.Plugin\"
$plugin = "QuickLook.Plugin.HelloWorld"

tskill.exe quicklook
Start-Sleep 1

$dir = Join-Path $ql $plugin
echo "Removing $dir"
Remove-Item $dir -Recurse

echo "End"
mkdir $dir

Copy-Item -Path ..\three-gltf-viewer\dist\* -Destination ..\bin\Release\three-gltf-viewer -ErrorAction SilentlyContinue
Copy-Item -Path ..\bin\Release\* -Recurse -Exclude *.pdb,*.xml -Destination $dir

& "C:\Users\perso\scoop\apps\quicklook\current\QuickLook.exe"
