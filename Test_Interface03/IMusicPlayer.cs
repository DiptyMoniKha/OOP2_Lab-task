using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface03
{
    interface IMusicPlayer
    {
        void Switch(Boolean on);
        void Play(Boolean on);
        void SetVolume(int loudness);
        void PlayNext();
        void PlayPrevious();
    }
}
