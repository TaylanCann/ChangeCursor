namespace ChangeCursor
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        async void MoveCursor()
        {
            // Set the Current cursor, move the cursor's Position,
            // and set its clipping rectangle to the form. 

            this.Cursor = new Cursor(Cursor.Current.Handle);
            Cursor.Position = new Point(Cursor.Position.X + 1, Cursor.Position.Y - 2);
            Cursor.Clip = new Rectangle(this.Location, this.Size);
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            MoveCursor();
        }
    }
}