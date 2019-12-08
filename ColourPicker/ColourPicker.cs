using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace ColourPicker
{
    public partial class ColourPicker : Form
    {

        // RGB value
        public static string rgb = "255, 255, 255";
        // HEX value
        public static string hex = "FFFFFF";

        // Hook Setup
        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelMouseProc proc)
        {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule)
            {
                IntPtr hook = SetWindowsHookEx(WH_MOUSE_LL, proc, GetModuleHandle("user32"), 0);
                if (hook == IntPtr.Zero) throw new System.ComponentModel.Win32Exception();
                return hook;
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(
          int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && MouseMessages.WM_LBUTTONDOWN == (MouseMessages)wParam)
            {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                MouseAction(null, new EventArgs());
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;

        private enum MouseMessages
        {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINT
        {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct MSLLHOOKSTRUCT
        {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        // Global cursor position
        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        // Windows hook
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
            LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
          IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);

        // MouseAction event hook
        public static event EventHandler MouseAction = delegate { };

        // ColourPicker constructor
        public ColourPicker()
        {
            InitializeComponent();

            //Custom global mouse click event
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ColourPicker));
            this.BtnCopyHex = new System.Windows.Forms.Button();
            this.LblHex = new System.Windows.Forms.Label();
            this.BtnCopyRGB = new System.Windows.Forms.Button();
            this.LblRGB = new System.Windows.Forms.Label();
            this.MoveMouse = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();

            ColourPicker.Start();
            ColourPicker.MouseAction += new System.EventHandler(MouseClickEvent);
        }

        // Start hook
        public static void Start()
        {
            _hookID = SetHook(_proc);


        }
        // Stop hook
        public static void Stop()
        {
            UnhookWindowsHookEx(_hookID);
        }

        // Get Colour of pixel at specified pixel coordinates
        public Color GetColorAt(Point location)
        {
            Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);

            using (Graphics gdest = Graphics.FromImage(screenPixel))
            {
                using (Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero))
                {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }

        // Global mouse click event
        private void MouseClickEvent(object sender, EventArgs e)
        {
            Point cursor = new Point();
            GetCursorPos(ref cursor);

            if (!new RectangleF(this.Location.X, this.Location.Y, this.Width, this.Height).Contains(cursor))
            {
                var c = GetColorAt(cursor);
                this.BackColor = c;

                rgb = $"{c.R}, {c.G}, {c.B}";

                hex = c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");

                LblRGB.Text = rgb;

                LblHex.Text = hex;
            }
        }

        private void BtnCopyRGB_Click(object sender, EventArgs e)
        {
            // Copy RGB to clipboard
            Clipboard.SetText(rgb);
        }

        private void BtnCopyHex_Click(object sender, EventArgs e)
        {
            // Copy HEX to clipboard
            Clipboard.SetText(hex);
        }

        private void ColourPicker_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Unhook
            Stop();
        }
    }
    
}
