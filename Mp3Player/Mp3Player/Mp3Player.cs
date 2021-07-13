using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Mp3Player
{
    class Mp3Player
    {
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string lpstCommand, stringBuilder lpstReturnString, int uReturnLenght, int hwdCallBacck);
        
        public void open(string File)
        {
            string Format = @"open ""{0}"" type MPEGVideo alias MediaFile";
            string command = string.Format(Format, File);
            mciSendString(command, null, 0, 0);
        }

        public void play()
        {
            string command = "play MediaFile";
            mciSendString(command, null, 0, 0);
        }

        public void stop()
        {
            string command = "stop MediaFile";
            mciSendString(command, null, 0, 0);
        }
    }
}
