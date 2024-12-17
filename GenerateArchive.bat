copy /y HideSorcererMarksMod\bin\Release\net5.0\HideSorcererMarksMod.dll HideSorcererMarksMod.dll
copy /y HideSorcererMarksMod\bin\Release\net5.0\HideSorcererMarksMod.pdb HideSorcererMarksMod.pdb
copy /y HideSorcererMarksMod\Info.json Info.json

tar.exe -acf HideSorcererMarksMod.zip HideSorcererMarksMod.dll HideSorcererMarksMod.pdb Info.json

del HideSorcererMarksMod.dll
del HideSorcererMarksMod.pdb
del Info.json

..\UnityModManagerInstaller\UnityModManager.exe