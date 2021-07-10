using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FMC_Flex_To_Temp
{
    public partial class FMC : Form
    {
        //declaracion de variables
        Info _info;
        int ancho, alto;
        int bkAncho, bkAlto;

        int numAncho, numAlto, bkNumAncho, bkNumAlto;
        double isa, oat, elev, flextotemp, dato1;
         
        public FMC()
        {
            InitializeComponent();
            bkAncho = btnElev.Size.Width;
            bkAlto = btnElev.Size.Height;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 

            // Botonera superior 
            ancho = (btnElev.Size.Width * 90) / 100;
            alto = (btnElev.Size.Height * 90) / 100;


            //Botones numericos
            bkNumAncho = btn1.Size.Width;
            bkNumAlto = btn1.Size.Height;

            numAncho = (btn1.Size.Width * 90) / 100;
            numAlto = (btn1.Size.Height * 90) / 100;






        }

       





        private void btnIsa_MouseUp(object sender, MouseEventArgs e)
        {
            btnIsa.Size = new Size(bkAncho,bkAlto);

        }

        // todos los botones numericos linkeados
        private void btn1_MouseDown(object sender, MouseEventArgs e)
        {
            string cadena="";
            Button boton = (Button)sender;
            cadena = boton.Name;
            TB1.Text = TB1.Text + cadena.Replace("btn", "");
            boton.Size = new Size(numAncho, numAlto);




        }

        private void btn1_MouseUp(object sender, MouseEventArgs e)
        {
            string cadena = "";
            Button boton = (Button)sender;
            cadena = boton.Name;
            boton.Size = new Size(bkNumAncho, bkNumAlto);
        }

        private void btnPunto_MouseDown(object sender, MouseEventArgs e)
        {
            if (!TB1.Text.Contains(",")) 
                {
                    TB1.Text = TB1.Text + ",";
                }
            btnPunto.Size = new Size(numAncho, numAlto);



        }

        private void btnPunto_MouseUp(object sender, MouseEventArgs e)
        {
            btnPunto.Size = new Size(bkNumAncho, bkNumAlto);
        }

        private void btnNegativo_MouseDown(object sender, MouseEventArgs e)
        {
            double toggle=0;
            
            toggle  = Convert.ToDouble(TB1.Text) * (-1);
             
            
            TB1.Text = Convert.ToString(toggle);
            
            btnNegativo.Size = new Size(numAncho, numAlto);


        }

        private void btnNegativo_MouseUp(object sender, MouseEventArgs e)
        {
            btnNegativo.Size = new Size(bkNumAncho, bkNumAlto);

        }

        private void btnDel_MouseDown(object sender, MouseEventArgs e)
        {
            btnDel.Size = new Size(numAncho, numAlto);
            try
            {
                TB1.Text = TB1.Text.Substring(0, TB1.Text.Length - 1);
            }
            catch 
            {

            }
        }

        private void btnFlex_MouseDown(object sender, MouseEventArgs e)
        {
            // calcular el Flex to temp
            btnFlex.Size = new Size(numAncho, numAlto);
            try 
            {
                dato1 = isa - ((elev / 1000) * (1.98 * -1));

                flextotemp = oat + dato1;
                TB2.Text = Convert.ToString(Math.Round(flextotemp) + "°C"); 



            } 
            
            catch { }


        }

        private void btnInfo_MouseDown(object sender, MouseEventArgs e)
        {
            btnInfo.Size = new Size(numAncho, numAlto);
            _info = new Info();
            _info.ShowDialog();



        }

        private void btnInfo_MouseUp(object sender, MouseEventArgs e)
        {
            btnInfo.Size = new Size(bkNumAncho, bkNumAlto);

        }

        private void btnFlex_MouseUp(object sender, MouseEventArgs e)
        {
            btnFlex.Size = new Size(bkNumAncho, bkNumAlto);


        }

        private void btnDel_MouseUp(object sender, MouseEventArgs e)
        {
            btnDel.Size = new Size(numAncho, numAlto);
        }

        private void btnClear_MouseDown(object sender, MouseEventArgs e)
        {
            TB1.Text = "";
            btnClear.Size = new Size(numAncho, numAlto);

        }

        private void btnClear_MouseUp(object sender, MouseEventArgs e)
        {
            btnClear.Size = new Size(numAncho, numAlto);
        }

    

        // fin
        private void btnIsa_MouseDown(object sender, MouseEventArgs e)
        {
            btnIsa.Size = new Size(ancho, alto);
            try 
            {
               isa= Convert.ToDouble(TB1.Text);
               label4.Text = TB1.Text + "°";
                
            }

            catch { }

        }

        private void btnElev_MouseDown(object sender, MouseEventArgs e)
        {
            btnElev.Size = new Size(ancho, alto);
            try { elev = Convert.ToDouble(TB1.Text);
                lblElev.Text = TB1.Text;
            }
            catch { }
           

        }

        private void btnElev_MouseUp(object sender, MouseEventArgs e)
        {
            btnElev.Size = new Size(bkAncho, bkAlto);
          
        }

        private void btnOat_MouseDown(object sender, MouseEventArgs e)
        {
            
            btnOat.Size = new Size(ancho, alto);
            try
            {
                oat = Convert.ToDouble(TB1.Text);
                label5.Text = TB1.Text + "°C";
            }
            catch { }
            

        }

        private void btnOat_MouseUp(object sender, MouseEventArgs e)
        {
            btnOat.Size = new Size(bkAncho, bkAlto);
        }

        

       

       

       
    }
}
