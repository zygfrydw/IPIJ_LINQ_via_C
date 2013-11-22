using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Chapter07
{
    struct COORD
    {
        public short X, Y;
    }

    struct SMALL_RECT
    {
        public short Left, Top, Right, Bottom;
    }

    unsafe struct CONSOLE_SCREEN_BUFFER_INFOEX
    {
        public int StructureSize;
        public COORD ConsoleSize, CursorPosition;
        public short Attributes;
        public SMALL_RECT DisplayWindow;
        public COORD MaximumWindowSize;
        public short PopupAttributes;
        public int FullScreenSupported;
        public fixed int ColorTable[16];
    }

    [Description("Listing 7.11")]
    static class FixedSizeBufferDemo
	{
 		// The content of this class has been removed due to the author's rights
		// Full code you can download from http://csharpindepth.com/ 
	}
}