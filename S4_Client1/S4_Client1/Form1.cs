using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace S4_Client1
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atendre;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //Inhabilita el bloqueig de modificacions d'objectes d'altres threads
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enviar_btn_Click(object sender, EventArgs e)
        {
            string missatge = "missatge";
            bool opcio_viable = true;

            if (Longitud_rb.Checked)
                missatge = "1/" + Nom_tb.Text;
            else if (Bonic_rb.Checked)
                missatge = "2/" + Nom_tb.Text;
            else if (Altura_rb.Checked)
                missatge = "3/" + Nom_tb.Text + "/" + Altura_tb.Text;
            else if (Palindrom_rb.Checked)
                missatge = "4/" + Nom_tb.Text;
            else if (MAjuscules_rb.Checked)
                missatge = "5/" + Nom_tb.Text;
            else
            {
                opcio_viable = false;
                MessageBox.Show("No has triat ninguna opció");
            }


            //Enviem al servidor un nom de teclat
            if (opcio_viable)
            {
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
                server.Send(msg);
            }
        }

        private void Connectar_btn_Click(object sender, EventArgs e)
        {
            //Creem un IPEndPoint amb la ip del servidor i el port
            IPAddress direc = IPAddress.Parse("192.168.56.101");
            IPEndPoint ipep = new IPEndPoint(direc, 9070);

            //Creem el socket
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep); //Intentem connectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Connectat");

                
            }
            catch (SocketException ex)
            {
                //Si hi ha l'excepció, imprimim l'error
                MessageBox.Show("No s'ha pogut connectar amb el servidor:" + ex);
                return;
            }

            //Creem el Thread
            ThreadStart ts = delegate { AtendreServidor(); };
            atendre = new Thread(ts);
            atendre.Start();
        }

        private void Desconnectar_btn_Click(object sender, EventArgs e)
        {
            //Envia el missatge de voler-se desconnectar
            string missatge = "0/";
            //Enviem al servidor un nom de teclat
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
            server.Send(msg);
            atendre.Abort();

            //Ens desconnectem
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void AtendreServidor()
        {
            while (true)
            {
                //Rebem la resposta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                string[] troços = Encoding.ASCII.GetString(msg2).Split('/');
                int codi = Convert.ToInt32(troços[0]);
                string missatge = troços[1].Split('\0')[0];

                switch(codi)
                {
                    case 1: //Resposta a la longitud del nom
                        MessageBox.Show("La longitud del teu nom és: " + missatge);
                    break;

                    case 2: //Resposta al nom bonic
                        if (missatge == "SI")
                            MessageBox.Show("El teu nom és bonic");
                        else
                            MessageBox.Show("El teu nom és lleig");
                    break;

                    case 3: //Resposta a l'altura
                        MessageBox.Show(missatge);
                    break;

                    case 4: //Resposta al nom palíndrom
                        if (missatge == "SI")
                            MessageBox.Show("El teu nom és palíndrom");
                        else if (missatge == "NO")
                            MessageBox.Show("El teu nom no és palíndrom");
                        else
                            MessageBox.Show("El teu nom és palíndrom però hi ha diferència entre majúscules i minúscules");
                    break;

                    case 5: //Resposta al nom en majúscules
                        MessageBox.Show("El nom en Majúscules és: " + missatge);
                    break;

                    case 6: //Resposta a la notificació de consultes
                        Consultes_lbl.Text = "Consultes: " + missatge;
                    break;
                }
               
            }
        }
    }
}
