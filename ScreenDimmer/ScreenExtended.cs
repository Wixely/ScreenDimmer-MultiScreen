using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Windows.Forms;

namespace Augustine.ScreenDimmer
{
    public class ScreenExtended
    {
        private static List<ScreenExtended> ScreenList;

        // Store a reference to the wrapped Screen object
        public Screen Screen { get; private set; }

        public string MOName { get; set; }

        public string MODeviceID { get; set; }

        public string MOPNPDeviceID { get; set; }

        public VBounds CheckboxBounds { get; set; } = new VBounds();

        // Constructor takes a Screen object as a parameter
        public ScreenExtended(Screen screen)
        {
            Screen = screen ?? throw new ArgumentNullException(nameof(screen));
        }

        public static List<ScreenExtended> GetScreenExtendeds()
        {
            ManagementScope scope = new ManagementScope($"\\\\localhost\\root\\WMI");
            scope.Connect(); // Connect to the specified computer
            ObjectQuery query = new ObjectQuery("SELECT * FROM WMIMonitorID");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(scope, query);

            var screenList = new List<ScreenExtended>();

            var ts = SystemInformation.MonitorCount;

            List<string> logs = new List<string>();

            var index = 0;
            foreach (var monitor in searcher.Get())
            {
                var uint16Array = monitor["SerialNumberID"] as UInt16[];
                var byteArray = new byte[uint16Array.Length * 2];
                Buffer.BlockCopy(uint16Array, 0, byteArray, 0, byteArray.Length);
                var SerialNumberID = byteArray != null ? Encoding.Unicode.GetString(byteArray).Trim('\0') : "";
                var InstanceName = monitor["InstanceName"].ToString();
                logs.Add($"{SerialNumberID}, {InstanceName}");
                var screen = Screen.AllScreens[index];

                screenList.Add(new ScreenExtended(screen)
                {
                    MOPNPDeviceID = SerialNumberID,
                    MODeviceID = InstanceName,
                    MOName = InstanceName
                });
                index++;
            }

            return screenList;
        }

        public string DeviceName => $"DSP_{CheckboxBounds.GridX}x{CheckboxBounds.GridY}";

        public System.Drawing.Rectangle Bounds => Screen.Bounds;

        public static List<ScreenExtended> AllScreens {
            get {
                if (ScreenList == null)
                    ScreenList = CalculateCheckboxPosition(GetScreenExtendeds());
                return ScreenList;
            }
        }
        public static List<ScreenExtended> CalculateCheckboxPosition(List<ScreenExtended> screens)
        {
            if (screens == null || screens.Count == 0)
                return screens;

            var minWidth = screens.Min(s => s.Screen.Bounds.Width);
            var minHeight = screens.Min(s => s.Screen.Bounds.Height);

            var minWidthHalf = minWidth * 0.5;/// 2.0f;
            var minHeightHalf = minHeight * 0.5;// / 2.0f;


            int checkboxSize = CheckboxButton.DefaultSize;
             
            //put in basic grid
            foreach (var w in screens)
            {
                var center = w.CenterPoint();
                var xcell = (float)(center.X) / (float)minWidth;
                var ycell = (float)(center.Y) / (float)minHeight;

                w.CheckboxBounds.GridX = (int)xcell;
                w.CheckboxBounds.GridY = (int)ycell;
            }

            //move grid to positive side
            var minX = screens.Min(s => s.CheckboxBounds.GridX);
            var minY = screens.Min(s => s.CheckboxBounds.GridY);
            foreach (var w in screens)
            {
                w.CheckboxBounds.GridX -= minX;
                w.CheckboxBounds.GridY -= minY;
            }

            //remove "blank" columns and rows
            var maxX = screens.Max(s => s.CheckboxBounds.GridX);
            var maxY = screens.Max(s => s.CheckboxBounds.GridY);

            for(int i = maxX; i > 0; i--)
            {
                var blankColumns = screens.Any(o => o.CheckboxBounds.GridX == i);
                if (!blankColumns)
                {
                    foreach (var scr in screens.Where(o => o.CheckboxBounds.GridX > i))
                        scr.CheckboxBounds.GridX -= 1;//remove
                }
            }

            for (int i = maxY; i > 0; i--)
            {
                var blankRows = screens.Any(o => o.CheckboxBounds.GridY == i);
                if (!blankRows)
                {
                    foreach (var scr in screens.Where(o => o.CheckboxBounds.GridY > i))
                        scr.CheckboxBounds.GridY -= 1;//remove
                }
            }

            foreach (var scr in screens)
            {
                scr.CheckboxBounds.X = (int)(scr.CheckboxBounds.GridX * checkboxSize);
                scr.CheckboxBounds.Y = (int)(scr.CheckboxBounds.GridY * checkboxSize); //rowIndex * checkboxSize;
                scr.CheckboxBounds.Width = checkboxSize;
                scr.CheckboxBounds.Height = checkboxSize;
            }

            return screens;
        }
        public override string ToString()
        {
            return $"{CheckboxBounds.X},{CheckboxBounds.Y}";
        }

        public Point CenterPoint()
        {
            var rect = Bounds;
            int centerX = rect.X;
            int centerY = rect.Y;
            return new Point(centerX, centerY);
        }

        public class VBounds
        {
            public int X;
            public int Y;
            public int Width;
            public int Height;

            public int GridX;
            public int GridY;

            public override string ToString()
            {
                return $"{X},{Y}";
            }
        }


    }
}
