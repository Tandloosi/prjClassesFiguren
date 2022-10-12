namespace prjClassesFiguren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            
            int teller = 0;
           
            string strAantalFiguren = tbxAantalFiguren.Text;
            
            int AantalFiguren = Int32.Parse(tbxAantalFiguren.Text);
            
           
            

            do

            {



                teller++;

                Rectangle Rect = new Rectangle();

                
                Rect.Height = 100;
                Rect.Width = 100;

                Random R = new Random();
                int rndX = R.Next(0, pnlGrafischVlak.Width - Rect.Width);
                int rndY = R.Next(0, pnlGrafischVlak.Height - Rect.Height);
                Point Pt = new Point(rndX, rndY);
                Rect.Location = Pt;

                Pen P = new Pen(crd1.Color);

                Graphics G = pnlGrafischVlak.CreateGraphics();
                G.DrawRectangle(P, Rect);
                SolidBrush brush = new SolidBrush(crd1.Color);
                
                G.FillRectangle(brush, Rect);
            }
            while (teller < AantalFiguren);
           
            
            /*
            random kleuren
            aantal rectangles bepalen
            2de knop met andere figuur
            Polygoon meerdere points in een array.  
             */
            
            
        }

        private void tbxAantalFiguren_TextChanged(object sender, EventArgs e)
        {
            string strAantalFiguren = tbxAantalFiguren.Text;
            
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if(crd1.ShowDialog() == DialogResult.OK)
            {
                Color color = crd1.Color;
                btnColor.BackColor = color;

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            pnlGrafischVlak.Invalidate();
        }

        private void btnCirkel_Click(object sender, EventArgs e)
        {
            int teller = 0;

            string strAantalFiguren = tbxAantalFiguren.Text;

            int AantalFiguren = Int32.Parse(tbxAantalFiguren.Text);




            do

            {



                teller++;

                Rectangle Rect = new Rectangle();


                Rect.Height = 100;
                Rect.Width = 100;

                Random R = new Random();
                int rndX = R.Next(0, pnlGrafischVlak.Width - Rect.Width);
                int rndY = R.Next(0, pnlGrafischVlak.Height - Rect.Height);
                Point Pt = new Point(rndX, rndY);
                Rect.Location = Pt;

                Pen P = new Pen(crd1.Color);

                Graphics G = pnlGrafischVlak.CreateGraphics();
                G.DrawEllipse(P, Rect);
                SolidBrush brush = new SolidBrush(crd1.Color);
                
                G.FillEllipse(brush, Rect);
            }
            while (teller < AantalFiguren);
        }

        private void btnKruis_Click(object sender, EventArgs e)
        {
            int teller = 0;

            string strAantalFiguren = tbxAantalFiguren.Text;

            int AantalFiguren = Int32.Parse(tbxAantalFiguren.Text);




            do

            {



                teller++;

                Rectangle Rect = new Rectangle();


                Rect.Height = 150;
                Rect.Width = 100;

                Random R = new Random();
                int rndX = R.Next(0, pnlGrafischVlak.Width - Rect.Width);
                int rndY = R.Next(0, pnlGrafischVlak.Height - Rect.Height);
                Point Pt = new Point(rndX, rndY);
                Rect.Location = Pt;

                Pen P = new Pen(crd1.Color);

                System.Drawing.Point[] p = new System.Drawing.Point[5];
                p[0].X = rndX;
                p[0].Y = rndY;
                p[1].X = rndX + 20;
                p[1].Y = rndY;
                p[2].X = rndX + 100;
                p[2].Y = rndY + 150;
                p[3].X = rndX + 80;
                p[3].Y = rndY + 150;
                p[4].X = rndX;
                p[4].Y = rndY;
                
                System.Drawing.Point[] q = new System.Drawing.Point[5];
                q[0].X = rndX + 100;
                q[0].Y = rndY;
                q[1].X = rndX + 80;
                q[1].Y = rndY;
                q[2].X = rndX + 0;
                q[2].Y = rndY + 150;
                q[3].X = rndX + 20;
                q[3].Y = rndY + 150;
                q[4].X = rndX + 100;
                q[4].Y = rndY;

                
                Graphics G = pnlGrafischVlak.CreateGraphics();
                G.DrawPolygon(P, p);
                G.DrawPolygon(P, q);
                SolidBrush brush = new SolidBrush(crd1.Color);
                G.FillPolygon(brush, p);
                G.FillPolygon(brush, q);


            }
            while (teller < AantalFiguren);
        }

        private void btnMannetje_Click(object sender, EventArgs e)
        {

            int teller = 0;

            string strAantalFiguren = tbxAantalFiguren.Text;

            int AantalFiguren = Int32.Parse(tbxAantalFiguren.Text);




            do

            {



                teller++;

                Rectangle Rect = new Rectangle();
                

                Rect.Height = 150;
                Rect.Width = 100;

                

                Random R = new Random();
                int rndX = R.Next(0, pnlGrafischVlak.Width - Rect.Width);
                int rndY = R.Next(0, pnlGrafischVlak.Height - Rect.Height);
                Point Pt = new Point(rndX, rndY);
                Rect.Location = Pt;


                Rectangle Head = new Rectangle();
                Head.Height = 50;
                Head.Width = 60;
                Point H = new Point(rndX + 20, rndY + 5);
                Head.Location = H;


                Pen P = new Pen(crd1.Color);

                System.Drawing.Point[] p = new System.Drawing.Point[18];
                p[0].X = rndX + 0;
                p[0].Y = rndY + 150;

                p[1].X = rndX + 20;
                p[1].Y = rndY + 150;
                
                p[2].X = rndX + 50;
                p[2].Y = rndY + 100;
                
                p[3].X = rndX + 80;
                p[3].Y = rndY + 150;
                
                p[4].X = rndX + 100;
                p[4].Y = rndY + 150;
                
                p[5].X = rndX + 60;
                p[5].Y = rndY + 100;
                
                p[6].X = rndX + 60;
                p[6].Y = rndY + 80;
                
                p[7].X = rndX + 80;
                p[7].Y = rndY + 90;
                
                p[8].X = rndX + 100;
                p[8].Y = rndY + 85;
                
                p[9].X = rndX + 60;
                p[9].Y = rndY + 65;
                
                p[10].X = rndX + 60;
                p[10].Y = rndY + 50;
                
                p[11].X = rndX + 40;
                p[11].Y = rndY + 50;
                
                p[12].X = rndX + 40;
                p[12].Y = rndY + 65;
                
                p[13].X = rndX + 0;
                p[13].Y = rndY + 85;
                
                p[14].X = rndX + 20;
                p[14].Y = rndY + 90;
                
                p[15].X = rndX + 40; 
                p[15].Y = rndY + 80;

                p[16].X = rndX + 40;
                p[16].Y = rndY + 100;

                p[17].X = rndX + 0;
                p[17].Y = rndY + 150;




                Graphics G = pnlGrafischVlak.CreateGraphics();
                G.DrawPolygon(P, p);
                G.DrawEllipse(P, Head);

                SolidBrush brush = new SolidBrush(crd1.Color);
                G.FillPolygon(brush, p);
                G.FillEllipse(brush, Head);


            }
            while (teller < AantalFiguren);

        }
    }
}