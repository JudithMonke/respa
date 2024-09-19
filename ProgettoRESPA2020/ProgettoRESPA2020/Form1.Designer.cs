using System;
using System.Windows.Forms;

namespace ProgettoRESPA2020
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.variabili_box = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextTimerAct2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextTimerAct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TextTimerWD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.attuatori_box = new System.Windows.Forms.Panel();
            this.comandoAlarm_textbox = new System.Windows.Forms.TextBox();
            this.comando_alarm = new System.Windows.Forms.Label();
            this.pressaV_textBox = new System.Windows.Forms.TextBox();
            this.camionP_textBox = new System.Windows.Forms.TextBox();
            this.CamionP = new System.Windows.Forms.Label();
            this.camionV_textBox = new System.Windows.Forms.TextBox();
            this.CamionV = new System.Windows.Forms.Label();
            this.comandoDX3V_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comando_DX2V = new System.Windows.Forms.Label();
            this.comandoDX2V_textbox = new System.Windows.Forms.TextBox();
            this.comando_PressaV = new System.Windows.Forms.Label();
            this.pressaP_textBox = new System.Windows.Forms.TextBox();
            this.comando_PressaP = new System.Windows.Forms.Label();
            this.comandoDX3P_textbox = new System.Windows.Forms.TextBox();
            this.comando_DX3 = new System.Windows.Forms.Label();
            this.comandoDX2P_textbox = new System.Windows.Forms.TextBox();
            this.comando_DX2P = new System.Windows.Forms.Label();
            this.comandoDX_textbox = new System.Windows.Forms.TextBox();
            this.comando_DX = new System.Windows.Forms.Label();
            this.sensori_box = new System.Windows.Forms.Panel();
            this.FCDCV_textBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FCDCP_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FCD0_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.FCDPV_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FCDPP_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.FCD3V_textBox = new System.Windows.Forms.TextBox();
            this.FCD3V_label = new System.Windows.Forms.Label();
            this.FCD1V_textBox = new System.Windows.Forms.TextBox();
            this.FCD1V_label = new System.Windows.Forms.Label();
            this.FCD2V_textBox = new System.Windows.Forms.TextBox();
            this.FCD2_V = new System.Windows.Forms.Label();
            this.FCD3P_textBox = new System.Windows.Forms.TextBox();
            this.FCD3P_label = new System.Windows.Forms.Label();
            this.FCD2P_textBox = new System.Windows.Forms.TextBox();
            this.FCD2_P = new System.Windows.Forms.Label();
            this.FCD1P_Textbox = new System.Windows.Forms.TextBox();
            this.FCD1P_label = new System.Windows.Forms.Label();
            this.Reset_Textbox = new System.Windows.Forms.TextBox();
            this.Reset_label = new System.Windows.Forms.Label();
            this.Start_Textbox = new System.Windows.Forms.TextBox();
            this.Start_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sensori = new System.Windows.Forms.Label();
            this.animation_box = new System.Windows.Forms.GroupBox();
            this.PV_textBox = new System.Windows.Forms.TextBox();
            this.PP_textBox = new System.Windows.Forms.TextBox();
            this.FCDCV_picture = new System.Windows.Forms.PictureBox();
            this.FCDCP_Picture = new System.Windows.Forms.PictureBox();
            this.Camion_Plastica = new System.Windows.Forms.PictureBox();
            this.Camion_Vetro = new System.Windows.Forms.PictureBox();
            this.contPNum_textBox = new System.Windows.Forms.TextBox();
            this.contVNum_textBox = new System.Windows.Forms.TextBox();
            this.allarme = new System.Windows.Forms.PictureBox();
            this.Random_textBox = new System.Windows.Forms.TextBox();
            this.pressaV = new System.Windows.Forms.PictureBox();
            this.boxV2 = new System.Windows.Forms.PictureBox();
            this.boxV1 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pressaP = new System.Windows.Forms.PictureBox();
            this.boxP1 = new System.Windows.Forms.PictureBox();
            this.boxP2 = new System.Windows.Forms.PictureBox();
            this.FCD0_Picture = new System.Windows.Forms.PictureBox();
            this.picturePressaV = new System.Windows.Forms.PictureBox();
            this.picturePressaP = new System.Windows.Forms.PictureBox();
            this.pictureBoxV = new System.Windows.Forms.PictureBox();
            this.pictureBoxP = new System.Windows.Forms.PictureBox();
            this.FCD3P_Picture = new System.Windows.Forms.PictureBox();
            this.FCD2P_Picture = new System.Windows.Forms.PictureBox();
            this.FCD2V_Picture = new System.Windows.Forms.PictureBox();
            this.FCD1V_Picture = new System.Windows.Forms.PictureBox();
            this.FCD1P_Picture = new System.Windows.Forms.PictureBox();
            this.Vetro2 = new System.Windows.Forms.PictureBox();
            this.Plastica2 = new System.Windows.Forms.PictureBox();
            this.alarm = new System.Windows.Forms.PictureBox();
            this.vetro_box = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.BoxV = new System.Windows.Forms.PictureBox();
            this.FCD3V_picture = new System.Windows.Forms.PictureBox();
            this.plastic_box = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Vetro1 = new System.Windows.Forms.PictureBox();
            this.Plastica1 = new System.Windows.Forms.PictureBox();
            this.ReverseMachine = new System.Windows.Forms.PictureBox();
            this.BoxP = new System.Windows.Forms.PictureBox();
            this.start_button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.MasterTimer = new System.Windows.Forms.Timer(this.components);
            this.TimerDelay = new System.Windows.Forms.Timer(this.components);
            this.pause_button = new System.Windows.Forms.Button();
            this.Alarm_button = new System.Windows.Forms.Button();
            this.another_button = new System.Windows.Forms.Button();
            this.textConnection = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.variabili_box.SuspendLayout();
            this.panel1.SuspendLayout();
            this.attuatori_box.SuspendLayout();
            this.sensori_box.SuspendLayout();
            this.animation_box.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCDCV_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCDCP_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camion_Plastica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camion_Vetro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allarme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD0_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePressaV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePressaP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD3P_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD2P_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD2V_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD1V_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD1P_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vetro2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plastica2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetro_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD3V_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plastic_box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vetro1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plastica1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReverseMachine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxP)).BeginInit();
            this.SuspendLayout();
            // 
            // variabili_box
            // 
            this.variabili_box.Controls.Add(this.panel1);
            this.variabili_box.Controls.Add(this.attuatori_box);
            this.variabili_box.Controls.Add(this.sensori_box);
            this.variabili_box.Controls.Add(this.label1);
            this.variabili_box.Controls.Add(this.label2);
            this.variabili_box.Controls.Add(this.sensori);
            this.variabili_box.Location = new System.Drawing.Point(8, 3);
            this.variabili_box.Margin = new System.Windows.Forms.Padding(2);
            this.variabili_box.Name = "variabili_box";
            this.variabili_box.Padding = new System.Windows.Forms.Padding(2);
            this.variabili_box.Size = new System.Drawing.Size(684, 148);
            this.variabili_box.TabIndex = 0;
            this.variabili_box.TabStop = false;
            this.variabili_box.Text = "Variabili_RVM";
            this.variabili_box.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TextTimerAct2);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.TextTimerAct);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.TextTimerWD);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(534, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 122);
            this.panel1.TabIndex = 15;
            // 
            // TextTimerAct2
            // 
            this.TextTimerAct2.Location = new System.Drawing.Point(84, 78);
            this.TextTimerAct2.Margin = new System.Windows.Forms.Padding(2);
            this.TextTimerAct2.Name = "TextTimerAct2";
            this.TextTimerAct2.Size = new System.Drawing.Size(43, 20);
            this.TextTimerAct2.TabIndex = 10;
            this.TextTimerAct2.Text = "0";
            this.TextTimerAct2.TextChanged += new System.EventHandler(this.TextTimerAct2_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 80);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "TextTimerAct2";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(43, 4);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 18);
            this.label6.TabIndex = 9;
            this.label6.Text = "TIMER";
            // 
            // TextTimerAct
            // 
            this.TextTimerAct.Location = new System.Drawing.Point(84, 51);
            this.TextTimerAct.Margin = new System.Windows.Forms.Padding(2);
            this.TextTimerAct.Name = "TextTimerAct";
            this.TextTimerAct.Size = new System.Drawing.Size(43, 20);
            this.TextTimerAct.TabIndex = 7;
            this.TextTimerAct.Text = "0";
            this.TextTimerAct.TextChanged += new System.EventHandler(this.TextTimerAct_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "TextTimerAct";
            // 
            // TextTimerWD
            // 
            this.TextTimerWD.Location = new System.Drawing.Point(84, 27);
            this.TextTimerWD.Margin = new System.Windows.Forms.Padding(2);
            this.TextTimerWD.Name = "TextTimerWD";
            this.TextTimerWD.Size = new System.Drawing.Size(43, 20);
            this.TextTimerWD.TabIndex = 5;
            this.TextTimerWD.Text = "10000";
            this.TextTimerWD.TextChanged += new System.EventHandler(this.TextTimerWD_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "TextTimerWD";
            // 
            // attuatori_box
            // 
            this.attuatori_box.Controls.Add(this.comandoAlarm_textbox);
            this.attuatori_box.Controls.Add(this.comando_alarm);
            this.attuatori_box.Controls.Add(this.pressaV_textBox);
            this.attuatori_box.Controls.Add(this.camionP_textBox);
            this.attuatori_box.Controls.Add(this.CamionP);
            this.attuatori_box.Controls.Add(this.camionV_textBox);
            this.attuatori_box.Controls.Add(this.CamionV);
            this.attuatori_box.Controls.Add(this.comandoDX3V_textbox);
            this.attuatori_box.Controls.Add(this.label4);
            this.attuatori_box.Controls.Add(this.comando_DX2V);
            this.attuatori_box.Controls.Add(this.comandoDX2V_textbox);
            this.attuatori_box.Controls.Add(this.comando_PressaV);
            this.attuatori_box.Controls.Add(this.pressaP_textBox);
            this.attuatori_box.Controls.Add(this.comando_PressaP);
            this.attuatori_box.Controls.Add(this.comandoDX3P_textbox);
            this.attuatori_box.Controls.Add(this.comando_DX3);
            this.attuatori_box.Controls.Add(this.comandoDX2P_textbox);
            this.attuatori_box.Controls.Add(this.comando_DX2P);
            this.attuatori_box.Controls.Add(this.comandoDX_textbox);
            this.attuatori_box.Controls.Add(this.comando_DX);
            this.attuatori_box.Location = new System.Drawing.Point(278, 16);
            this.attuatori_box.Margin = new System.Windows.Forms.Padding(2);
            this.attuatori_box.Name = "attuatori_box";
            this.attuatori_box.Size = new System.Drawing.Size(253, 122);
            this.attuatori_box.TabIndex = 7;
            this.attuatori_box.Paint += new System.Windows.Forms.PaintEventHandler(this.attuatori_box_Paint);
            // 
            // comandoAlarm_textbox
            // 
            this.comandoAlarm_textbox.Location = new System.Drawing.Point(197, 97);
            this.comandoAlarm_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.comandoAlarm_textbox.Name = "comandoAlarm_textbox";
            this.comandoAlarm_textbox.Size = new System.Drawing.Size(43, 20);
            this.comandoAlarm_textbox.TabIndex = 12;
            this.comandoAlarm_textbox.Text = "False";
            this.comandoAlarm_textbox.TextChanged += new System.EventHandler(this.comandoAlarm_textbox_TextChanged_1);
            // 
            // comando_alarm
            // 
            this.comando_alarm.AutoSize = true;
            this.comando_alarm.Location = new System.Drawing.Point(160, 100);
            this.comando_alarm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comando_alarm.Name = "comando_alarm";
            this.comando_alarm.Size = new System.Drawing.Size(33, 13);
            this.comando_alarm.TabIndex = 11;
            this.comando_alarm.Text = "Alarm";
            // 
            // pressaV_textBox
            // 
            this.pressaV_textBox.Location = new System.Drawing.Point(197, 28);
            this.pressaV_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.pressaV_textBox.Name = "pressaV_textBox";
            this.pressaV_textBox.Size = new System.Drawing.Size(40, 20);
            this.pressaV_textBox.TabIndex = 31;
            this.pressaV_textBox.Text = "False";
            this.pressaV_textBox.TextChanged += new System.EventHandler(this.pressaV_textBox_TextChanged);
            // 
            // camionP_textBox
            // 
            this.camionP_textBox.Location = new System.Drawing.Point(197, 50);
            this.camionP_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.camionP_textBox.Name = "camionP_textBox";
            this.camionP_textBox.Size = new System.Drawing.Size(40, 20);
            this.camionP_textBox.TabIndex = 30;
            this.camionP_textBox.Text = "False";
            this.camionP_textBox.TextChanged += new System.EventHandler(this.camionP_textBox_TextChanged);
            // 
            // CamionP
            // 
            this.CamionP.AutoSize = true;
            this.CamionP.Location = new System.Drawing.Point(146, 53);
            this.CamionP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CamionP.Name = "CamionP";
            this.CamionP.Size = new System.Drawing.Size(49, 13);
            this.CamionP.TabIndex = 29;
            this.CamionP.Text = "CamionP";
            // 
            // camionV_textBox
            // 
            this.camionV_textBox.Location = new System.Drawing.Point(197, 73);
            this.camionV_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.camionV_textBox.Name = "camionV_textBox";
            this.camionV_textBox.Size = new System.Drawing.Size(40, 20);
            this.camionV_textBox.TabIndex = 28;
            this.camionV_textBox.Text = "False";
            this.camionV_textBox.TextChanged += new System.EventHandler(this.camionV_textBox_TextChanged);
            // 
            // CamionV
            // 
            this.CamionV.AutoSize = true;
            this.CamionV.Location = new System.Drawing.Point(144, 76);
            this.CamionV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CamionV.Name = "CamionV";
            this.CamionV.Size = new System.Drawing.Size(49, 13);
            this.CamionV.TabIndex = 27;
            this.CamionV.Text = "CamionV";
            // 
            // comandoDX3V_textbox
            // 
            this.comandoDX3V_textbox.Location = new System.Drawing.Point(92, 95);
            this.comandoDX3V_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.comandoDX3V_textbox.Name = "comandoDX3V_textbox";
            this.comandoDX3V_textbox.Size = new System.Drawing.Size(38, 20);
            this.comandoDX3V_textbox.TabIndex = 26;
            this.comandoDX3V_textbox.Text = "False";
            this.comandoDX3V_textbox.TextChanged += new System.EventHandler(this.comandoDX3V_textbox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Comando DX3V";
            // 
            // comando_DX2V
            // 
            this.comando_DX2V.AutoSize = true;
            this.comando_DX2V.Location = new System.Drawing.Point(8, 52);
            this.comando_DX2V.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comando_DX2V.Name = "comando_DX2V";
            this.comando_DX2V.Size = new System.Drawing.Size(83, 13);
            this.comando_DX2V.TabIndex = 24;
            this.comando_DX2V.Text = "Comando DX2V";
            // 
            // comandoDX2V_textbox
            // 
            this.comandoDX2V_textbox.Location = new System.Drawing.Point(92, 50);
            this.comandoDX2V_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.comandoDX2V_textbox.Name = "comandoDX2V_textbox";
            this.comandoDX2V_textbox.Size = new System.Drawing.Size(38, 20);
            this.comandoDX2V_textbox.TabIndex = 23;
            this.comandoDX2V_textbox.Text = "False";
            this.comandoDX2V_textbox.TextChanged += new System.EventHandler(this.comandoDX2V_textbox_TextChanged);
            // 
            // comando_PressaV
            // 
            this.comando_PressaV.AutoSize = true;
            this.comando_PressaV.Location = new System.Drawing.Point(148, 29);
            this.comando_PressaV.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comando_PressaV.Name = "comando_PressaV";
            this.comando_PressaV.Size = new System.Drawing.Size(46, 13);
            this.comando_PressaV.TabIndex = 19;
            this.comando_PressaV.Text = "PressaV";
            // 
            // pressaP_textBox
            // 
            this.pressaP_textBox.Location = new System.Drawing.Point(197, 4);
            this.pressaP_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.pressaP_textBox.Name = "pressaP_textBox";
            this.pressaP_textBox.Size = new System.Drawing.Size(40, 20);
            this.pressaP_textBox.TabIndex = 16;
            this.pressaP_textBox.Text = "False";
            this.pressaP_textBox.TextChanged += new System.EventHandler(this.pressaP_textBox_TextChanged);
            // 
            // comando_PressaP
            // 
            this.comando_PressaP.AutoSize = true;
            this.comando_PressaP.Location = new System.Drawing.Point(147, 7);
            this.comando_PressaP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comando_PressaP.Name = "comando_PressaP";
            this.comando_PressaP.Size = new System.Drawing.Size(46, 13);
            this.comando_PressaP.TabIndex = 15;
            this.comando_PressaP.Text = "PressaP";
            // 
            // comandoDX3P_textbox
            // 
            this.comandoDX3P_textbox.Location = new System.Drawing.Point(92, 74);
            this.comandoDX3P_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.comandoDX3P_textbox.Name = "comandoDX3P_textbox";
            this.comandoDX3P_textbox.Size = new System.Drawing.Size(38, 20);
            this.comandoDX3P_textbox.TabIndex = 14;
            this.comandoDX3P_textbox.Text = "False";
            this.comandoDX3P_textbox.TextChanged += new System.EventHandler(this.comandoDX3_textbox_TextChanged);
            // 
            // comando_DX3
            // 
            this.comando_DX3.AutoSize = true;
            this.comando_DX3.Location = new System.Drawing.Point(8, 76);
            this.comando_DX3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comando_DX3.Name = "comando_DX3";
            this.comando_DX3.Size = new System.Drawing.Size(83, 13);
            this.comando_DX3.TabIndex = 13;
            this.comando_DX3.Text = "Comando DX3P";
            // 
            // comandoDX2P_textbox
            // 
            this.comandoDX2P_textbox.Location = new System.Drawing.Point(92, 27);
            this.comandoDX2P_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.comandoDX2P_textbox.Name = "comandoDX2P_textbox";
            this.comandoDX2P_textbox.Size = new System.Drawing.Size(38, 20);
            this.comandoDX2P_textbox.TabIndex = 12;
            this.comandoDX2P_textbox.Text = "False";
            this.comandoDX2P_textbox.TextChanged += new System.EventHandler(this.comandoDX2P_textbox_TextChanged);
            // 
            // comando_DX2P
            // 
            this.comando_DX2P.AutoSize = true;
            this.comando_DX2P.Location = new System.Drawing.Point(8, 30);
            this.comando_DX2P.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comando_DX2P.Name = "comando_DX2P";
            this.comando_DX2P.Size = new System.Drawing.Size(83, 13);
            this.comando_DX2P.TabIndex = 11;
            this.comando_DX2P.Text = "Comando DX2P";
            // 
            // comandoDX_textbox
            // 
            this.comandoDX_textbox.Location = new System.Drawing.Point(92, 5);
            this.comandoDX_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.comandoDX_textbox.Name = "comandoDX_textbox";
            this.comandoDX_textbox.Size = new System.Drawing.Size(38, 20);
            this.comandoDX_textbox.TabIndex = 5;
            this.comandoDX_textbox.Text = "False";
            this.comandoDX_textbox.TextChanged += new System.EventHandler(this.comandoDX_textbox_TextChanged);
            // 
            // comando_DX
            // 
            this.comando_DX.AutoSize = true;
            this.comando_DX.Location = new System.Drawing.Point(8, 8);
            this.comando_DX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.comando_DX.Name = "comando_DX";
            this.comando_DX.Size = new System.Drawing.Size(70, 13);
            this.comando_DX.TabIndex = 4;
            this.comando_DX.Text = "Comando DX";
            this.comando_DX.Click += new System.EventHandler(this.comando_DX_Click);
            // 
            // sensori_box
            // 
            this.sensori_box.Controls.Add(this.FCDCV_textBox);
            this.sensori_box.Controls.Add(this.label12);
            this.sensori_box.Controls.Add(this.FCDCP_textBox);
            this.sensori_box.Controls.Add(this.label3);
            this.sensori_box.Controls.Add(this.FCD0_textBox);
            this.sensori_box.Controls.Add(this.label11);
            this.sensori_box.Controls.Add(this.FCDPV_textBox);
            this.sensori_box.Controls.Add(this.label5);
            this.sensori_box.Controls.Add(this.FCDPP_textBox);
            this.sensori_box.Controls.Add(this.label7);
            this.sensori_box.Controls.Add(this.FCD3V_textBox);
            this.sensori_box.Controls.Add(this.FCD3V_label);
            this.sensori_box.Controls.Add(this.FCD1V_textBox);
            this.sensori_box.Controls.Add(this.FCD1V_label);
            this.sensori_box.Controls.Add(this.FCD2V_textBox);
            this.sensori_box.Controls.Add(this.FCD2_V);
            this.sensori_box.Controls.Add(this.FCD3P_textBox);
            this.sensori_box.Controls.Add(this.FCD3P_label);
            this.sensori_box.Controls.Add(this.FCD2P_textBox);
            this.sensori_box.Controls.Add(this.FCD2_P);
            this.sensori_box.Controls.Add(this.FCD1P_Textbox);
            this.sensori_box.Controls.Add(this.FCD1P_label);
            this.sensori_box.Controls.Add(this.Reset_Textbox);
            this.sensori_box.Controls.Add(this.Reset_label);
            this.sensori_box.Controls.Add(this.Start_Textbox);
            this.sensori_box.Controls.Add(this.Start_label);
            this.sensori_box.Location = new System.Drawing.Point(5, 16);
            this.sensori_box.Margin = new System.Windows.Forms.Padding(2);
            this.sensori_box.Name = "sensori_box";
            this.sensori_box.Size = new System.Drawing.Size(269, 122);
            this.sensori_box.TabIndex = 6;
            this.sensori_box.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // FCDCV_textBox
            // 
            this.FCDCV_textBox.Location = new System.Drawing.Point(218, 100);
            this.FCDCV_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCDCV_textBox.Name = "FCDCV_textBox";
            this.FCDCV_textBox.Size = new System.Drawing.Size(41, 20);
            this.FCDCV_textBox.TabIndex = 33;
            this.FCDCV_textBox.Text = "False";
            this.FCDCV_textBox.TextChanged += new System.EventHandler(this.FCDCV_textBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(175, 102);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "FCDCV";
            // 
            // FCDCP_textBox
            // 
            this.FCDCP_textBox.Location = new System.Drawing.Point(129, 100);
            this.FCDCP_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCDCP_textBox.Name = "FCDCP_textBox";
            this.FCDCP_textBox.Size = new System.Drawing.Size(39, 20);
            this.FCDCP_textBox.TabIndex = 31;
            this.FCDCP_textBox.Text = "False";
            this.FCDCP_textBox.TextChanged += new System.EventHandler(this.FCDCP_textBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "FCDCP";
            // 
            // FCD0_textBox
            // 
            this.FCD0_textBox.Location = new System.Drawing.Point(40, 92);
            this.FCD0_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCD0_textBox.Name = "FCD0_textBox";
            this.FCD0_textBox.Size = new System.Drawing.Size(39, 20);
            this.FCD0_textBox.TabIndex = 29;
            this.FCD0_textBox.Text = "False";
            this.FCD0_textBox.TextChanged += new System.EventHandler(this.FCD0_textBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 94);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "FCD0";
            // 
            // FCDPV_textBox
            // 
            this.FCDPV_textBox.Location = new System.Drawing.Point(218, 32);
            this.FCDPV_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCDPV_textBox.Name = "FCDPV_textBox";
            this.FCDPV_textBox.Size = new System.Drawing.Size(41, 20);
            this.FCDPV_textBox.TabIndex = 25;
            this.FCDPV_textBox.Text = "False";
            this.FCDPV_textBox.TextChanged += new System.EventHandler(this.FCDPV_textBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "FCDPV";
            // 
            // FCDPP_textBox
            // 
            this.FCDPP_textBox.Location = new System.Drawing.Point(129, 34);
            this.FCDPP_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCDPP_textBox.Name = "FCDPP_textBox";
            this.FCDPP_textBox.Size = new System.Drawing.Size(39, 20);
            this.FCDPP_textBox.TabIndex = 23;
            this.FCDPP_textBox.Text = "False";
            this.FCDPP_textBox.TextChanged += new System.EventHandler(this.FCDPP_textBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "FCDPP";
            // 
            // FCD3V_textBox
            // 
            this.FCD3V_textBox.Location = new System.Drawing.Point(218, 76);
            this.FCD3V_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCD3V_textBox.Name = "FCD3V_textBox";
            this.FCD3V_textBox.Size = new System.Drawing.Size(41, 20);
            this.FCD3V_textBox.TabIndex = 18;
            this.FCD3V_textBox.Text = "False";
            this.FCD3V_textBox.TextChanged += new System.EventHandler(this.FCD3V_textBox_TextChanged);
            // 
            // FCD3V_label
            // 
            this.FCD3V_label.AutoSize = true;
            this.FCD3V_label.Location = new System.Drawing.Point(175, 77);
            this.FCD3V_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FCD3V_label.Name = "FCD3V_label";
            this.FCD3V_label.Size = new System.Drawing.Size(41, 13);
            this.FCD3V_label.TabIndex = 19;
            this.FCD3V_label.Text = "FCD3V";
            // 
            // FCD1V_textBox
            // 
            this.FCD1V_textBox.Location = new System.Drawing.Point(218, 11);
            this.FCD1V_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCD1V_textBox.Name = "FCD1V_textBox";
            this.FCD1V_textBox.Size = new System.Drawing.Size(41, 20);
            this.FCD1V_textBox.TabIndex = 16;
            this.FCD1V_textBox.Text = "False";
            this.FCD1V_textBox.TextChanged += new System.EventHandler(this.FCD1V_Textbox_TextChanged);
            // 
            // FCD1V_label
            // 
            this.FCD1V_label.AutoSize = true;
            this.FCD1V_label.Location = new System.Drawing.Point(175, 13);
            this.FCD1V_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FCD1V_label.Name = "FCD1V_label";
            this.FCD1V_label.Size = new System.Drawing.Size(41, 13);
            this.FCD1V_label.TabIndex = 17;
            this.FCD1V_label.Text = "FCD1V";
            this.FCD1V_label.Click += new System.EventHandler(this.FCD1V_label_Click);
            // 
            // FCD2V_textBox
            // 
            this.FCD2V_textBox.Location = new System.Drawing.Point(218, 53);
            this.FCD2V_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCD2V_textBox.Name = "FCD2V_textBox";
            this.FCD2V_textBox.Size = new System.Drawing.Size(41, 20);
            this.FCD2V_textBox.TabIndex = 14;
            this.FCD2V_textBox.Text = "False";
            this.FCD2V_textBox.TextChanged += new System.EventHandler(this.FCD2V_textBox_TextChanged);
            // 
            // FCD2_V
            // 
            this.FCD2_V.AutoSize = true;
            this.FCD2_V.Location = new System.Drawing.Point(175, 56);
            this.FCD2_V.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FCD2_V.Name = "FCD2_V";
            this.FCD2_V.Size = new System.Drawing.Size(41, 13);
            this.FCD2_V.TabIndex = 15;
            this.FCD2_V.Text = "FCD2V";
            // 
            // FCD3P_textBox
            // 
            this.FCD3P_textBox.Location = new System.Drawing.Point(129, 78);
            this.FCD3P_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCD3P_textBox.Name = "FCD3P_textBox";
            this.FCD3P_textBox.Size = new System.Drawing.Size(39, 20);
            this.FCD3P_textBox.TabIndex = 12;
            this.FCD3P_textBox.Text = "False";
            this.FCD3P_textBox.TextChanged += new System.EventHandler(this.FCD3P_textBox_TextChanged);
            // 
            // FCD3P_label
            // 
            this.FCD3P_label.AutoSize = true;
            this.FCD3P_label.Location = new System.Drawing.Point(86, 79);
            this.FCD3P_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FCD3P_label.Name = "FCD3P_label";
            this.FCD3P_label.Size = new System.Drawing.Size(41, 13);
            this.FCD3P_label.TabIndex = 13;
            this.FCD3P_label.Text = "FCD3P";
            // 
            // FCD2P_textBox
            // 
            this.FCD2P_textBox.Location = new System.Drawing.Point(129, 55);
            this.FCD2P_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.FCD2P_textBox.Name = "FCD2P_textBox";
            this.FCD2P_textBox.Size = new System.Drawing.Size(39, 20);
            this.FCD2P_textBox.TabIndex = 10;
            this.FCD2P_textBox.Text = "False";
            this.FCD2P_textBox.TextChanged += new System.EventHandler(this.FCD2_textBox_TextChanged);
            // 
            // FCD2_P
            // 
            this.FCD2_P.AutoSize = true;
            this.FCD2_P.Location = new System.Drawing.Point(85, 58);
            this.FCD2_P.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FCD2_P.Name = "FCD2_P";
            this.FCD2_P.Size = new System.Drawing.Size(41, 13);
            this.FCD2_P.TabIndex = 11;
            this.FCD2_P.Text = "FCD2P";
            // 
            // FCD1P_Textbox
            // 
            this.FCD1P_Textbox.Location = new System.Drawing.Point(129, 13);
            this.FCD1P_Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.FCD1P_Textbox.Name = "FCD1P_Textbox";
            this.FCD1P_Textbox.Size = new System.Drawing.Size(39, 20);
            this.FCD1P_Textbox.TabIndex = 7;
            this.FCD1P_Textbox.Text = "False";
            this.FCD1P_Textbox.TextChanged += new System.EventHandler(this.FCD1P_Textbox_TextChanged);
            // 
            // FCD1P_label
            // 
            this.FCD1P_label.AutoSize = true;
            this.FCD1P_label.Location = new System.Drawing.Point(86, 15);
            this.FCD1P_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FCD1P_label.Name = "FCD1P_label";
            this.FCD1P_label.Size = new System.Drawing.Size(41, 13);
            this.FCD1P_label.TabIndex = 7;
            this.FCD1P_label.Text = "FCD1P";
            this.FCD1P_label.Click += new System.EventHandler(this.FCD1_label_Click);
            // 
            // Reset_Textbox
            // 
            this.Reset_Textbox.Location = new System.Drawing.Point(41, 39);
            this.Reset_Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Reset_Textbox.Name = "Reset_Textbox";
            this.Reset_Textbox.Size = new System.Drawing.Size(37, 20);
            this.Reset_Textbox.TabIndex = 7;
            this.Reset_Textbox.Text = "False";
            this.Reset_Textbox.TextChanged += new System.EventHandler(this.Reset_Text);
            // 
            // Reset_label
            // 
            this.Reset_label.AutoSize = true;
            this.Reset_label.Location = new System.Drawing.Point(2, 41);
            this.Reset_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Reset_label.Name = "Reset_label";
            this.Reset_label.Size = new System.Drawing.Size(35, 13);
            this.Reset_label.TabIndex = 7;
            this.Reset_label.Text = "Reset";
            this.Reset_label.Click += new System.EventHandler(this.Reset_label_Click);
            // 
            // Start_Textbox
            // 
            this.Start_Textbox.Location = new System.Drawing.Point(41, 16);
            this.Start_Textbox.Margin = new System.Windows.Forms.Padding(2);
            this.Start_Textbox.Name = "Start_Textbox";
            this.Start_Textbox.Size = new System.Drawing.Size(37, 20);
            this.Start_Textbox.TabIndex = 5;
            this.Start_Textbox.Text = "False";
            this.Start_Textbox.TextChanged += new System.EventHandler(this.Start_Text);
            // 
            // Start_label
            // 
            this.Start_label.AutoSize = true;
            this.Start_label.Location = new System.Drawing.Point(4, 18);
            this.Start_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Start_label.Name = "Start_label";
            this.Start_label.Size = new System.Drawing.Size(29, 13);
            this.Start_label.TabIndex = 4;
            this.Start_label.Text = "Start";
            this.Start_label.Click += new System.EventHandler(this.Start_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 2;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "ATTUATORI";
            // 
            // sensori
            // 
            this.sensori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sensori.Location = new System.Drawing.Point(119, 0);
            this.sensori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sensori.Name = "sensori";
            this.sensori.Size = new System.Drawing.Size(81, 18);
            this.sensori.TabIndex = 9;
            this.sensori.Text = "SENSORI";
            this.sensori.Click += new System.EventHandler(this.sensori_Click);
            // 
            // animation_box
            // 
            this.animation_box.Controls.Add(this.PV_textBox);
            this.animation_box.Controls.Add(this.PP_textBox);
            this.animation_box.Controls.Add(this.FCDCV_picture);
            this.animation_box.Controls.Add(this.FCDCP_Picture);
            this.animation_box.Controls.Add(this.Camion_Plastica);
            this.animation_box.Controls.Add(this.Camion_Vetro);
            this.animation_box.Controls.Add(this.contPNum_textBox);
            this.animation_box.Controls.Add(this.contVNum_textBox);
            this.animation_box.Controls.Add(this.allarme);
            this.animation_box.Controls.Add(this.Random_textBox);
            this.animation_box.Controls.Add(this.pressaV);
            this.animation_box.Controls.Add(this.boxV2);
            this.animation_box.Controls.Add(this.boxV1);
            this.animation_box.Controls.Add(this.pictureBox12);
            this.animation_box.Controls.Add(this.pictureBox1);
            this.animation_box.Controls.Add(this.pressaP);
            this.animation_box.Controls.Add(this.boxP1);
            this.animation_box.Controls.Add(this.boxP2);
            this.animation_box.Controls.Add(this.FCD0_Picture);
            this.animation_box.Controls.Add(this.picturePressaV);
            this.animation_box.Controls.Add(this.picturePressaP);
            this.animation_box.Controls.Add(this.pictureBoxV);
            this.animation_box.Controls.Add(this.pictureBoxP);
            this.animation_box.Controls.Add(this.FCD3P_Picture);
            this.animation_box.Controls.Add(this.FCD2P_Picture);
            this.animation_box.Controls.Add(this.FCD2V_Picture);
            this.animation_box.Controls.Add(this.FCD1V_Picture);
            this.animation_box.Controls.Add(this.FCD1P_Picture);
            this.animation_box.Controls.Add(this.Vetro2);
            this.animation_box.Controls.Add(this.Plastica2);
            this.animation_box.Controls.Add(this.alarm);
            this.animation_box.Controls.Add(this.vetro_box);
            this.animation_box.Controls.Add(this.pictureBox10);
            this.animation_box.Controls.Add(this.BoxV);
            this.animation_box.Controls.Add(this.FCD3V_picture);
            this.animation_box.Controls.Add(this.plastic_box);
            this.animation_box.Controls.Add(this.pictureBox4);
            this.animation_box.Controls.Add(this.Vetro1);
            this.animation_box.Controls.Add(this.Plastica1);
            this.animation_box.Controls.Add(this.ReverseMachine);
            this.animation_box.Controls.Add(this.BoxP);
            this.animation_box.Location = new System.Drawing.Point(8, 145);
            this.animation_box.Margin = new System.Windows.Forms.Padding(2);
            this.animation_box.Name = "animation_box";
            this.animation_box.Padding = new System.Windows.Forms.Padding(2);
            this.animation_box.Size = new System.Drawing.Size(948, 271);
            this.animation_box.TabIndex = 1;
            this.animation_box.TabStop = false;
            this.animation_box.Text = "Animation";
            this.animation_box.UseWaitCursor = true;
            this.animation_box.Enter += new System.EventHandler(this.animation_box_Enter);
            // 
            // PV_textBox
            // 
            this.PV_textBox.Location = new System.Drawing.Point(471, 143);
            this.PV_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.PV_textBox.Name = "PV_textBox";
            this.PV_textBox.Size = new System.Drawing.Size(44, 20);
            this.PV_textBox.TabIndex = 51;
            this.PV_textBox.Text = "False";
            this.PV_textBox.UseWaitCursor = true;
            this.PV_textBox.TextChanged += new System.EventHandler(this.PV_textBox_TextChanged);
            // 
            // PP_textBox
            // 
            this.PP_textBox.Location = new System.Drawing.Point(471, 10);
            this.PP_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.PP_textBox.Name = "PP_textBox";
            this.PP_textBox.Size = new System.Drawing.Size(44, 20);
            this.PP_textBox.TabIndex = 50;
            this.PP_textBox.Text = "False";
            this.PP_textBox.UseWaitCursor = true;
            this.PP_textBox.TextChanged += new System.EventHandler(this.PP_textBox_TextChanged);
            // 
            // FCDCV_picture
            // 
            this.FCDCV_picture.BackColor = System.Drawing.Color.Red;
            this.FCDCV_picture.Location = new System.Drawing.Point(810, 230);
            this.FCDCV_picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCDCV_picture.Name = "FCDCV_picture";
            this.FCDCV_picture.Size = new System.Drawing.Size(13, 13);
            this.FCDCV_picture.TabIndex = 49;
            this.FCDCV_picture.TabStop = false;
            this.FCDCV_picture.UseWaitCursor = true;
            // 
            // FCDCP_Picture
            // 
            this.FCDCP_Picture.BackColor = System.Drawing.Color.Red;
            this.FCDCP_Picture.Location = new System.Drawing.Point(810, 109);
            this.FCDCP_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCDCP_Picture.Name = "FCDCP_Picture";
            this.FCDCP_Picture.Size = new System.Drawing.Size(13, 13);
            this.FCDCP_Picture.TabIndex = 48;
            this.FCDCP_Picture.TabStop = false;
            this.FCDCP_Picture.UseWaitCursor = true;
            this.FCDCP_Picture.Click += new System.EventHandler(this.FCDCP_Picture_Click);
            // 
            // Camion_Plastica
            // 
            this.Camion_Plastica.Image = ((System.Drawing.Image)(resources.GetObject("Camion_Plastica.Image")));
            this.Camion_Plastica.Location = new System.Drawing.Point(663, 24);
            this.Camion_Plastica.Margin = new System.Windows.Forms.Padding(2);
            this.Camion_Plastica.Name = "Camion_Plastica";
            this.Camion_Plastica.Size = new System.Drawing.Size(125, 83);
            this.Camion_Plastica.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Camion_Plastica.TabIndex = 46;
            this.Camion_Plastica.TabStop = false;
            this.Camion_Plastica.UseWaitCursor = true;
            this.Camion_Plastica.Visible = false;
            // 
            // Camion_Vetro
            // 
            this.Camion_Vetro.Image = ((System.Drawing.Image)(resources.GetObject("Camion_Vetro.Image")));
            this.Camion_Vetro.Location = new System.Drawing.Point(663, 143);
            this.Camion_Vetro.Margin = new System.Windows.Forms.Padding(2);
            this.Camion_Vetro.Name = "Camion_Vetro";
            this.Camion_Vetro.Size = new System.Drawing.Size(125, 83);
            this.Camion_Vetro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Camion_Vetro.TabIndex = 47;
            this.Camion_Vetro.TabStop = false;
            this.Camion_Vetro.UseWaitCursor = true;
            this.Camion_Vetro.Visible = false;
            // 
            // contPNum_textBox
            // 
            this.contPNum_textBox.Location = new System.Drawing.Point(449, 10);
            this.contPNum_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.contPNum_textBox.Name = "contPNum_textBox";
            this.contPNum_textBox.Size = new System.Drawing.Size(22, 20);
            this.contPNum_textBox.TabIndex = 45;
            this.contPNum_textBox.Text = "0";
            this.contPNum_textBox.UseWaitCursor = true;
            // 
            // contVNum_textBox
            // 
            this.contVNum_textBox.Location = new System.Drawing.Point(449, 143);
            this.contVNum_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.contVNum_textBox.Name = "contVNum_textBox";
            this.contVNum_textBox.Size = new System.Drawing.Size(22, 20);
            this.contVNum_textBox.TabIndex = 44;
            this.contVNum_textBox.Text = "0";
            this.contVNum_textBox.UseWaitCursor = true;
            // 
            // allarme
            // 
            this.allarme.Enabled = false;
            this.allarme.Image = ((System.Drawing.Image)(resources.GetObject("allarme.Image")));
            this.allarme.Location = new System.Drawing.Point(309, 12);
            this.allarme.Margin = new System.Windows.Forms.Padding(2);
            this.allarme.Name = "allarme";
            this.allarme.Size = new System.Drawing.Size(78, 58);
            this.allarme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.allarme.TabIndex = 43;
            this.allarme.TabStop = false;
            this.allarme.UseWaitCursor = true;
            this.allarme.Visible = false;
            this.allarme.Click += new System.EventHandler(this.allarme_Click);
            // 
            // Random_textBox
            // 
            this.Random_textBox.Location = new System.Drawing.Point(19, 38);
            this.Random_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Random_textBox.Name = "Random_textBox";
            this.Random_textBox.Size = new System.Drawing.Size(34, 20);
            this.Random_textBox.TabIndex = 42;
            this.Random_textBox.Text = "False";
            this.Random_textBox.UseWaitCursor = true;
            this.Random_textBox.TextChanged += new System.EventHandler(this.Random_textBox_TextChanged);
            // 
            // pressaV
            // 
            this.pressaV.Image = global::ProgettoRESPA2020.Properties.Resources.pressa_removebg_preview;
            this.pressaV.Location = new System.Drawing.Point(400, 119);
            this.pressaV.Margin = new System.Windows.Forms.Padding(2);
            this.pressaV.Name = "pressaV";
            this.pressaV.Size = new System.Drawing.Size(67, 58);
            this.pressaV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pressaV.TabIndex = 15;
            this.pressaV.TabStop = false;
            this.pressaV.UseWaitCursor = true;
            this.pressaV.Click += new System.EventHandler(this.pressaV_Click);
            // 
            // boxV2
            // 
            this.boxV2.Image = ((System.Drawing.Image)(resources.GetObject("boxV2.Image")));
            this.boxV2.Location = new System.Drawing.Point(412, 218);
            this.boxV2.Margin = new System.Windows.Forms.Padding(2);
            this.boxV2.Name = "boxV2";
            this.boxV2.Size = new System.Drawing.Size(55, 32);
            this.boxV2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxV2.TabIndex = 37;
            this.boxV2.TabStop = false;
            this.boxV2.UseWaitCursor = true;
            this.boxV2.Visible = false;
            // 
            // boxV1
            // 
            this.boxV1.Image = ((System.Drawing.Image)(resources.GetObject("boxV1.Image")));
            this.boxV1.Location = new System.Drawing.Point(405, 193);
            this.boxV1.Margin = new System.Windows.Forms.Padding(2);
            this.boxV1.Name = "boxV1";
            this.boxV1.Size = new System.Drawing.Size(55, 32);
            this.boxV1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxV1.TabIndex = 36;
            this.boxV1.TabStop = false;
            this.boxV1.UseWaitCursor = true;
            this.boxV1.Visible = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox12.Location = new System.Drawing.Point(256, 218);
            this.pictureBox12.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(141, 6);
            this.pictureBox12.TabIndex = 13;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.Location = new System.Drawing.Point(256, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 6);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // pressaP
            // 
            this.pressaP.Image = global::ProgettoRESPA2020.Properties.Resources.pressa_removebg_preview;
            this.pressaP.Location = new System.Drawing.Point(400, 0);
            this.pressaP.Margin = new System.Windows.Forms.Padding(2);
            this.pressaP.Name = "pressaP";
            this.pressaP.Size = new System.Drawing.Size(67, 58);
            this.pressaP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pressaP.TabIndex = 8;
            this.pressaP.TabStop = false;
            this.pressaP.UseWaitCursor = true;
            this.pressaP.Click += new System.EventHandler(this.pressaP_Click);
            // 
            // boxP1
            // 
            this.boxP1.BackColor = System.Drawing.SystemColors.Control;
            this.boxP1.Image = ((System.Drawing.Image)(resources.GetObject("boxP1.Image")));
            this.boxP1.Location = new System.Drawing.Point(406, 74);
            this.boxP1.Margin = new System.Windows.Forms.Padding(2);
            this.boxP1.Name = "boxP1";
            this.boxP1.Size = new System.Drawing.Size(54, 25);
            this.boxP1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxP1.TabIndex = 33;
            this.boxP1.TabStop = false;
            this.boxP1.UseWaitCursor = true;
            this.boxP1.Visible = false;
            // 
            // boxP2
            // 
            this.boxP2.BackColor = System.Drawing.SystemColors.Control;
            this.boxP2.Image = ((System.Drawing.Image)(resources.GetObject("boxP2.Image")));
            this.boxP2.Location = new System.Drawing.Point(413, 90);
            this.boxP2.Margin = new System.Windows.Forms.Padding(2);
            this.boxP2.Name = "boxP2";
            this.boxP2.Size = new System.Drawing.Size(54, 25);
            this.boxP2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.boxP2.TabIndex = 32;
            this.boxP2.TabStop = false;
            this.boxP2.UseWaitCursor = true;
            this.boxP2.Visible = false;
            // 
            // FCD0_Picture
            // 
            this.FCD0_Picture.BackColor = System.Drawing.Color.Red;
            this.FCD0_Picture.Location = new System.Drawing.Point(0, 148);
            this.FCD0_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCD0_Picture.Name = "FCD0_Picture";
            this.FCD0_Picture.Size = new System.Drawing.Size(13, 13);
            this.FCD0_Picture.TabIndex = 31;
            this.FCD0_Picture.TabStop = false;
            this.FCD0_Picture.UseWaitCursor = true;
            // 
            // picturePressaV
            // 
            this.picturePressaV.BackColor = System.Drawing.Color.Red;
            this.picturePressaV.Location = new System.Drawing.Point(426, 178);
            this.picturePressaV.Margin = new System.Windows.Forms.Padding(2);
            this.picturePressaV.Name = "picturePressaV";
            this.picturePressaV.Size = new System.Drawing.Size(20, 11);
            this.picturePressaV.TabIndex = 30;
            this.picturePressaV.TabStop = false;
            this.picturePressaV.UseWaitCursor = true;
            // 
            // picturePressaP
            // 
            this.picturePressaP.BackColor = System.Drawing.Color.Red;
            this.picturePressaP.Location = new System.Drawing.Point(426, 59);
            this.picturePressaP.Margin = new System.Windows.Forms.Padding(2);
            this.picturePressaP.Name = "picturePressaP";
            this.picturePressaP.Size = new System.Drawing.Size(20, 11);
            this.picturePressaP.TabIndex = 29;
            this.picturePressaP.TabStop = false;
            this.picturePressaP.UseWaitCursor = true;
            this.picturePressaP.Click += new System.EventHandler(this.picturePressaP_Click);
            // 
            // pictureBoxV
            // 
            this.pictureBoxV.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxV.Location = new System.Drawing.Point(175, 109);
            this.pictureBoxV.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxV.Name = "pictureBoxV";
            this.pictureBoxV.Size = new System.Drawing.Size(35, 34);
            this.pictureBoxV.TabIndex = 28;
            this.pictureBoxV.TabStop = false;
            this.pictureBoxV.UseWaitCursor = true;
            // 
            // pictureBoxP
            // 
            this.pictureBoxP.BackColor = System.Drawing.Color.Gray;
            this.pictureBoxP.Location = new System.Drawing.Point(175, 71);
            this.pictureBoxP.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxP.Name = "pictureBoxP";
            this.pictureBoxP.Size = new System.Drawing.Size(35, 34);
            this.pictureBoxP.TabIndex = 27;
            this.pictureBoxP.TabStop = false;
            this.pictureBoxP.UseWaitCursor = true;
            // 
            // FCD3P_Picture
            // 
            this.FCD3P_Picture.BackColor = System.Drawing.Color.Red;
            this.FCD3P_Picture.Location = new System.Drawing.Point(645, 109);
            this.FCD3P_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCD3P_Picture.Name = "FCD3P_Picture";
            this.FCD3P_Picture.Size = new System.Drawing.Size(13, 13);
            this.FCD3P_Picture.TabIndex = 26;
            this.FCD3P_Picture.TabStop = false;
            this.FCD3P_Picture.UseWaitCursor = true;
            this.FCD3P_Picture.Click += new System.EventHandler(this.FCD3P_Picture_Click);
            // 
            // FCD2P_Picture
            // 
            this.FCD2P_Picture.BackColor = System.Drawing.Color.Red;
            this.FCD2P_Picture.Location = new System.Drawing.Point(473, 109);
            this.FCD2P_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCD2P_Picture.Name = "FCD2P_Picture";
            this.FCD2P_Picture.Size = new System.Drawing.Size(13, 13);
            this.FCD2P_Picture.TabIndex = 25;
            this.FCD2P_Picture.TabStop = false;
            this.FCD2P_Picture.UseWaitCursor = true;
            this.FCD2P_Picture.Click += new System.EventHandler(this.FCD2P_Picture_Click);
            // 
            // FCD2V_Picture
            // 
            this.FCD2V_Picture.BackColor = System.Drawing.Color.Red;
            this.FCD2V_Picture.Location = new System.Drawing.Point(476, 237);
            this.FCD2V_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCD2V_Picture.Name = "FCD2V_Picture";
            this.FCD2V_Picture.Size = new System.Drawing.Size(13, 13);
            this.FCD2V_Picture.TabIndex = 3;
            this.FCD2V_Picture.TabStop = false;
            this.FCD2V_Picture.UseWaitCursor = true;
            this.FCD2V_Picture.Click += new System.EventHandler(this.FCD2_Picture_Click);
            // 
            // FCD1V_Picture
            // 
            this.FCD1V_Picture.BackColor = System.Drawing.Color.Red;
            this.FCD1V_Picture.Location = new System.Drawing.Point(238, 237);
            this.FCD1V_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCD1V_Picture.Name = "FCD1V_Picture";
            this.FCD1V_Picture.Size = new System.Drawing.Size(13, 13);
            this.FCD1V_Picture.TabIndex = 4;
            this.FCD1V_Picture.TabStop = false;
            this.FCD1V_Picture.UseWaitCursor = true;
            this.FCD1V_Picture.Click += new System.EventHandler(this.FCD1V_Picture_Click);
            // 
            // FCD1P_Picture
            // 
            this.FCD1P_Picture.BackColor = System.Drawing.Color.Red;
            this.FCD1P_Picture.Location = new System.Drawing.Point(238, 109);
            this.FCD1P_Picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCD1P_Picture.Name = "FCD1P_Picture";
            this.FCD1P_Picture.Size = new System.Drawing.Size(13, 13);
            this.FCD1P_Picture.TabIndex = 24;
            this.FCD1P_Picture.TabStop = false;
            this.FCD1P_Picture.UseWaitCursor = true;
            this.FCD1P_Picture.Click += new System.EventHandler(this.FCD1P_Picture_Click);
            // 
            // Vetro2
            // 
            this.Vetro2.Image = ((System.Drawing.Image)(resources.GetObject("Vetro2.Image")));
            this.Vetro2.Location = new System.Drawing.Point(238, 190);
            this.Vetro2.Margin = new System.Windows.Forms.Padding(2);
            this.Vetro2.Name = "Vetro2";
            this.Vetro2.Size = new System.Drawing.Size(67, 32);
            this.Vetro2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Vetro2.TabIndex = 23;
            this.Vetro2.TabStop = false;
            this.Vetro2.UseWaitCursor = true;
            this.Vetro2.Visible = false;
            // 
            // Plastica2
            // 
            this.Plastica2.BackColor = System.Drawing.SystemColors.Control;
            this.Plastica2.Image = ((System.Drawing.Image)(resources.GetObject("Plastica2.Image")));
            this.Plastica2.Location = new System.Drawing.Point(238, 71);
            this.Plastica2.Margin = new System.Windows.Forms.Padding(2);
            this.Plastica2.Name = "Plastica2";
            this.Plastica2.Size = new System.Drawing.Size(67, 32);
            this.Plastica2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plastica2.TabIndex = 22;
            this.Plastica2.TabStop = false;
            this.Plastica2.UseWaitCursor = true;
            this.Plastica2.Visible = false;
            this.Plastica2.Click += new System.EventHandler(this.Plastica2_Click);
            // 
            // alarm
            // 
            this.alarm.Image = ((System.Drawing.Image)(resources.GetObject("alarm.Image")));
            this.alarm.Location = new System.Drawing.Point(85, 41);
            this.alarm.Margin = new System.Windows.Forms.Padding(2);
            this.alarm.Name = "alarm";
            this.alarm.Size = new System.Drawing.Size(43, 34);
            this.alarm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alarm.TabIndex = 20;
            this.alarm.TabStop = false;
            this.alarm.UseWaitCursor = true;
            this.alarm.Visible = false;
            this.alarm.Click += new System.EventHandler(this.alarm1_Click);
            // 
            // vetro_box
            // 
            this.vetro_box.Image = ((System.Drawing.Image)(resources.GetObject("vetro_box.Image")));
            this.vetro_box.Location = new System.Drawing.Point(480, 178);
            this.vetro_box.Margin = new System.Windows.Forms.Padding(2);
            this.vetro_box.Name = "vetro_box";
            this.vetro_box.Size = new System.Drawing.Size(51, 37);
            this.vetro_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.vetro_box.TabIndex = 19;
            this.vetro_box.TabStop = false;
            this.vetro_box.UseWaitCursor = true;
            this.vetro_box.Visible = false;
            this.vetro_box.Click += new System.EventHandler(this.vetro_box_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox10.Location = new System.Drawing.Point(473, 218);
            this.pictureBox10.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(202, 6);
            this.pictureBox10.TabIndex = 16;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.UseWaitCursor = true;
            // 
            // BoxV
            // 
            this.BoxV.Image = global::ProgettoRESPA2020.Properties.Resources.box;
            this.BoxV.Location = new System.Drawing.Point(379, 185);
            this.BoxV.Margin = new System.Windows.Forms.Padding(2);
            this.BoxV.Name = "BoxV";
            this.BoxV.Size = new System.Drawing.Size(110, 73);
            this.BoxV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxV.TabIndex = 14;
            this.BoxV.TabStop = false;
            this.BoxV.UseWaitCursor = true;
            this.BoxV.Click += new System.EventHandler(this.BoxV_Click);
            // 
            // FCD3V_picture
            // 
            this.FCD3V_picture.BackColor = System.Drawing.Color.Red;
            this.FCD3V_picture.Location = new System.Drawing.Point(648, 230);
            this.FCD3V_picture.Margin = new System.Windows.Forms.Padding(2);
            this.FCD3V_picture.Name = "FCD3V_picture";
            this.FCD3V_picture.Size = new System.Drawing.Size(13, 13);
            this.FCD3V_picture.TabIndex = 12;
            this.FCD3V_picture.TabStop = false;
            this.FCD3V_picture.UseWaitCursor = true;
            this.FCD3V_picture.Click += new System.EventHandler(this.FCD3_picture_Click);
            // 
            // plastic_box
            // 
            this.plastic_box.Image = ((System.Drawing.Image)(resources.GetObject("plastic_box.Image")));
            this.plastic_box.Location = new System.Drawing.Point(480, 59);
            this.plastic_box.Margin = new System.Windows.Forms.Padding(2);
            this.plastic_box.Name = "plastic_box";
            this.plastic_box.Size = new System.Drawing.Size(51, 37);
            this.plastic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.plastic_box.TabIndex = 10;
            this.plastic_box.TabStop = false;
            this.plastic_box.UseWaitCursor = true;
            this.plastic_box.Visible = false;
            this.plastic_box.Click += new System.EventHandler(this.plastic_box_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox4.Location = new System.Drawing.Point(473, 99);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(202, 6);
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.UseWaitCursor = true;
            // 
            // Vetro1
            // 
            this.Vetro1.Image = ((System.Drawing.Image)(resources.GetObject("Vetro1.Image")));
            this.Vetro1.Location = new System.Drawing.Point(0, 90);
            this.Vetro1.Margin = new System.Windows.Forms.Padding(2);
            this.Vetro1.Name = "Vetro1";
            this.Vetro1.Size = new System.Drawing.Size(67, 32);
            this.Vetro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Vetro1.TabIndex = 1;
            this.Vetro1.TabStop = false;
            this.Vetro1.UseWaitCursor = true;
            this.Vetro1.Visible = false;
            this.Vetro1.Click += new System.EventHandler(this.Vetro_Click);
            // 
            // Plastica1
            // 
            this.Plastica1.BackColor = System.Drawing.SystemColors.Control;
            this.Plastica1.Image = ((System.Drawing.Image)(resources.GetObject("Plastica1.Image")));
            this.Plastica1.Location = new System.Drawing.Point(0, 99);
            this.Plastica1.Margin = new System.Windows.Forms.Padding(2);
            this.Plastica1.Name = "Plastica1";
            this.Plastica1.Size = new System.Drawing.Size(67, 32);
            this.Plastica1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Plastica1.TabIndex = 0;
            this.Plastica1.TabStop = false;
            this.Plastica1.UseWaitCursor = true;
            this.Plastica1.Visible = false;
            this.Plastica1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReverseMachine
            // 
            this.ReverseMachine.Image = ((System.Drawing.Image)(resources.GetObject("ReverseMachine.Image")));
            this.ReverseMachine.Location = new System.Drawing.Point(106, 59);
            this.ReverseMachine.Margin = new System.Windows.Forms.Padding(2);
            this.ReverseMachine.Name = "ReverseMachine";
            this.ReverseMachine.Size = new System.Drawing.Size(168, 196);
            this.ReverseMachine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ReverseMachine.TabIndex = 2;
            this.ReverseMachine.TabStop = false;
            this.ReverseMachine.UseWaitCursor = true;
            this.ReverseMachine.Click += new System.EventHandler(this.ReverseMachine_Click);
            // 
            // BoxP
            // 
            this.BoxP.Image = global::ProgettoRESPA2020.Properties.Resources.box;
            this.BoxP.Location = new System.Drawing.Point(379, 66);
            this.BoxP.Margin = new System.Windows.Forms.Padding(2);
            this.BoxP.Name = "BoxP";
            this.BoxP.Size = new System.Drawing.Size(110, 73);
            this.BoxP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BoxP.TabIndex = 7;
            this.BoxP.TabStop = false;
            this.BoxP.UseWaitCursor = true;
            this.BoxP.Click += new System.EventHandler(this.pictureBox3_Click_1);
            // 
            // start_button
            // 
            this.start_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_button.Location = new System.Drawing.Point(716, 14);
            this.start_button.Margin = new System.Windows.Forms.Padding(2);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(74, 28);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "START";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // reset_Button
            // 
            this.reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_Button.Location = new System.Drawing.Point(801, 15);
            this.reset_Button.Margin = new System.Windows.Forms.Padding(2);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(76, 28);
            this.reset_Button.TabIndex = 1;
            this.reset_Button.Text = "RESET";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // MasterTimer
            // 
            this.MasterTimer.Interval = 50;
            this.MasterTimer.Tick += new System.EventHandler(this.MasterTimer_Tick);
            // 
            // TimerDelay
            // 
            this.TimerDelay.Interval = 400;
            this.TimerDelay.Tick += new System.EventHandler(this.TimerDelay_Tick);
            // 
            // pause_button
            // 
            this.pause_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause_button.Location = new System.Drawing.Point(881, 15);
            this.pause_button.Margin = new System.Windows.Forms.Padding(2);
            this.pause_button.Name = "pause_button";
            this.pause_button.Size = new System.Drawing.Size(75, 29);
            this.pause_button.TabIndex = 2;
            this.pause_button.Text = "PAUSE";
            this.pause_button.UseVisualStyleBackColor = true;
            this.pause_button.Click += new System.EventHandler(this.pause_button_Click);
            // 
            // Alarm_button
            // 
            this.Alarm_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Alarm_button.Location = new System.Drawing.Point(716, 51);
            this.Alarm_button.Margin = new System.Windows.Forms.Padding(2);
            this.Alarm_button.Name = "Alarm_button";
            this.Alarm_button.Size = new System.Drawing.Size(74, 28);
            this.Alarm_button.TabIndex = 3;
            this.Alarm_button.Text = "ALARM";
            this.Alarm_button.UseVisualStyleBackColor = true;
            this.Alarm_button.Click += new System.EventHandler(this.Alarm_button_Click);
            // 
            // another_button
            // 
            this.another_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.another_button.Location = new System.Drawing.Point(801, 51);
            this.another_button.Margin = new System.Windows.Forms.Padding(2);
            this.another_button.Name = "another_button";
            this.another_button.Size = new System.Drawing.Size(77, 28);
            this.another_button.TabIndex = 4;
            this.another_button.Text = "ADD";
            this.another_button.UseVisualStyleBackColor = true;
            this.another_button.Click += new System.EventHandler(this.another_button_Click);
            // 
            // textConnection
            // 
            this.textConnection.Location = new System.Drawing.Point(716, 121);
            this.textConnection.Margin = new System.Windows.Forms.Padding(2);
            this.textConnection.Name = "textConnection";
            this.textConnection.Size = new System.Drawing.Size(164, 20);
            this.textConnection.TabIndex = 10;
            this.textConnection.TextChanged += new System.EventHandler(this.textConnection_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(716, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 26);
            this.button1.TabIndex = 9;
            this.button1.Text = "CONNECT";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 456);
            this.Controls.Add(this.textConnection);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.another_button);
            this.Controls.Add(this.Alarm_button);
            this.Controls.Add(this.pause_button);
            this.Controls.Add(this.animation_box);
            this.Controls.Add(this.variabili_box);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.reset_Button);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form RVM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.variabili_box.ResumeLayout(false);
            this.variabili_box.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.attuatori_box.ResumeLayout(false);
            this.attuatori_box.PerformLayout();
            this.sensori_box.ResumeLayout(false);
            this.sensori_box.PerformLayout();
            this.animation_box.ResumeLayout(false);
            this.animation_box.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FCDCV_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCDCP_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camion_Plastica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Camion_Vetro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allarme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pressaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxP2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD0_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePressaV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePressaP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD3P_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD2P_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD2V_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD1V_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD1P_Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vetro2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plastica2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vetro_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FCD3V_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plastic_box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vetro1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Plastica1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReverseMachine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        

        #endregion

        private System.Windows.Forms.GroupBox variabili_box;
        private System.Windows.Forms.GroupBox animation_box;
        private System.Windows.Forms.PictureBox Plastica1;
        private System.Windows.Forms.PictureBox Vetro1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.TextBox Start_Textbox;
        private System.Windows.Forms.Label Start_label;
        private System.Windows.Forms.Panel sensori_box;
        private System.Windows.Forms.Label Reset_label;
        private System.Windows.Forms.TextBox Reset_Textbox;
        private System.Windows.Forms.Label sensori;
        private System.Windows.Forms.TextBox FCD1P_Textbox;
        private System.Windows.Forms.Label FCD1P_label;
        private System.Windows.Forms.Panel attuatori_box;
        private System.Windows.Forms.TextBox comandoDX_textbox;
        private System.Windows.Forms.Label comando_DX;
        private System.Windows.Forms.Timer MasterTimer;
        private System.Windows.Forms.Timer TimerDelay;
        private System.Windows.Forms.PictureBox FCD1V_Picture;
        private System.Windows.Forms.PictureBox FCD2V_Picture;
        private Button pause_button;
        private PictureBox ReverseMachine;
        private Button Alarm_button;
        private PictureBox BoxP;
        private PictureBox pictureBox1;
        private PictureBox pressaP;
        private PictureBox pictureBox10;
        private PictureBox pressaV;
        private PictureBox pictureBox12;
        private PictureBox BoxV;
        private PictureBox FCD3V_picture;
        private PictureBox plastic_box;
        private PictureBox pictureBox4;
        private PictureBox vetro_box;
        private PictureBox alarm;
        private TextBox comandoDX3P_textbox;
        private Label comando_DX3;
        private TextBox comandoDX2P_textbox;
        private Label comando_DX2P;
        private TextBox FCD3P_textBox;
        private Label FCD3P_label;
        private TextBox FCD2P_textBox;
        private Label FCD2_P;
        private Label label2;
        private PictureBox Plastica2;
        private PictureBox Vetro2;
        private TextBox FCD2V_textBox;
        private Label FCD2_V;
        private Label comando_PressaV;
        private TextBox pressaP_textBox;
        private Label comando_PressaP;
        private Button another_button;
        private TextBox FCD1V_textBox;
        private Label FCD1V_label;
        private PictureBox FCD3P_Picture;
        private PictureBox FCD2P_Picture;
        private PictureBox FCD1P_Picture;
        private TextBox FCD3V_textBox;
        private Label FCD3V_label;
        private PictureBox pictureBoxV;
        private PictureBox pictureBoxP;
        private PictureBox picturePressaV;
        private PictureBox picturePressaP;
        private PictureBox FCD0_Picture;
        private PictureBox boxP1;
        private PictureBox boxP2;
        private PictureBox boxV2;
        private PictureBox boxV1;
        private Label comando_DX2V;
        private TextBox comandoDX2V_textbox;
        private Panel panel1;
        private Label label6;
        private TextBox TextTimerAct;
        private Label label8;
        private TextBox TextTimerWD;
        private Label label9;
        private TextBox textConnection;
        private Button button1;
        private TextBox Random_textBox;
        private PictureBox allarme;
        private TextBox contPNum_textBox;
        private TextBox contVNum_textBox;
        private TextBox FCDPV_textBox;
        private Label label5;
        private TextBox FCDPP_textBox;
        private Label label7;
        private TextBox FCD0_textBox;
        private Label label11;
        private TextBox comandoAlarm_textbox;
        private Label comando_alarm;
        private TextBox FCDCP_textBox;
        private Label label3;
        private TextBox comandoDX3V_textbox;
        private Label label4;
        private TextBox FCDCV_textBox;
        private Label label12;
        private TextBox camionP_textBox;
        private Label CamionP;
        private TextBox camionV_textBox;
        private Label CamionV;
        private PictureBox FCDCV_picture;
        private PictureBox FCDCP_Picture;
        private PictureBox Camion_Plastica;
        private PictureBox Camion_Vetro;
        private TextBox PV_textBox;
        private TextBox PP_textBox;
        private TextBox pressaV_textBox;
        private TextBox TextTimerAct2;
        private Label label10;
    }
}

