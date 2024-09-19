using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

namespace ProgettoRESPA2020
{
    public partial class Form1 : Form
    {
        /* --- Variabili per ADS client --- */
        // ADS Client

        private TcAdsClient tcClient;
        // Array for PLC variables
        private int[] hConnect;
        // ADS Stream , based on the specific region of a byte array 
        private AdsStream dataStream;
        private AdsBinaryReader binRead;
        // Numero di variabili di tipo boolean
        private int NUM_ELEMENTS_BOOL = 26;
        // Numero di variabili di tipo TIME
        private int NUM_ELEMENTS_TIME = 3;

        private int[] hvar_name;

        // Array of string elements for read / write data handle by variable names 
        private string[] dataPLC = {"MAIN.SensoreStart", "Main.SensoreReset", "MAIN.SensoreFCD0", "MAIN.SensoreFCD1P", "MAIN.SensoreFCDPP",
            "MAIN.SensoreFCD2P", "MAIN.SensoreFCD3P", "MAIN.SensoreFCDCP", "MAIN.SensoreFCD1V", "MAIN.SensoreFCDPV", "MAIN.SensoreFCD2V",
            "MAIN.SensoreFCD3V", "MAIN.SensoreFCDCV", "MAIN.Random", "MAIN.PP", "MAIN.PV", "MAIN.ComandoDX", "MAIN.ComandoDX2P",
            "MAIN.ComandoDX2V", "MAIN.ComandoDX3P", "MAIN.ComandoDX3V", "MAIN.ComandoPressaP", "MAIN.ComandoPressaV",
            "MAIN.ComandoCamionP", "MAIN.ComandoCamionV", "MAIN.ComandoAlarm", "MAIN.TimeWatchDog" , "MAIN.TimeAct", "MAIN.TimeAct2" };

        int random = -1;
        int durata = 4000;            // durata totale
        int delta;   //

        int contP = 0;  //conteggio presse
        int contV = 0;

        /********/
        int initPlastica = 0;      //posizione iniziale
        int spostamentoP = 140;   //posizione finale - posizione iniziale
        int xposP = 0;             // come varia lo spostamento

        int initVetro = 0;      //posizione iniziale
        int spostamentoV = 140;   //spostamento bottiglia di Vetro fino a RVM
        int xposV = 0;             // come varia lo spostamento

        /********/
        int initPlastica2 = 257;   //357 - 100
        int spostamentoP2 = 500 - 357;  //245
        int xposP2 = 0;  //spostamento

        int initVetro2 = 257;
        int spostamentoV2 = 500 - 357;
        int xposV2 = 0;

        /********/
        int initPressaP = 0; //posizione iniziale
        int spostamentoPressaP = 66 - 0;
        int yposP = 0;

        int initPressaV = 119;
        int spostamentoPressaV = 66;
        int yposV = 0;

        /********/
        int initPlasticaBox = 480;
        int spostamentoPBox = 150;  
        int xposPBox = 0;  //spostamento

        int initVetroBox = 480;
        int spostamentoVBox = 150;
        int xposVBox = 0;

        /********/
        int initCamionP = 663;
        int xposCP = 0;
        int spostamentoCamionP = 90;

        int initCamionV = 663;
        int xposCV = 0;
        int spostamentoCamionV = 90;

        /*********************** INIZIO ************************/

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /* START */
        private void start_button_Click(object sender, EventArgs e)
        {
            Start_Textbox.Text = "True";
            Reset_Textbox.Text = "False";

            //comandoDX_textbox.Text = "True";
            //FCD0_Picture.BackColor = System.Drawing.Color.Lime;
            FCD0_textBox.Text = "True";
            FCDPP_textBox.Text = "False";
            FCDPV_textBox.Text = "False";
            PP_textBox.Text = "False";
            PV_textBox.Text = "False";
            FCDCV_textBox.Text = "False";
            FCDCP_textBox.Text = "False";
            allarme.Visible = false;

            MasterTimer.Enabled = true;

            // funzione Random tra due valori 0,1
            Random estrattore = new Random();
            random = estrattore.Next(2);
            Console.WriteLine("num: " + random);

            if (random == 1)
            {
                Random_textBox.Text = ("True");
                Vetro1.Visible = true;
            }

            if (random == 0)
            {
                Random_textBox.Text = ("False");
                Plastica1.Visible = true;
            }

        }

        /* RESET*/
        private void Reset_Text(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (Reset_Textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[1], true);
                else
                    tcClient.WriteAny(hvar_name[1], false);
            }

            if (Reset_Textbox.Text.Equals("True")){
                reset_Button_Click( sender,  e);
            }

        }

        private void reset_Button_Click(object sender, EventArgs e)
        {
            Reset_Textbox.Text = "True";

            TimerDelay.Enabled = false;
            MasterTimer.Enabled = false;
            MasterTimer.Stop();


            Start_Textbox.Text = "False";
            //azzero attuatori
            comandoDX_textbox.Text = "False";
            comandoDX2P_textbox.Text = "False";
            comandoDX2V_textbox.Text = "False";
            comandoDX3P_textbox.Text = "False";
            comandoDX3V_textbox.Text = "False";
            comandoAlarm_textbox.Text = "False";
            pressaP_textBox.Text = "False";
            pressaV_textBox.Text = "False";
            camionP_textBox.Text = "False";
            camionV_textBox.Text = "False";
            PP_textBox.Text = "False";
            PV_textBox.Text = "False";

            //azzero quadratini
            FCD0_Picture.BackColor = System.Drawing.Color.Red;
            FCD1P_Picture.BackColor = System.Drawing.Color.Red;
            FCD2P_Picture.BackColor = System.Drawing.Color.Red;
            FCD3P_Picture.BackColor = System.Drawing.Color.Red;
            FCD1V_Picture.BackColor = System.Drawing.Color.Red;
            FCD2V_Picture.BackColor = System.Drawing.Color.Red;
            FCD3V_picture.BackColor = System.Drawing.Color.Red;
            picturePressaP.BackColor = System.Drawing.Color.Red;
            picturePressaV.BackColor = System.Drawing.Color.Red;
            FCDCP_Picture.BackColor = System.Drawing.Color.Red;
            FCDCV_picture.BackColor = System.Drawing.Color.Red;

            pictureBoxP.BackColor = System.Drawing.Color.Gray;
            pictureBoxV.BackColor = System.Drawing.Color.Gray;

            //azzero sensori
            FCD0_textBox.Text = "False";
            FCD1P_Textbox.Text = "False";
            FCD2P_textBox.Text = "False";
            FCD3P_textBox.Text = "False";
            FCD1V_textBox.Text = "False";
            FCD2V_textBox.Text = "False";
            FCD3V_textBox.Text = "False";
            FCDPP_textBox.Text = "False";
            FCDPV_textBox.Text = "False";
            FCDCP_textBox.Text = "False";
            FCDCV_textBox.Text = "False";
            PP_textBox.Text = "False";
            PV_textBox.Text = "False";

            allarme.Visible = false;


            //azzero conteggi pressa
            contP = 0;
            contV = 0;

            contPNum_textBox.Text = "0";
            contVNum_textBox.Text = "0";

            //azzero posizioni

            Plastica1.Left = initPlastica;
            xposP = 0;
            Plastica1.Visible = false;

            Vetro1.Left = initVetro;
            xposV = 0;
            Vetro1.Visible = false;

            Plastica2.Left = initPlastica2;
            xposP2 = 0;
            Plastica2.Visible = false;

            Vetro2.Left = initVetro2;
            xposV2 = 0;
            Vetro2.Visible = false;

            plastic_box.Left = initPlasticaBox;
            xposPBox = 0;
            plastic_box.Visible = false;

            vetro_box.Left = initVetroBox;
            xposVBox = 0;
            vetro_box.Visible = false;

            Camion_Plastica.Left = initCamionP;
            xposCP = 0;
            Camion_Plastica.Visible = false;

            Camion_Vetro.Left = initCamionV;
            xposCV = 0;
            Camion_Vetro.Visible = false;

            pressaP.Top = initPressaP;
            yposP = 0;
            boxP2.Visible = false;  //plastica dentro al box
            boxP1.Visible = false; //seconda plastica dentro al box

            pressaV.Top = initPressaV;
            yposV = 0;
            boxV2.Visible = false; //vetro dentro al box
            boxV1.Visible = false; // secondo vetro dentro al box

            alarm.Visible = false;
            allarme.Visible = false;

        }

        /* ANOTHER ONE*/
        private void another_button_Click(object sender, EventArgs e)
        {
            start_button_Click(sender, e);
        }

        /* PAUSA/CONTINUA*/
        private void pause_button_Click(object sender, EventArgs e)
        {
            MasterTimer.Enabled = !MasterTimer.Enabled;
        }


        private void TimerDelay_Tick(object sender, EventArgs e)
        {
            Start_Textbox.Text = "False";
        }

        /* ALARM */

        private void Alarm_button_Click(object sender, EventArgs e)
        {
            reset_Button_Click(sender, e);
        }

        private void alarm1_Click(object sender, EventArgs e)
        {
            if (Plastica1.Visible.Equals(true) && Vetro1.Visible.Equals(true))
            {
                alarm.Visible = true;

                if (random == 0)
                {
                    Vetro1.Visible = false;
                    MessageBox.Show("you can insert one bottle at a time");
                    Vetro1.Left = 0;
                    xposV = 0;
                    alarm.Visible = false;

                }
                if (random == 1)
                {
                    Plastica1.Visible = false;
                    MessageBox.Show("you can insert one bottle at a time");
                    Plastica1.Left = 0;
                    xposP = 0;
                    alarm.Visible = false;
                }
            }
        }


        /***************************************************************************************************************/
        private void MasterTimer_Tick(object sender, EventArgs e)
        {
            delta = MasterTimer.Interval;  //100

            //---------Controllo se ci sono due bottiglie nella fase 1
            alarm1_Click(sender, e);

            // esce bottiglia Plastica

            //------primo intervallo Plastica
            if (Random_textBox.Text.Equals("False") && comandoDX_textbox.Text.Equals("True"))
            {
                xposP = xposP + (int)(spostamentoP * delta / durata);    // 0 + 27900/5000 -> 5 

                FCD0_textBox.Text = "False";
                Start_Textbox.Text = "False";

                //controllo FCD
                if (xposP >= spostamentoP)
                {
                    xposP = spostamentoP;

                    pictureBoxP.BackColor = System.Drawing.Color.Azure;
                    Plastica1.Visible = false;
                    Plastica1.Left = initPlastica;
                    xposP = 0;
                    Plastica2.Visible = true;
                    

                    FCD1P_Textbox.Text = "True";
                    FCD1P_Textbox_TextChanged(sender, e);
                }
                // assegno il nuovo valore all'immagine della bottiglia
                Plastica1.Left = initPlastica + xposP;
            }


            //------------secondo intervallo Plastica
            if (comandoDX2P_textbox.Text.Equals("True"))
            {
                xposP2 = xposP2 + (int)((spostamentoP2 * delta) / durata);    // spostamento
                //FCD1P_Picture.BackColor = System.Drawing.Color.Red;
                FCD1P_Textbox.Text = "False";

                //controllo FCD
                if (xposP2 >= spostamentoP2)
                {
                    xposP2 = spostamentoP2;
                    contP++;
                    contPNum_textBox.Text = "" + contP;
                    pictureBoxP.BackColor = System.Drawing.Color.Gray;

                    if (contP == 1)
                    {
                        PP_textBox.Text = "True";
                        boxP2.Visible = true;
                        PP_textBox_TextChanged(sender, e);
                    }
                    if (contP == 2)
                    {
                        FCDPP_textBox.Text = "True";
                        FCDPP_textBox_TextChanged(sender, e);
                        boxP1.Visible = true;

                    }

                    Plastica2.Visible = false;
                    Plastica2.Left = initPlastica2;
                    xposP2 = 0;
                }
                // assegno il nuovo valore all'immagine della bottiglia
                Plastica2.Left = initPlastica2 + xposP2;
            }


            if (pressaP_textBox.Text.Equals("True"))
            {
                yposP = yposP + (int)(spostamentoPressaP * delta / 1100);
                FCDPP_textBox.Text = "False";

                //controllo FCD
                if (yposP >= spostamentoPressaP)
                {
                    yposP = spostamentoPressaP;
                    boxP2.Visible = false;
                    boxP1.Visible = false;
                    contP = 0;
                    contPNum_textBox.Text = "" + contP;

                    FCD2P_textBox.Text = "True";
                    FCD2_textBox_TextChanged(sender, e);

                    plastic_box.Visible = true;
                    pressaP.Top = initPressaP;
                    yposP = 0;
                }
                // assegno il nuovo valore all'immagine della bottiglia
                pressaP.Top = initPressaP + yposP;
            }

            //----------------terzo intervallo ------------------
            if (comandoDX3P_textbox.Text.Equals("True"))
            {
                xposPBox = xposPBox + (int)(spostamentoPBox * delta / durata);    // spostamento
                //FCD2P_Picture.BackColor = System.Drawing.Color.Red;
                FCD2P_textBox.Text = "False";

                //controllo FCD
                if (xposPBox >= spostamentoPBox)
                {
                    xposPBox = spostamentoPBox;

                    FCD3P_textBox.Text = "True";
                    FCD3P_textBox_TextChanged(sender, e);

                    plastic_box.Visible = false;
                    plastic_box.Left = initPlasticaBox;
                    xposPBox = 0;
                    Camion_Plastica.Visible = true;

                }
                // assegno il nuovo valore all'immagine della bottiglia
                plastic_box.Left = initPlasticaBox + xposPBox;
            }

            // *********** camion ***************
            if (camionP_textBox.Text.Equals("True"))
            {
                xposCP = xposCP + (int)(spostamentoCamionP * delta / 1300);
                FCD3P_textBox.Text = "False";
                //FCD3P_Picture.BackColor = System.Drawing.Color.Red;

                //controllo FCD
                if (xposCP >= spostamentoCamionP)
                {
                    FCDCP_textBox.Text = "True";
                    FCDCP_textBox_TextChanged(sender, e);

                    Camion_Plastica.Visible = false;
                    Camion_Plastica.Left = initCamionP;
                    xposCP = 0;

                }

                // assegno il nuovo valore all'immagine della bottiglia
                Camion_Plastica.Left = initCamionP + xposCP;
            }


            /**********************************************/

            // esce bottiglia vetro

            //------primo intervallo vetro
            if (Random_textBox.Text.Equals("True") && comandoDX_textbox.Text.Equals("True"))
            {
                xposV = xposV + (int)(spostamentoV * delta / durata);    // 0 + 27900/5000 -> 5 

                FCD0_textBox.Text = "False";
                Start_Textbox.Text = "False";

                //controllo FCD
                if (xposV >= spostamentoV)
                {
                    xposV = spostamentoV;
                    
                    pictureBoxV.BackColor = System.Drawing.Color.DarkOliveGreen;

                    Vetro1.Visible = false;                   
                    Vetro1.Left = initVetro;
                    xposV = 0;

                    Vetro2.Visible = true;
                    FCD1V_textBox.Text = "True";
                    FCD1V_Textbox_TextChanged(sender, e);

                }
                // assegno il nuovo valore all'immagine della bottiglia
                Vetro1.Left = initVetro + xposV;
            }

            // secondo intervallo vetro

            if (comandoDX2V_textbox.Text.Equals("True"))
            {
                xposV2 = xposV2 + (int)((spostamentoV2 * delta) / durata);    // spostamento
               //FCD1V_Picture.BackColor = System.Drawing.Color.Red;
                FCD1V_textBox.Text = "False";

                //controllo FCD
                if (xposV2 >= spostamentoV2)
                {
                    xposV2 = spostamentoV2;
                    contV++;
                    contVNum_textBox.Text = "" + contV;
                    pictureBoxV.BackColor = System.Drawing.Color.Gray;

                    if (contV == 1)
                    {
                        PV_textBox.Text = "True";
                        boxV2.Visible = true;
                        PV_textBox_TextChanged(sender, e);

                    }
                    if (contV == 2)
                    {
                        FCDPV_textBox.Text = "True";
                        FCDPV_textBox_TextChanged(sender, e);
                        boxV1.Visible = true;

                    }

                    Vetro2.Visible = false;
                    Vetro2.Left = initVetro2;
                    xposV2 = 0;
 
                }
                // assegno il nuovo valore all'immagine della bottiglia
                Vetro2.Left = initVetro2 + xposV2;
            }

            if (pressaV_textBox.Text.Equals("True"))
            {
                yposV = yposV + (int)(spostamentoPressaV * delta / 1300);
                FCDPV_textBox.Text = "False";

                //controllo FCD
                if (yposV >= spostamentoPressaV)
                {
                    yposV = spostamentoPressaV;
                    boxV2.Visible = false;
                    boxV1.Visible = false;
                    contV = 0;
                    contVNum_textBox.Text = "" + contV;

                    FCD2V_textBox.Text = "True";
                    FCD2V_textBox_TextChanged(sender, e);

                    vetro_box.Visible = true;
                    pressaV.Top = initPressaV;
                    yposV = 0;

                }
                // assegno il nuovo valore all'immagine della bottiglia
                pressaV.Top = initPressaV + yposV;
            }

            //----------------terzo intervallo vetro ------------------
            if (comandoDX3V_textbox.Text.Equals("True"))
            {
                xposVBox = xposVBox + (int)(spostamentoVBox * delta / durata);    // spostamento
                FCD2V_textBox.Text = "False";
                //FCD2V_Picture.BackColor = System.Drawing.Color.Red;

                //controllo FCD
                if (xposVBox >= spostamentoVBox)
                {
                    xposVBox = spostamentoVBox;
                    //camionV_textBox.Text = "True";

                    FCD3V_textBox.Text = "True";
                    FCD3V_textBox_TextChanged(sender, e);

                    vetro_box.Visible = false;
                    vetro_box.Left = initVetroBox;
                    xposVBox = 0;
                    Camion_Vetro.Visible = true;

                }
                // assegno il nuovo valore all'immagine della bottiglia
                vetro_box.Left = initVetroBox + xposVBox;

            }

            // *********** camion ***************
            if (camionV_textBox.Text.Equals("True"))
            {
                xposCV = xposCV + (int)(spostamentoCamionV * delta / 1100);
                //FCD3V_picture.BackColor = System.Drawing.Color.Red;
                FCD3V_textBox.Text = "False";

                //controllo FCD
                if (xposCV >= spostamentoCamionV)
                {
                    FCDCV_textBox.Text = "True";
                    FCDCV_textBox_TextChanged(sender, e);

                    Camion_Vetro.Visible = false;
                    Camion_Plastica.Left = initCamionP;
                    xposCV = 0;

                }

                // assegno il nuovo valore all'immagine della bottiglia
                Camion_Vetro.Left = initCamionV + xposCV;
            }
        }

        /********************    FCD     ******************/

        /* FCDP 1 - plastica */
        private void FCD1P_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCD1P_Textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[3], true);
                else
                    tcClient.WriteAny(hvar_name[3], false);
            }


            if (FCD1P_Textbox.Text.Equals("True"))
            {
                //comandoDX_textbox.Text = "False";
                //comandoDX2P_textbox.Text = "True";
                FCD1P_Picture.BackColor = System.Drawing.Color.Lime;
            }
            else FCD1P_Picture.BackColor = System.Drawing.Color.Red;
        }

        /* FCD  pressaPlastica */

        private void FCDPP_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCDPP_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[4], true);
                else
                    tcClient.WriteAny(hvar_name[4], false);
            }

            if (FCDPP_textBox.Text.Equals("True"))
            {
                //comandoDX2P_textbox.Text = "False";
                picturePressaP.BackColor = System.Drawing.Color.Lime;
            }
            else picturePressaP.BackColor = System.Drawing.Color.Red;
        }

        private void ComandoPressaPlastica(object sender, EventArgs e)
        {

        }


        /* FCDP 2 - uscita cubo */
        private void FCD2_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCD2P_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[5], true);
                else
                    tcClient.WriteAny(hvar_name[5], false);
            }


            if (FCD2P_textBox.Text.Equals("True"))
            {
                //pressaP_textBox.Text = "False";
                //comandoDX3P_textbox.Text = "True";

                FCD2P_Picture.BackColor = System.Drawing.Color.Lime;
            }
            else FCD2P_Picture.BackColor = System.Drawing.Color.Red;

        }

        /* FCDP  3 - partenza */
        private void FCD3P_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCD3P_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[6], true);
                else
                    tcClient.WriteAny(hvar_name[6], false);
            }


            if (FCD3P_textBox.Text.Equals("True"))
            {
                //comandoDX3P_textbox.Text = "False";
                //camionP_textBox.Text = "True";
                FCD3P_Picture.BackColor = System.Drawing.Color.Lime;
            }
            else FCD3P_Picture.BackColor = System.Drawing.Color.Red;
        }

        /* FCDV FASE 1  vetro */
 
        private void FCD1V_Textbox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCD1V_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[8], true);
                else
                    tcClient.WriteAny(hvar_name[8], false);
            }


            if (FCD1V_textBox.Text.Equals("True"))
            {
                FCD1V_Picture.BackColor = System.Drawing.Color.Lime;
                //comandoDX_textbox.Text = "False";
                //comandoDX2V_textbox.Text = "True";
            }
            else FCD1V_Picture.BackColor = System.Drawing.Color.Red;
        }

        /* FCD  pressaVetro */

        private void FCDPV_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCDPV_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[9], true);
                else
                    tcClient.WriteAny(hvar_name[9], false);
            }

            if (FCDPV_textBox.Text.Equals("True"))
            {
                picturePressaV.BackColor = System.Drawing.Color.Lime;

            }
            else picturePressaV.BackColor = System.Drawing.Color.Red;
        }

        /* FCDP 2 - uscita cubo */
        private void FCD2V_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCD2V_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[10], true);
                else
                    tcClient.WriteAny(hvar_name[10], false);
            }


            if (FCD2V_textBox.Text.Equals("True"))
            {
                FCD2V_Picture.BackColor = System.Drawing.Color.Lime;
            }
            else FCD2V_Picture.BackColor = System.Drawing.Color.Red;

        }

        /* FCDP  3 - partenza */
        private void FCD3V_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCD3V_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[11], true);
                else
                    tcClient.WriteAny(hvar_name[11], false);
            }


            if (FCD3V_textBox.Text.Equals("True"))
            {
                FCD3V_picture.BackColor = System.Drawing.Color.Lime;
            }
            else FCD3V_picture.BackColor = System.Drawing.Color.Red;
        }






        // Function for read the ADS variables and display within textBox
        private void OnNotification(object sender, AdsNotificationEventArgs e)
        {
            DateTime time = DateTime.FromFileTime(e.TimeStamp);
            e.DataStream.Position = e.Offset;
            string strValue = "";

            if (e.NotificationHandle == hConnect[0])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[1])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[2])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[3])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[4])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[5])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[6])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[7])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[8])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[9])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[10])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[11])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[12])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[13])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[14])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[15])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[16])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[17])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[18])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[19])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[20])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[21])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[22])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[23])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[24])
                strValue = binRead.ReadBoolean().ToString();
            else if (e.NotificationHandle == hConnect[25])
                strValue = binRead.ReadBoolean().ToString();

            else if (e.NotificationHandle == hConnect[26])
                strValue = binRead.ReadInt32().ToString();
            else if (e.NotificationHandle == hConnect[27])
                strValue = binRead.ReadInt32().ToString();
            else if (e.NotificationHandle == hConnect[28])
                strValue = binRead.ReadInt32().ToString();

            var typeObj = e.UserData.GetType();
            var BoxObject = ((TextBox)e.UserData);
            ((TextBox)e.UserData).Invoke(new Action(() => ((TextBox)e.UserData).Text = String.Format(strValue)));
            if (Start_Textbox.Text.Equals(" True "))
            {
                this.MasterTimer.Enabled = true;
                this.MasterTimer.Start();
            }
        }

        private void ProcessoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                tcClient.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void TextTimerAct_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (TextTimerAct.Text.Equals("0"))
                    tcClient.WriteAny(hvar_name[27], 0);
            }
        }

        private void TextTimerWD_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (TextTimerWD.Text.Equals("10000"))
                    tcClient.WriteAny(hvar_name[26], 10000);
            }
        }

       

        private void comandoDX2P_textbox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (comandoDX2P_textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[17], true);
                else
                    tcClient.WriteAny(hvar_name[17], false);
            }
        }

        private void comandoDX2V_textbox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (comandoDX2V_textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[18], true);
                else
                    tcClient.WriteAny(hvar_name[18], false);
            }
        }

        private void comandoDX3_textbox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (comandoDX3P_textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[19], true);
                else
                    tcClient.WriteAny(hvar_name[19], false);
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // Generate Instance of TcAdsClient class
            tcClient = new TcAdsClient();
            // Connection to target PLC on Localhost on port 851
            tcClient.Connect("127.0.0.1.1.1", 851);
            // Stream for ADS communication for reading
            dataStream = new AdsStream(NUM_ELEMENTS_BOOL + NUM_ELEMENTS_TIME * 4 ); //  is the amount of bytes to read / write
            // ASCII Encoding setting , to read string format
            binRead = new AdsBinaryReader(dataStream);
            // Create a stream of 8 data elements by
            // variable name and type
            hConnect = new int[NUM_ELEMENTS_BOOL + NUM_ELEMENTS_TIME];
            try
            {
                // AddDeviceNotification ( stringVariableName , AdsStreamdataStream , intoffset , intlength , AdsTransModetransMode , intcycleTime , intmaxDelay , objectuserData )
                // Consente di scrivere nelle opportune caselle di testo i valori che vengono letti dal PLC
                hConnect[0] = tcClient.AddDeviceNotification(
                dataPLC[0], dataStream, 0, 1, AdsTransMode.OnChange, 100, 0, Start_Textbox);
                hConnect[1] = tcClient.AddDeviceNotification(
                dataPLC[1], dataStream, 1, 1, AdsTransMode.OnChange, 100, 0, Reset_Textbox);
                hConnect[2] = tcClient.AddDeviceNotification(
                dataPLC[2], dataStream, 2, 1, AdsTransMode.OnChange, 100, 0, FCD0_textBox);

                hConnect[3] = tcClient.AddDeviceNotification(
                dataPLC[3], dataStream, 3, 1, AdsTransMode.OnChange, 100, 0, FCD1P_Textbox);
                hConnect[4] = tcClient.AddDeviceNotification(
                dataPLC[4], dataStream, 4, 1, AdsTransMode.OnChange, 100, 0, FCDPP_textBox);
                hConnect[5] = tcClient.AddDeviceNotification(
                dataPLC[5], dataStream, 5, 1, AdsTransMode.OnChange, 100, 0, FCD2P_textBox);
                hConnect[6] = tcClient.AddDeviceNotification(
                dataPLC[6], dataStream, 6, 1, AdsTransMode.OnChange, 100, 0, FCD3P_textBox);
                hConnect[7] = tcClient.AddDeviceNotification(
                dataPLC[7], dataStream, 7, 1, AdsTransMode.OnChange, 100, 0, FCDCP_textBox);

                hConnect[8] = tcClient.AddDeviceNotification(
                dataPLC[8], dataStream, 8, 1, AdsTransMode.OnChange, 100, 0, FCD1V_textBox);
                hConnect[9] = tcClient.AddDeviceNotification(
                dataPLC[9], dataStream, 9, 1, AdsTransMode.OnChange, 100, 0, FCDPV_textBox);
                hConnect[10] = tcClient.AddDeviceNotification(
                dataPLC[10], dataStream, 10, 1, AdsTransMode.OnChange, 100, 0, FCD2V_textBox);
                hConnect[11] = tcClient.AddDeviceNotification(
                dataPLC[11], dataStream, 11, 1, AdsTransMode.OnChange, 100, 0, FCD3V_textBox);
                hConnect[12] = tcClient.AddDeviceNotification(
                dataPLC[12], dataStream, 12, 1, AdsTransMode.OnChange, 100, 0, FCDCV_textBox);

                hConnect[13] = tcClient.AddDeviceNotification(
                dataPLC[13], dataStream, 13, 1, AdsTransMode.OnChange, 100, 0, Random_textBox);
                hConnect[14] = tcClient.AddDeviceNotification(
                dataPLC[14], dataStream, 14, 1, AdsTransMode.OnChange, 100, 0, PP_textBox);
                hConnect[15] = tcClient.AddDeviceNotification(
                dataPLC[15], dataStream, 15, 1, AdsTransMode.OnChange, 100, 0, PV_textBox);

                hConnect[16] = tcClient.AddDeviceNotification(
                dataPLC[16], dataStream, 16, 1, AdsTransMode.OnChange, 100, 0, comandoDX_textbox);
                hConnect[17] = tcClient.AddDeviceNotification(
                dataPLC[17], dataStream, 17, 1, AdsTransMode.OnChange, 100, 0, comandoDX2P_textbox);
                hConnect[18] = tcClient.AddDeviceNotification(
                dataPLC[18], dataStream, 18, 1, AdsTransMode.OnChange, 100, 0, comandoDX2V_textbox);
                hConnect[19] = tcClient.AddDeviceNotification(
                dataPLC[19], dataStream, 19, 1, AdsTransMode.OnChange, 100, 0, comandoDX3P_textbox);
                hConnect[20] = tcClient.AddDeviceNotification(
                dataPLC[20], dataStream, 20, 1, AdsTransMode.OnChange, 100, 0, comandoDX3V_textbox);
                hConnect[21] = tcClient.AddDeviceNotification(
                dataPLC[21], dataStream, 21, 1, AdsTransMode.OnChange, 100, 0, pressaP_textBox);
                hConnect[22] = tcClient.AddDeviceNotification(
                dataPLC[22], dataStream, 22, 1, AdsTransMode.OnChange, 100, 0, pressaV_textBox);
                hConnect[23] = tcClient.AddDeviceNotification(
                dataPLC[23], dataStream, 23, 1, AdsTransMode.OnChange, 100, 0, camionP_textBox);
                hConnect[24] = tcClient.AddDeviceNotification(
                dataPLC[24], dataStream, 24, 1, AdsTransMode.OnChange, 100, 0, camionV_textBox);
                hConnect[25] = tcClient.AddDeviceNotification(
                dataPLC[25], dataStream, 25, 1, AdsTransMode.OnChange, 100, 0, comandoAlarm_textbox);

                hConnect[26] = tcClient.AddDeviceNotification(
                dataPLC[26], dataStream, 26, 4, AdsTransMode.OnChange, 100, 0, TextTimerWD);
                hConnect[27] = tcClient.AddDeviceNotification(
                dataPLC[27], dataStream, 30, 4, AdsTransMode.OnChange, 100, 0, TextTimerAct);
                hConnect[28] = tcClient.AddDeviceNotification(
                dataPLC[28], dataStream, 34, 4, AdsTransMode.OnChange, 100, 0, TextTimerAct2);

                tcClient.AdsNotification += new AdsNotificationEventHandler(OnNotification);
                textConnection.Text = " Connection   Established !!! ";
            }
            catch (Exception err)
            {
                textConnection.Text = err.Message.ToString();
            }
            // Generate handles for writing by name
            hvar_name = new int[NUM_ELEMENTS_BOOL + NUM_ELEMENTS_TIME];
            for (int i = 0; i < NUM_ELEMENTS_BOOL + NUM_ELEMENTS_TIME; i++)
            {
                hvar_name[i] = tcClient.CreateVariableHandle(dataPLC[i]);
            }
        }



        /* ALTRI OGGETTI*/


        private void textConnection_TextChanged(object sender, EventArgs e)
        {

        }

        private void Random_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (Random_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[13], true);
                else
                    tcClient.WriteAny(hvar_name[13], false);
            }
        }

        private void picturePressaP_Click(object sender, EventArgs e)
        {

        }

        private void allarme_Click(object sender, EventArgs e)
        {

        }


        private void comando_alarm_Click(object sender, EventArgs e)
        {

        }


        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Vetro_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Start_Text(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (Start_Textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[0], true);
                else
                    tcClient.WriteAny(hvar_name[0], false);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void ReverseMachine_Click(object sender, EventArgs e)
        {

        }

        private void Start_label_Click(object sender, EventArgs e)
        {

        }



        private void animation_box_Enter(object sender, EventArgs e)
        {

        }

        private void FCD2_Picture_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void attuatori_box_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sensori_Click(object sender, EventArgs e)
        {

        }

        private void attuatori_Click(object sender, EventArgs e)
        {

        }

        private void Reset_label_Click(object sender, EventArgs e)
        {

        }

        private void FCD1_label_Click(object sender, EventArgs e)
        {

        }

        private void comandoDX_textbox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (comandoDX_textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[16], true);
                else
                    tcClient.WriteAny(hvar_name[16], false);
            }
        }

        private void comando_DX_Click(object sender, EventArgs e)
        {

        }

        private void plastic_box_Click(object sender, EventArgs e)
        {

        }

        private void vetro_box_Click(object sender, EventArgs e)
        {

        }

        private void FCD3_picture_Click(object sender, EventArgs e)
        {

        }


        private void FCD1P_Picture_Click(object sender, EventArgs e)
        {

        }

        private void FCD2P_Picture_Click(object sender, EventArgs e)
        {

        }

        private void FCD3P_Picture_Click(object sender, EventArgs e)
        {

        }
        private void FCD1V_Picture_Click(object sender, EventArgs e)
        {

        }

        private void pressaP_Click(object sender, EventArgs e)
        {

        }

        
        private void BoxV_Click(object sender, EventArgs e)
        {

        }

        private void pressaV_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Plastica2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }


        private void pressaP_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (pressaP_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[21], true);
                else
                    tcClient.WriteAny(hvar_name[21], false);
            }
        }

        private void comandoDX3V_textbox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (comandoDX3V_textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[20], true);
                else
                    tcClient.WriteAny(hvar_name[20], false);
            }
        }

        private void FCDCP_textBox_TextChanged(object sender, EventArgs e)
        {

            if (hvar_name != null)
            {
                if (FCDCP_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[7], true);
                else
                    tcClient.WriteAny(hvar_name[7], false);
            }

            if (FCDCP_textBox.Text.Equals("True"))
            {
                //camionP_textBox.Text = "False";
                //timerCamion.Enabled = true;
                FCDCP_Picture.BackColor = System.Drawing.Color.Lime;
            }
            else FCDCP_Picture.BackColor = System.Drawing.Color.Red;
        }

        private void FCDCV_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCDCV_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[12], true);
                else
                    tcClient.WriteAny(hvar_name[12], false);
            }
            if (FCDCV_textBox.Text.Equals("True"))
            {
                FCDCV_picture.BackColor = System.Drawing.Color.Lime;
            }
            else FCDCV_picture.BackColor = System.Drawing.Color.Red;
        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void PP_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (PP_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[14], true);
                else
                    tcClient.WriteAny(hvar_name[14], false);
            }

            if (PP_textBox.Text.Equals("True"))
            {
                //pressaP_textBox.Text = "True";
                picturePressaP.BackColor = System.Drawing.Color.Orange;

            }
            else picturePressaP.BackColor = System.Drawing.Color.Red;
        }

        private void PV_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (PV_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[15], true);
                else
                    tcClient.WriteAny(hvar_name[15], false);
            }

            if (PV_textBox.Text.Equals("True"))
            {
                picturePressaV.BackColor = System.Drawing.Color.Orange;
                //pressaV_textBox.Text = "True";
                //FCDPV_textBox.Text = "False";
            }
            else picturePressaV.BackColor = System.Drawing.Color.Red;
        }

        private void FCD0_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (FCD0_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[2], true);
                else
                    tcClient.WriteAny(hvar_name[2], false);
            }

            if (FCD0_textBox.Text.Equals("True"))
            {
                FCD0_Picture.BackColor = System.Drawing.Color.Lime;
            }
            else
            {
                FCD0_Picture.BackColor = System.Drawing.Color.Red;
            }
        }

        private void pressaV_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (pressaV_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[22], true);
                else
                    tcClient.WriteAny(hvar_name[22], false);
            }
        }

        private void camionP_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (camionP_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[23], true);
                else
                    tcClient.WriteAny(hvar_name[23], false);
            }
        }

        private void camionV_textBox_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (camionV_textBox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[24], true);
                else
                    tcClient.WriteAny(hvar_name[24], false);
            }
        }

        private void comandoAlarm_textbox_TextChanged_1(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (comandoAlarm_textbox.Text.Equals("True"))
                    tcClient.WriteAny(hvar_name[25], true);
                else
                    tcClient.WriteAny(hvar_name[25], false);
            }

            if (comandoAlarm_textbox.Text.Equals("True"))
            {
                allarme.Visible = true;
            }
        }

        private void FCDCP_Picture_Click(object sender, EventArgs e)
        {

        }

        private void TextTimerAct2_TextChanged(object sender, EventArgs e)
        {
            if (hvar_name != null)
            {
                if (TextTimerAct2.Text.Equals("0"))
                    tcClient.WriteAny(hvar_name[28], 0);
            }
        }

        private void FCD1V_label_Click(object sender, EventArgs e)
        {

        }
    }
}
