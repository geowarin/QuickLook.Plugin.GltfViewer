![QuickLook icon](https://user-images.githubusercontent.com/1687847/29485863-8cd61b7c-84e2-11e7-97d5-eacc2ba10d28.png)

# QuickLook.Plugin.GltfViewer

Preview GLTF

# Gotchas

CEFSharp requires the build to specify x86/x64.
On my machine I build for x64 but I'm not sure what to distribute

# Building

1. `cd three-gltf-viewer && npm install && npm run build`
2. Build the program for x64
3. `Scripts && .\pack-zip.ps1`

# Developping

I hacked together a little script that kills quickLook, copies the file and restarts the program.

1. Change the path values in `Scripts\copy.ps1` to point to your install of QL
2. `cd three-gltf-viewer && npm install && npm run build`
3. Build the program for x64  
4. `cd Scripts && .\copy.ps1`

Repeat 3-4 (I committed run config for rider called `copy` that takes care of that)

# Libraries

* [CEFSharp](https://github.com/cefsharp/CefSharp)
* [GLTFViewer](https://github.com/donmccurdy/three-gltf-viewer.git)

## License

MIT License.
