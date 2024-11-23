using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WMPLib;


namespace ChessLogic
{
    public static class SoundAffects
    {

        public static void playMove()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = @"C:\Users\danie\School\Programing\move-self.mp3";
            player.controls.play();
        }

        public static void capturePiece()
        {
            WindowsMediaPlayer player = new WindowsMediaPlayer();
            player.URL = @"C:\Users\danie\School\Programing\capture.mp3";
            player.controls.play();
        }
    }
}
