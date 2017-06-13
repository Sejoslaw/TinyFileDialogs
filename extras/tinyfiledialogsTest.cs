/*_________
 /         \ tinyfiledialogsTest.cs v2.8.4 [Jun 13, 2017] zlib licence
 |tiny file| C# bindings created [2015]
 | dialogs | Copyright (c) 2014 - 2017 Guillaume Vareille http://ysengrin.com
 \____  ___/ http://tinyfiledialogs.sourceforge.net
	  \|
						git://git.code.sf.net/p/tinyfiledialogs/code
	 ______________________________________________________
	|                                                      |
	| direct CONTACT:  mailto:tinyfiledialogs@ysengrin.com |
	|______________________________________________________|
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

class tinyfd
{
    // cross platform utf8
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    public static extern int tinyfd_messageBox(string aTitle, string aMessage, string aDialogTyle, string aIconType, int aDefaultButton);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr tinyfd_inputBox(string aTitle, string aMessage, string aDefaultInput);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr tinyfd_saveFileDialog(string aTitle, string aDefaultPathAndFile, int aNumOfFilterPatterns, string[] aFilterPatterns, string aSingleFilterDescription);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr tinyfd_openFileDialog(string aTitle, string aDefaultPathAndFile, int aNumOfFilterPatterns, string[] aFilterPatterns, string aSingleFilterDescription, int aAllowMultipleSelects);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr tinyfd_selectFolderDialog(string aTitle, string aDefaultPathAndFile);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr tinyfd_colorChooser(string aTitle, string aDefaultHexRGB, byte[] aDefaultRGB, byte[] aoResultRGB);

    // windows only utf16
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
    public static extern int tinyfd_messageBoxW(string aTitle, string aMessage, string aDialogTyle, string aIconType, int aDefaultButton);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
    public static extern string tinyfd_saveFileDialogW(string aTitle, string aDefaultPathAndFile, int aNumOfFilterPatterns, string[] aFilterPatterns, string aSingleFilterDescription);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
    public static extern string tinyfd_openFileDialogW(string aTitle, string aDefaultPathAndFile, int aNumOfFilterPatterns, string[] aFilterPatterns, string aSingleFilterDescription, int aAllowMultipleSelects);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
    public static extern string tinyfd_selectFolderDialogW(string aTitle, string aDefaultPathAndFile);
    [DllImport("C:\\Users\\frogs\\tinyfd\\tinyfiledialogs32.dll", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.Cdecl)]
    public static extern string tinyfd_colorChooserW(string aTitle, string aDefaultHexRGB, byte[] aDefaultRGB, byte[] aoResultRGB);

}

namespace ConsoleApplication1
{
    class tinyfiledialogsTest
    {
        private static string stringFromChar(IntPtr ptr)
        {
            return System.Runtime.InteropServices.Marshal.PtrToStringAnsi(ptr);
        }

        static void Main(string[] args)
        {
            // cross platform utf8
            IntPtr lulu = tinyfd.tinyfd_inputBox("input box", "gimme a string", "lolo");
            string lolo = stringFromChar(lulu);

            // cross platform utf8
            int lala = tinyfd.tinyfd_messageBox("message box", lolo, "ok", "info", 1);

            // windows only utf16
            int lili = tinyfd.tinyfd_messageBoxW("message box W", lolo, "ok", "warning", 1);
        }
    }
}
