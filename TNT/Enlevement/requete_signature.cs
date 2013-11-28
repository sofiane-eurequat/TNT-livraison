using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Collections;
using System.IO;
using TNT.con_req;


namespace TNT.Enlevement
{
    class requete_signature : Control
    {

        private string background = null;

        public string Background
        {
            get
            {
                return background;
            }
            set
            {
                background = value;
            }
        }

        public static Bitmap image;

        Graphics graphe;
        Pen stilet = new Pen(Color.Black);
        ArrayList vecteur = new ArrayList();
        Point point = new Point(0, 0);
        bool dessiner = false;



        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            CreateGdiObject();
            e.Graphics.DrawImage(image, 0, 0);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!dessiner)
            {
                dessiner = true;
                point.X = e.X;
                point.Y = e.Y;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if (dessiner)
            {
                dessiner = false;

            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (dessiner)
            {
                graphe.DrawLine(stilet, point.X, point.Y, e.X, e.Y);
                vecteur.Add(point.X + "" + point.Y + "" + e.X + "" + e.Y);
                point.X = e.X;
                point.Y = e.Y;
                Invalidate();
            }
        }

        public void Clear()
        {
            vecteur.Clear();
            InitMemoryBitmap();
            Invalidate();

        }

        private void CreateGdiObject()
        {
            if (image == null || image.Width != this.Width || image.Height != this.Height)
            {
                InitMemoryBitmap();
            }

        }

        private void InitMemoryBitmap()
        {
            if (this.Background == null)
            {
                image = new Bitmap(this.Width, this.Height);
                graphe = Graphics.FromImage(image);
                graphe.Clear(Color.White);
            }
            else
            {
                image = new Bitmap(this.Background);
                graphe = Graphics.FromImage(image);
            }

        }



        public static int enregistrement_image(string chemin)
        {
            try
            {
                string requete = "INSERT INTO [enlevement] (signature_enlev)   VALUES ('" + chemin.ToString() + "')";
                int nbr = Requete.ExecuteUpdate(requete);


                if (nbr != -1)
                {
                    MessageBox.Show("bien enregisté");
                }
                else
                {
                    MessageBox.Show("mal enregisté");
                }
                return nbr;
            }
            catch
            {
                return -1;
            }

        }

    }
}
