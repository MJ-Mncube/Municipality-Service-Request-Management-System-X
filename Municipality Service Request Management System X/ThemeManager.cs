using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Municipality_Service_Request_Management_System_X
{
    public static class ThemeManager
    {
        public static bool IsDark { get; set; } = false;

        private static readonly Dictionary<Form, Color> originalBackColors =
            new Dictionary<Form, Color>();

        private static readonly Dictionary<Form, Color> originalForeColors =
            new Dictionary<Form, Color>();

        public static void LoadTheme()
        {
            string filePath = Path.Combine(
                Application.StartupPath, "settings.txt");

            if (!File.Exists(filePath))
            {
                IsDark = false;
                return;
            }

            foreach (string line in File.ReadAllLines(filePath))
            {
                string[] parts = line.Split(new char[] { '=' }, 2);

                if (parts.Length == 2 &&
                    parts[0].Trim().Equals(
                        "Theme", StringComparison.OrdinalIgnoreCase))
                {
                    IsDark = parts[1].Trim().Equals(
                        "Dark", StringComparison.OrdinalIgnoreCase);

                    return;
                }
            }

            IsDark = false;
        }

        public static void ApplyTheme(Form form)
        {
            // Remember the form's original colours the first time.
            if (!originalBackColors.ContainsKey(form))
            {
                originalBackColors[form] = form.BackColor;
                originalForeColors[form] = form.ForeColor;
            }

            if (IsDark)
            {
                form.BackColor = Color.FromArgb(36, 36, 36);
                form.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                // Restore the form's original colours.
                form.BackColor = originalBackColors[form];
                form.ForeColor = originalForeColors[form];
            }
        }
    }
}