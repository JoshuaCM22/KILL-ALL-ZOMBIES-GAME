using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace KILL_ALL_ZOMBIES_GAME // Created by: Joshua C. Magoliman
{
    public class CustomAudio
    {
        #region Fields
        private bool isBeingPlayed = false;
        private bool isLooping = false;
        // You can use String.Empty or "" to initialize a field to empty string. They are the same and not different.
        private string fullPath = String.Empty;
        private string fileName = "";
        #endregion

        #region Constructor    
        public CustomAudio(string param_FileName)
        {
            // Initializing the field called fileName to the parameter called param_FileName.
            this.fileName = param_FileName;
            // Get base directory path location.
            string getBaseDirectoryPath = AppDomain.CurrentDomain.BaseDirectory;
            // Combine it and to get the full path location.
            this.fullPath = string.Format("{0}Audios\\" + param_FileName, Path.GetFullPath(Path.Combine(getBaseDirectoryPath, @"..\..\..\")));
        }
        #endregion

        #region User Defined Methods
        private void PlayWorker()
        {
            /*
               Creating an object called stringBuilder using the class called StringBuilder.
               Because StringBuilder is mutable (it's changing) and System.String is immutable (not changing).
               That's why StringBuilder is used here.
            */
            StringBuilder stringBuilder = new StringBuilder();

            // Tnvoke the sound API method called mciSendString() and passed an arguments.
            mciSendString("open \"" + fullPath + "\" type waveaudio  alias " + this.fileName, stringBuilder, 0, IntPtr.Zero);
            mciSendString("play " + this.fileName, stringBuilder, 0, IntPtr.Zero);
            // Re assigning the value of field called isBeingPlayed
            isBeingPlayed = true;
            // Tnvoke the API method called mciSendString() and passed an arguments.
            mciSendString("status " + this.fileName + " length", stringBuilder, 255, IntPtr.Zero);
            // Get the length value of audio file.
            int length = Convert.ToInt32(stringBuilder.ToString());
            int currentPlaying = 0;
            // While the audio file is playing.
            while (isBeingPlayed)
            {
                // Tnvoke the API method called mciSendString() and passed an arguments.
                mciSendString("status " + this.fileName + " position", stringBuilder, 255, IntPtr.Zero);
                // Get the current playing.
                currentPlaying = Convert.ToInt32(stringBuilder.ToString());
                // If Audio is done playing.
                if (currentPlaying >= length)
                {
                    // If the field called isLooping have initialized with the value of false.
                    if (!isLooping)
                    {
                        // Stop the audio from playing.
                        isBeingPlayed = false; // Re assigning the value of field called isBeingPlayed.
                        break; // Exit in the while loop.
                    }
                    // Else the field called isLooping have initialized with the value of true.
                    else
                    {
                        // Play again the audio from the start.
                        mciSendString("play " + this.fileName + " from 0", stringBuilder, 0, IntPtr.Zero);
                    }
                }
            }
            // Tnvoke the API method called mciSendString() and passed an arguments.
            mciSendString("stop " + this.fileName, stringBuilder, 0, IntPtr.Zero);
            mciSendString("close " + this.fileName, stringBuilder, 0, IntPtr.Zero);
        }
        public void Play(bool param_IsLooping)
        {
            // If the file is not found.
            if (!File.Exists(fullPath))
            {
                MessageBox.Show("The file Audio is not found", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Else the file is found, then play the audio.
            else
            {
                // Re assign the value of field called isLooping from the value of parameter called param_IsLooping.
                isLooping = param_IsLooping;
                // Creating an object called threadStart using the delegate function called ThreadStart().       
                ThreadStart threadStart = new ThreadStart(PlayWorker);
                // Creating an object called workerThread1 using the class called Thread.       
                Thread workerThread1 = new Thread(threadStart);
                // Invoke the object and use the built-in function called Start().
                workerThread1.Start();
            }
        }
        public void StopPlaying()
        {
            // Re assigning the value of field called isBeingPlayed.
            isBeingPlayed = false;
        }
        #endregion

        #region Import the sound API function called mciSendString
        [DllImport("winmm.dll")]
        static extern Int32 mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

        [DllImport("winmm.dll", SetLastError = true, CallingConvention = CallingConvention.Winapi)]
        static extern bool PlaySound(
            string pszSound,
            IntPtr hMod,
            SoundFlags sf);

        // flags for playing sounds.  For this example, we are reading 
        // the sound from a filename, so we need only specify 
        // SND_FILENAME | SND_ASYNC

        [Flags]
        public enum SoundFlags : int
        {
            SND_SYNC = 0x0000,  // play synchronously (default) 
            SND_ASYNC = 0x0001,  // play asynchronously 
            SND_NODEFAULT = 0x0002,  // silence (!default) if sound not found 
            SND_MEMORY = 0x0004,  // pszSound points to a memory file
            SND_LOOP = 0x0008,  // loop the sound until next sndPlaySound 
            SND_NOSTOP = 0x0010,  // don't stop any currently playing sound 
            SND_PURGE = 0x40, // <summary>Stop Playing Wave</summary>
            SND_NOWAIT = 0x00002000, // don't wait if the driver is busy 
            SND_ALIAS = 0x00010000, // name is a registry alias 
            SND_ALIAS_ID = 0x00110000, // alias is a predefined ID
            SND_FILENAME = 0x00020000, // name is file name 
            SND_RESOURCE = 0x00040004  // name is resource name or atom 
        }
        #endregion
    }
}
