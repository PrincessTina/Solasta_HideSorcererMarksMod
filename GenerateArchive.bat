copy /y HideSorcererMarksMod\bin\Release\net481\HideSorcererMarksMod.dll HideSorcererMarksMod.dll
copy /y HideSorcererMarksMod\bin\Release\net481\HideSorcererMarksMod.pdb HideSorcererMarksMod.pdb
copy /y HideSorcererMarksMod\Info.json Info.json

tar.exe -acf HideSorcererMarksMod.zip HideSorcererMarksMod.dll HideSorcererMarksMod.pdb Info.json

del HideSorcererMarksMod.dll
del HideSorcererMarksMod.pdb
del Info.json

..\UnityModManagerInstaller\UnityModManager.exe