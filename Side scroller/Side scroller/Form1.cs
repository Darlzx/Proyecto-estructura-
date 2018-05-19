using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Side_scroller
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer sp = new System.Media.SoundPlayer(@"C:\Users\diego\Documents\Proyecto-estructura-\ost.wav");
        
        bool goleft = false; //valor booleano que controla el movimiento a la izquierda
        bool goright = false; // valor booleano que controla el mivimiento a la derecha
        bool jumping = false; // control booleano para verificar si el jugador esta saltando o no
        bool haskey = false; // valor por defecto de si el jugador ya captuo la llave o no

        int jummpspeed = 6; // valor de la velocidad de salto
        int force = 8; // valor de la fuerza de salto
        int score = 0; // valor por defecto del puntaje

        int playspeed = 8; // velocidad de el jugador
        int backleft = 8; //velocidad de movimiento del fondo de pantalla
        public Form1()
        {
            sp.PlayLooping();

            InitializeComponent();
        }

        private void MainGameTimer(object sender, EventArgs e)
        {
            //conectamos  el valor de jumpspeed con la locacion del jugador
            player.Top += jummpspeed;

            //refrescar la picturebox dle jugador
            player.Refresh();

            // si el jugador esta saltando y la fuerza es menor que 0
            //entonces cambiamos el valor de salto a 0
            if (jumping && force < 0)
            {
                jumping = false;
            }

            // si el jugador esta saltando  entonces cambiamos la jumpspeed a -12
            //y disminuimos la fuerza por -1
            if (jumping)
            {
                jummpspeed = -12;
                force -= 1;
            }

            else
            {
                //si no es asi cambiamos la velocidad de salto a 12
                jummpspeed = 8;
            }

            //si el valor de goleft es verdadero y el espacio a la izquierda del jugador
            //es mas de 100 pixeles solo entonces el jugador se movera a la izquierda
            if (goleft && player.Left > 1)
            {
                player.Left -= playspeed;
            }

            //si goright es verdadero el jugador se mueve a la derecha 
            if (goright && player.Left + (player.Width + 1) < this.ClientSize.Width)
            {
                player.Left += playspeed;
            }

            // si el valor de goright y el el resto de la imagen de fondo es mayor que 1200
            //entonces movemos el fondo hacia la izquierda
            if (goright && background.Left > -900)
            {
                background.Left -= backleft;

                //hacemos un foreach  para controlar las monedas y las paltaformas
                //cuando las encuentre las movera a la izquierda 
                foreach(Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key" )
                    {
                        x.Left -= backleft;
                    }
                }
            }

            //si goleft es verdadero y si las imagenes de fondo son menos que 2 
            // entonces movemos la imagen de fondo a la derecha
            if (goleft && background.Left < 2)
            {
                background.Left += backleft;
                //hacemos un foreach  para controlar las monedas y las paltaformas
                //cuando las encuentre las movera a la derecha junto con el fondo
                foreach (Control x in this.Controls)
                {
                    if (x is PictureBox && x.Tag == "platform" || x is PictureBox && x.Tag == "coin" || x is PictureBox && x.Tag == "door" || x is PictureBox && x.Tag == "key")
                    {
                        x.Left += backleft;
                    }
                }
            }

            //en el siguiente bucle se reviza todos los controles del formulario
            foreach (Control x in this.Controls)
            {
                //x es una picture box y tiene una etiqueta de plataforma
                if (x is PictureBox && x.Tag == "platform")
                {
                    //luego verificamos si el usuario esta colicionando con la plataforma
                    //y jumping se pone en falso
                    if (player.Bounds.IntersectsWith(x.Bounds) && !jumping)
                    {
                        force = 8; // se asigna la fuerza a 8
                        player.Top = x.Top - player.Height;//luego movemos al jugador arriba de la picture box
                        jummpspeed = 0; // asignamos la velocidad de saltar a 0
                    }
                }
                // si la picture box tiene la etiqueta de moneda
                if (x is PictureBox && x.Tag == "coin")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);// con esto eliminamos la moneda
                        score++;//se suma uno al puntaje
                        
                    }
                }
            }

            //si el jugador closiona con la puerta y el valor de tener llave es verdadero
            if (player.Bounds.IntersectsWith(door.Bounds) && haskey)
            {
                door.Image = Properties.Resources.door_open;
                // y se detiene el timer
                gameTimer.Stop();
                MessageBox.Show("Completaste el juego!!!! y su puntaje final fue de: "+score+"Sigamos al siguiente nivel ");// mostrar mensaje
                
                Form2 frm2 = new Form2();
                this.Hide();
                frm2.ShowDialog();

                this.Close();
            }

            if (player.Bounds.IntersectsWith(key.Bounds))
            {
                this.Controls.Remove(key);
                haskey = true;
            }

            //aqui tuesta
            if (player.Top + player.Height > this.ClientSize.Height + 60)
            {
                gameTimer.Stop();
                MessageBox.Show("tostaste sos malo ");                
                
            }
            
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //si el jugador presiono la tecla izquierdaa y esta dentro del panel
            //cambiamos el valor de goleft a true
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
            }
            // si el jugador presiono la tecla derecha 
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
            }
            // si el jugador presionola tecla espacio y el valor de jumping es falso
            if (e.KeyCode == Keys.Space && !jumping)
            {
                jumping = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            //si el jugador dejo de presionar la tecla izquierda y esta dentro del panel
            //cambiamos el valor de goleft a false
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            // si el jugador dejo de presionar la tecla derecha 
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            //cuando las teclas se dejan de presionar verificamos si jumping es false
            //si es asi necesitamos regresarlo a false para poder saltar de nuevo
            if (jumping)
            {
                jumping = false;
            }

        }
    }
}
