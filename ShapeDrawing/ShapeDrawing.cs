using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Collections.Generic;

namespace ShapeDrawing
{
    public class ShapeDrawingForm : Form
    {
        private List<Shape> shapes;
        public DrawMethods DM;   

        public ShapeDrawingForm()
        {
            MenuStrip menuStrip = new MenuStrip();// korter gemaakt

            ToolStripDropDownItem menu = new ToolStripMenuItem("File");// ook korter gemaakt
            menu.DropDownItems.Add("Open...", null, openFileHandler);
            menu.DropDownItems.Add("Export...", null, exportHandler);
            menu.DropDownItems.Add("Exit", null, closeHandler);
            menuStrip.Items.Add(menu);

            Controls.Add(menuStrip);
            // Some basic settings
            Text = "Shape Drawing and Converter";
            Size = new Size(400, 400);
            CenterToScreen();
            SetStyle(ControlStyles.ResizeRedraw, true);

            // Initialize shapes
            shapes = new List<Shape>();

            // Listen to Paint event to draw shapes
            Paint += new PaintEventHandler(OnPaint);
        }

        // What to do when the user closes the program
        private void closeHandler(object sender, EventArgs e)
        {
            Close();
        }

        // What to do when the user opens a file
        private void openFileHandler(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "";
            dialog.Title = "Open file...";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                shapes = Parser.ParseShapes(dialog.FileName);
                Refresh();
            }
        }

        // What to do when the user wants to export a TeX file
        private void exportHandler(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "TeX files|(*.tex)";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    // Insert code here that generates the string of LaTeX
                    //   commands to draw the shapes
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        // Write strings to the file here using:
                        //   writer.WriteLine("Hello World!");
                    }
                }
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            // Draw all the shapes
            Pen pen = new Pen(Color.Black); // pen toegevoegd
            if (true)
            {
                DM = new DrawCanvas(e.Graphics, pen);
            }
            else
            {
                DM = new DrawSVG();
            }
            
            foreach (Shape shape in shapes)
                shape.Draw(DM, pen);
        }        
    }
}