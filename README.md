# Solasta_HideSorcererMarksMod
Allows you to create your new Sorcerer character without Sorcerer specific markings (forced body decoration and eyes style).

## How to use in game
* Download mod as HideSorcererMarksMod.zip from [releases section](https://github.com/PrincessTina/Solasta_HideSorcererMarksMod/releases/).
* Download [Unity Mod Manager](https://www.nexusmods.com/site/mods/21?tab=files&file_id=2705) and extract UnityModManagerInstaller.zip to a folder of your preference [don't use the Solasta game folder]
* Setup UMM:
  - Start the program UnityModManager.exe
  - Select _Solasta_ from the list of available games.
  - Select the game folder in case UMM fails to auto detect it.
  - Select _DoorstopProxy_ installation method, if it's available.
* Install Solasta_HideSorcererMarksMod: drag and drop downloaded HideSorcererMarksMod.zip over the UMM's "Mods" tab. If everything went well, the mod should appear with green status indicator in UMM window with list of all installed mods on game start. You may deinstall this mod in UMM after completing character's creation, since you only need its logic due character's creation.

## How to modify mod's code
* You will need installed Unity Mod Manager, Visual Studio Community 2022 with components for .NET and Unity games development. Current target NET framework is NET 5.0.
* Open HideSorcererMarksMod.sln and add refences to game files, if they aren't set. Check out [project creation section](https://wiki.nexusmods.com/index.php/How_to_create_mod_for_unity_game) from Nexus Mods guide.
* Then rebuild solution for Release configuration.
* Start GenerateArchive.bat that will generate you HideSorcererMarksMod.zip, but make sure that Solasta_HideSorcererMarksMod directory is in the same folder with UnityModManagerInstaller directory.
* Install mod in opened UMM window by drag and drop HideSorcererMarksMod.zip to "Mods" section. If you already have this mod installed, deinstall it first, so you could install its fresh version.
* Run the game.
