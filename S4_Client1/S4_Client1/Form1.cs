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

namespace S4_Client1
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enviar_btn_Click(object sender, EventArgs e)
        {
            if (Longitud_rb.Checked)
            {
                string missatge = "1/" + Nom_tb.Text;
                //Enviem al servidor un nom de teclat
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
                server.Send(msg);

                //Rebem la resposta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("La longitud del teu nom és: " + missatge);
            }
            else if (Bonic_rb.Checked)
            {
                string missatge = "2/" + Nom_tb.Text;
                //Enviem al servidor un nom de teclat
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
                server.Send(msg);

                //Rebem la resposta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                if (missatge == "SI")
                    MessageBox.Show("El teu nom és bonic");
                else
                    MessageBox.Show("El teu nom és lleig");
            }
            else if (Altura_rb.Checked)
            {
                string missatge = "3/" + Nom_tb.Text + "/" + Altura_tb.Text;
                //Enviem al servidor un nom de teclat
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
                server.Send(msg);

                //Rebem la resposta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show(missatge);
            }
            else if (Palindrom_rb.Checked)
            {
                string missatge = "4/" + Nom_tb.Text;
                //Enviem al servidor un nom de teclat
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
                server.Send(msg);

                //Rebem la resposta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                if (missatge == "SI")
                    MessageBox.Show("El teu nom és palíndrom");
                else if (missatge == "NO")
                    MessageBox.Show("El teu nom no és palíndrom");
                else
                    MessageBox.Show("El teu nom és palíndrom però hi ha diferència entre majúscules i minúscules");
            }
            else
            {
                string missatge = "5/" + Nom_tb.Text;
                //Enviem al servidor un nom de teclat
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
                server.Send(msg);

                //Rebem la resposta del servidor
                byte[] msg2 = new byte[80];
                server.Receive(msg2);
                missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                MessageBox.Show("El nom en Majúscules és: " + missatge);
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
        }

        private void Desconnectar_btn_Click(object sender, EventArgs e)
        {
            //Envia el missatge de voler-se desconnectar
            string missatge = "0/";
            //Enviem al servidor un nom de teclat
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
            server.Send(msg);

            //Ens desconnectem
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void Consultes_btn_Click(object sender, EventArgs e)
        {
            string missatge = "6/";
            //Enviem al servidor un nom de teclat
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(missatge);
            server.Send(msg);

            //Rebem la resposta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            missatge = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            Consultes_lbl.Text = "Consultes: " + missatge;
        }
    }
}
