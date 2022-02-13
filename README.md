# ISuckAtGameDev.Tools

I Suck at Game Dev Tools is a set of tools for Unity to help make your life easier. I based this on a couple of videos from Jason Storey, you can check them out on his [Youtube channel](https://www.youtube.com/c/JasonStorey).

## How to Install

You can clone this repo down to your computer, and in Package Manager, add a package from disk, and navigate to package.json in your local repo.

Or

Inside Package Manager, you can add package from git URL, and use <https://github.com/isagd/ISuckAtGameDev.Tools.git> for the URL.

Once installed, you should see a new menu at the top of Unity called "ISAGD Tools".

## What's inside?

As of right now, there is a few Setup helpers to help get your project started off. More will be added in the future...

### Setup Menu

Inside this menu is helpers to get a new project started.

#### Create Default Folders

This creates a basic folder structure for your project. It addes the following folders inside the Assets directory.

- _Project
  - Art
  - Prefabs
  - Scenes
  - Scripts
  - Settings

#### Packages

The options under this just add the specified Unity package to the Unity package manifest.json file. This is quicker than opening up the Package Manager, and searching for thme individually.

**Current list of options:**

- Cinemachine
- New Input system
