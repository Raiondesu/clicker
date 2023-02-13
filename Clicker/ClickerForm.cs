using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Clicker
{
    public partial class ClickerForm : Form
    {
        static Thread ClickThread = new Thread(ClickerProcess);
        globalKeyboardHook gkh = new globalKeyboardHook();

        Keys ExecKey, ClickKey, ExitKey;

        KeysConverter regKey = new KeysConverter();

        static string Adress = "Software\\InsaneClicker";
        RegistryKey reg = Registry.CurrentUser.CreateSubKey(Adress);

        private Point mouseOffset;
        static bool on = false, isMouseDown = false;
        bool shouldClick = false, shouldExit = false;
        static Point curPos = new Point();

        [STAThread]
        static void Main(string[] args)
        {
            if (System.Diagnostics.Process.GetProcessesByName(Application.ProductName).Length > 1)
            {
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ClickerForm());
            }
        }

        [DllImport("User32.dll")]
        static extern void mouse_event(MouseFlags dwFlags, int dx, int dy, int dwData, UIntPtr dwExtraInfo);

        [Flags]
        enum MouseFlags
        {
            LeftDown = 0x2,
            LeftUp = 0x4
        };

        public static void ClickerProcess()
        {
            try
            {
                while (on)
                {
                    curPos = Cursor.Position;
                    mouse_event(MouseFlags.LeftDown | MouseFlags.LeftUp, Cursor.Position.X, Cursor.Position.Y, 0, UIntPtr.Zero);
                    System.Threading.Thread.Sleep(4);
                    if (Cursor.Position != curPos)
                        if (Math.Abs(Cursor.Position.X - curPos.X) > 2 || Math.Abs(Cursor.Position.Y - curPos.Y) > 2)
                        {
                            on = false;
                        }
                }
            } catch {}
        }

        public ClickerForm()
        {
            InitializeComponent();
        }

        private void ClickerForm_Load(object sender, EventArgs e)
        {
            if (reg != null)
            {
                try
                {
                    ExecKey = (Keys)regKey.ConvertFromString((string)reg.GetValue("ExecKey"));
                }
                catch { ExecKey = Keys.Home; }
                try
                {
                    ClickKey = (Keys)regKey.ConvertFromString((string)reg.GetValue("ClickKey"));
                }
                catch { ClickKey = Keys.Insert; }
                try
                {
                    ExitKey = (Keys)regKey.ConvertFromString((string)reg.GetValue("ExitKey"));
                }
                catch { ExitKey = Keys.Delete; }
            }
            ExecKeyBox.Text = ExecKey.ToString();
            ClickKeyBox.Text = ClickKey.ToString();
            ExitKeyBox.Text = ExitKey.ToString();

            gkh.HookedKeys.Add(ExecKey);
            gkh.HookedKeys.Add(ClickKey);
            gkh.HookedKeys.Add(ExitKey);
            gkh.KeyDown += gkh_KeyDown;
            gkh.KeyUp += gkh_KeyUp;
        }

        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClickKey)
            {
                shouldClick = true;
                e.Handled = true;
            }
            if (e.KeyCode == ExitKey)
            {
                shouldExit = true;
                e.Handled = true;
            }
            if (e.KeyCode == ExecKey)
            {
                if (shouldClick)
                {
                    ClickThread.Interrupt();

                    if (on = !on)
                    {
                        ClickThread = new Thread(ClickerProcess);
                        ClickThread.Start();
                    }
                }

                if (shouldExit)
                {
                    CloseButt_Click(sender, e);
                }

                e.Handled = true;
            }
        }

        void gkh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == ClickKey)
            {
                shouldClick = false;
                e.Handled = true;
            }
            if (e.KeyCode == ExitKey)
            {
                shouldExit = false;
                e.Handled = true;
            }
        }

        private void MinimButt_Click(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized != WindowState)
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void CloseButt_Click(object sender, EventArgs e)
        {
            this.Dispose(true);
        }

        private void ClickerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ClickThread?.Interrupt();

            reg = Registry.CurrentUser.CreateSubKey(Adress);

            reg.SetValue("ExecKey", ExecKey);
            reg.SetValue("ClickKey", ClickKey);
            reg.SetValue("ExitKey", ExitKey);

            reg.Close();
        }

        private void ExecKeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (e.KeyCode != ClickKey && e.KeyCode != ExitKey)
            {
                gkh.HookedKeys.Remove(ExecKey);
                ExecKey = e.KeyCode;
                gkh.HookedKeys.Add(ExecKey);
                ExecKeyBox.Text = e.KeyCode.ToString();
                reg.SetValue("ExecKey", ExecKey);
            }
            e.Handled = true;
        }

        private void ClickKeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (e.KeyCode != ExecKey && e.KeyCode != ExitKey)
            {
                gkh.HookedKeys.Remove(ClickKey);
                ClickKey = e.KeyCode;
                gkh.HookedKeys.Add(ClickKey);
                ClickKeyBox.Text = e.KeyCode.ToString();
                reg.SetValue("ClickKey", ClickKey);
            }
            e.Handled = true;
        }

        private void ExitKeyBox_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
            if (e.KeyCode != ClickKey && e.KeyCode != ExecKey)
            {
                gkh.HookedKeys.Remove(ExitKey);
                ExitKey = e.KeyCode;
                gkh.HookedKeys.Add(ExitKey);
                ExitKeyBox.Text = e.KeyCode.ToString();
                reg.SetValue("ExitKey", ExitKey);
            }
            e.Handled = true;
        }

        private void ClickerAppMenu_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X;
                yOffset = -e.Y;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void ClickerAppMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void ClickerAppMenu_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
        }
    }
}