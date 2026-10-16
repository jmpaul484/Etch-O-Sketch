namespace Etch_O_Sketch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PictureBox.MouseMove += PictureBox_MouseMove;
            PictureBox.MouseDown += PictureBox_MiddleMouseClick;

            ColorComboBox.DataSource = presetColors;
            ColorComboBox.DisplayMember = "name";
            ColorComboBox.SelectedItem = Color.Black;
            ColorComboBox.SelectedIndexChanged += ColorComboBox_SelectedIndexChanged;
        }
        int lastX, lastY;
        private Color CurrentColor = Color.Black;
        Color[] presetColors = Enum.GetValues(typeof(KnownColor))
                           .Cast<KnownColor>()
                           .Select(Color.FromKnownColor)
                           .Where(c => !c.IsSystemColor && c != Color.Transparent)
                           .ToArray();
        void DrawLine(int x, int y)
        {
            using (Graphics g = PictureBox.CreateGraphics())
            using (Pen MyPen = new Pen(CurrentColor, 2))
            {
                g.DrawLine(MyPen, lastX, lastY, x, y);

            }
        }
        private void ColorComboBox_SelectedIndexChanged(Object? sender, EventArgs e)
        {
            if (ColorComboBox.SelectedItem is Color selectedColor)
            {
                CurrentColor = selectedColor;
                ColorComboBox.Visible = false;
            }
        }
        private void PictureBox_MiddleMouseClick(Object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                ColorComboBox.Visible = true;
                ColorComboBox.Location = new Point(e.X, e.Y);
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            exitToolStripMenuItem_Click(sender, e);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            PictureBox.Refresh();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PictureBox_MouseMove(object? sender, MouseEventArgs e)
        {
           
            this.Text = $"Etch-O-Sketch - X: {e.X}, Y: {e.Y}";
            if (e.Button == MouseButtons.Left)
            {
                DrawLine(e.X, e.Y);
            }
            lastX = e.X;
            lastY = e.Y;
        }
    }
}
