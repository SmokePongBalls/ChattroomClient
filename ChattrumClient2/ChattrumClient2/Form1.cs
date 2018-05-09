using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WindowsInput;

namespace ChattrumClient2
{

    public partial class Form1 : Form
    {




        TcpClient client;
        NetworkStream stream;

        public Form1()
        {
            InitializeComponent();
            
            
        }
        //message = meddelande du skickar rmessage = meddelande du tar emot (recive)
        Message message = new Message();
        Message rmessage = new Message();
        Form2 frm2 = new Form2();
        bool error = false;
        
        
        
        
        


        private void button1_Click(object sender, EventArgs e)
        {
            

            //Applikationen försöker ansluta till en IP-adress och öppnar upp en data ström. 
            try
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Parse(txbIP.Text), 8080);
                client = new TcpClient();
                client.Connect(ip);
                stream = client.GetStream();
            }
            catch 
            {


                
                frm2.LabelText = "Ingen server hittades med den IP eller så är servern med den IP inte på slagen";
                frm2.ShowDialog();
                error = true;

            }


            if (error != true)
            {
                Credentials credentials = new Credentials();

                credentials.Username = txbAnvändarnamn.Text;
                credentials.Password = txbLösenord.Text;
                //Gör om meddelandet till en Json fil för att enklare kunna skicka iväg det.
                string credentialsAsJson = JsonConvert.SerializeObject(credentials);
                File.WriteAllText("json-filen.txt", credentialsAsJson);


                List<byte> bLista = new List<byte>();
                bLista.Add(Convert.ToByte('c'));

                int size = credentialsAsJson.Length;

                byte[] sizeAsByteArray = BitConverter.GetBytes(size);
                bLista.AddRange(sizeAsByteArray);

                byte[] credentialsAsByteArray = Encoding.UTF8.GetBytes(credentialsAsJson);
                bLista.AddRange(credentialsAsByteArray);
                try
                {
                    stream = client.GetStream();
                    stream.Write(bLista.ToArray(), 0, bLista.Count);
                }
                catch
                {
                    frm2.LabelText = "Inloggning misslyckas.";
                    frm2.ShowDialog();
                    frm2.Close();
                }
            }
            if (error != true)
            {
                timer1.Start();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void btnSkicka_Click(object sender, EventArgs e)
        {

            //Skapandet av meddelandet.
            Message message = new Message();

            message.Body = txbmeddelande.Text;
            message.From = txbAnvändarnamn.Text;
            message.To = txbSendTo.Text;

            if (txbmeddelande.Text.Contains("ä") || txbmeddelande.Text.Contains("ö") || txbmeddelande.Text.Contains("å"))
            {
               string färg = txbChattText.ForeColor.ToString();
                txbChattText.ForeColor = Color.Red;
                txbChattText.Text += "!ERROR!Du kan tyvärr inte skicka å, ä och ö ";
                txbChattText.ForeColor = Color.Black;
                
            }

            //Gör om meddelandet till en Json fil för att enklare kunna skicka iväg det och packa upp det.
            string messageAsJson = JsonConvert.SerializeObject(message);
            File.WriteAllText("json-filen.txt", messageAsJson);


            List<byte> bLista = new List<byte>();
            bLista.Add(Convert.ToByte('m'));

            int size = messageAsJson.Length;

            byte[] sizeAsByteArray = BitConverter.GetBytes(size);
            bLista.AddRange(sizeAsByteArray);

            byte[] messageAsByteArray = Encoding.UTF8.GetBytes(messageAsJson);
            bLista.AddRange(messageAsByteArray);

            NetworkStream stream = client.GetStream();
            stream.Write(bLista.ToArray(), 0, bLista.Count);



            //Ser till så att focus/markören alltid är länsgt ner alltså det nyaste i som har lagts till.
            txbChattText.ScrollToCaret();

            txbmeddelande.Clear();
        }

        

        private void timerCheckNewData_Tick(object sender, EventArgs e)
        {

            //Kollar om det finns en dataström till clienten(det här programmet)
            try
            {
                if (stream.DataAvailable)
                {
                   

                    stream.WriteByte(Convert.ToByte('u'));

                    char streamRead = Convert.ToChar(stream.ReadByte());
                    //Alla dessa if metoder läser av om det kommer en visst tecken från data strömmen


                    if (streamRead == 'l')
                    {
                        lblInloggad.Text = "Inloggad";
                        grbLogin.Enabled = false;
                        grbChatt.Enabled = true;
                        
                        loggaUtToolStripMenuItem.Enabled = true;
                        grbChattlista.Enabled = true;
                    }
                    if (streamRead == 'f')
                        lblInloggad.Text = "inte Inloggad";

                    if (streamRead == 'm')
                    {
                        byte[] sizeAsByteArray = new byte[4];
                        stream.Read(sizeAsByteArray, 0, 4);
                        int size = BitConverter.ToInt32(sizeAsByteArray, 0);

                        byte[] messageAsByteArray = new byte[size];

                        stream.Read(messageAsByteArray, 0, size);

                        string messageAsString;
                        messageAsString = Encoding.UTF8.GetString(messageAsByteArray);
                        rmessage = JsonConvert.DeserializeObject<Message>(messageAsString);


                        if (rmessage.To != "all")
                        {
                            txbChattText.ForeColor = Color.Purple;
                        }

                        else
                        {
                            txbChattText.ForeColor = Color.Black;
                        }

                        txbChattText.Text += rmessage.From + ": " + rmessage.Body + "\r\n";


                        //sätter scrollen och läsaren till botten av textboxen
                        txbChattText.SelectionStart = txbChattText.TextLength;
                        txbChattText.ScrollToCaret();

                    }

                    if (streamRead == 'u')
                    {
                        byte[] sizeAsByteArray = new byte[4];
                        stream.Read(sizeAsByteArray, 0, 4);
                        int size = BitConverter.ToInt32(sizeAsByteArray, 0);

                        byte[] readAsByteArray = new byte[size];

                        stream.Read(readAsByteArray, 0, size);

                        string readAsString;
                        readAsString = Encoding.UTF8.GetString(readAsByteArray);
                        List<string> användare = JsonConvert.DeserializeObject<List<string>>(readAsString);

                        //Visar alla användare och tack vare att det ligger i timercheckdata 
                        //uppdateras användarlistan
                        lsbAnvändare.Items.Clear();
                        for (int i = 0; i < användare.Count; i++)
                        {

                            lsbAnvändare.Items.Add(användare[i]);
                        }



                    }

                }
            }
            catch
            {
                frm2.LabelText = "Ingen server hittades med den IP eller så är servern med den IP inte på slagen";
                frm2.ShowDialog();
                frm2.Close();
            }
        }
        
        private void btnError_Click(object sender, EventArgs e)
        {
            //visar allt igen
            grbLogin.Visible = true;

            grbChattlista.Visible = true;
            grbChatt.Visible = true;

            txbIP.Visible = true;

            lblIP.Visible = true;
            
            
        }
       
        private void loggaUtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //skickar en byte till servern
            stream.WriteByte(Convert.ToByte('o'));

            grbChatt.Enabled = false;
            lsbAnvändare.Enabled = false;
            grbLogin.Enabled = true;

            timer1.Stop();
            grbChattlista.Enabled = false;
            txbAnvändarnamn.Clear();
            txbLösenord.Clear();
            lsbAnvändare.Items.Clear();
        }

        

        private void txbAnvändarnamn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                txbLösenord.Focus();
        }

        private void txbLösenord_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
                btnLoggaIn.PerformClick();
        }

        private void txbmeddelande_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
                btnSkicka.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
