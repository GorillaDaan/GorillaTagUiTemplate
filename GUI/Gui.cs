using BepInEx;
using Gorilla_Tag_Mod__Graic__V2;
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using Utilla;

namespace ModName
{
    /// <summary>
    /// This is your mod's main class.
    /// </summary>

    /* This attribute tells Utilla to look for [ModdedGameJoin] and [ModdedGameLeave] */
    [ModdedGamemode]
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin("com.author.gorillatag.GuiName", "GuiName", "1.0.0")]
    public class $safeprojectname$ : BaseUnityPlugin
    {
        bool inRoom;
        bool GUIEnabled = false;

        void Update()
        {
            if (Keyboard.current.tabKey.wasPressedThisFrame)
            {
                GUIEnabled = !GUIEnabled;
            }
        }

        /* This attribute tells Utilla to call this method when a modded room is joined */
        [ModdedGamemodeJoin]
        public void OnJoin(string gamemode)
        {
            //If you wanna make it modded only, put the code in update in here

            inRoom = true;
        }

        /* This attribute tells Utilla to call this method when a modded room is left */
        [ModdedGamemodeLeave]
        public void OnLeave(string gamemode)
        {


            inRoom = false;
        }
        private void OnGUI()
        {
            if (GUIEnabled)
            {
                GUI.Box(new Rect(10, 10, 150, 660), "UI");
                if (GUI.Button(new Rect(15, 320, 140, 40), "ModTitle"))
                {
                    NameYourMod();
                }
            }
        }

        public void NameYourMod()
        {
            //code your mod here
        }
    }
}
