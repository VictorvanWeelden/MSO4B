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
        bool SVG = false;

        public ShapeDrawingForm()
        {
            MenuStrip menuStrip = new MenuStrip();// korter gemaakt

            ToolStripDropDownItem menu = new ToolStripMenuItem("File");// ook korter gemaakt
            menu.DropDownItems.Add("Open...", null, openFileHandler);
            menu.DropDownItems.Add("Export...", null, exportHandler);
            menu.DropDownItems.Add("Exit", null, closeHandler);
            menu.DropDownItems.Add("Switch Canvas and SVG", null, SwitchHandler);
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

        void SwitchHandler(object sender, EventArgs e)
        {
           SVG = !SVG;
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

            saveFileDialog.Filter = "SVG files|*.svg";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    // Insert code here that generates the string of LaTeX
                    //   commands to draw the shapes
                    Pen pen = new Pen(Color.Black);
                    DM = new DrawSVG();
                    foreach (Shape shape in shapes)
                        shape.Draw(DM, pen);
                    using (StreamWriter writer = new StreamWriter(stream))
                    {            
                        //Write strings to the file here using:
                        writer.WriteLine("<?xml version=\"1.0\" standalone=\"no\"?>");
                        writer.WriteLine("< !DOCTYPE svg PUBLIC \" -//W3C//DTD SVG 1.1//EN\" \"http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd\" >");
                        writer.WriteLine("< svg xmlns = \"http://www.w3.org/2000/svg\" version = \"1.1\" > ");
                        foreach (string x in DrawSVG.text)
                        {
                            writer.WriteLine(x);
                        }
                        writer.WriteLine("</ svg >");
                        writer.Close();    
                    }
                }
            }
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            // Draw all the shapes
            Pen pen = new Pen(Color.Black); // pen toegevoegd
            if (SVG)
            {
                DM = new DrawSVG();              
            }
            else
            {
                DM = new DrawCanvas(e.Graphics, pen);
            }
            
            foreach (Shape shape in shapes)
                shape.Draw(DM, pen);
        }        
    }
}