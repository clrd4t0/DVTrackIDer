using UnityEngine;                                  //Referenced from NexusMods Wiki
using UnityModManagerNet;                           //This too
using System.Text;                                  //For the StringBuilder below

/* 
 * This is my first time writing anything in C#, so WHO KNOWS what will happen lmao but let's go.
 */


namespace DVTrackIDer
{
    public class Main
    {

        public static UnityModManager.ModEntry mod; //Copied

        static bool Load(UnityModManager.ModEntry modEntry)     //Do this when loading the Mod
        {
            mod = modEntry;                         //All of these
            mod.OnUpdate = OnUpdate;                //are copied
            return true;                            //from other mods
        }

        static void OnUpdate(UnityModManager.ModEntry mod, float arg2)      //Basically Greenfoot's act()
        {
            if (DetectKeyPress())                   //Print something if F7 is pressed
            {
                StringBuilder output = new StringBuilder(string.Format("Track ID of current track: {0}.", PrintTrackID()));     //Build the string
                mod.Logger.Log(output.ToString());  //Print the string
            }
        }

        static bool DetectKeyPress()                //Check if F7 is pressed
        {
            Input.GetKeyDown ? true : false;        //The actual checking
        }

        static string PrintTrackID()
        {
            return "UNKNOWN";
            /* 
             * Just print unknown for now
             * Until I find out how to do the following:
             * 1) Track (as in follow) the train the player is driving
             * 2) Get the trackID of the section of track the player is on
             */
        }
    }
}
