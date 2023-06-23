namespace IPAdressCalculator
{
    partial class frmPrimcipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lblTypeNet = new System.Windows.Forms.Label();
            this.lblSubnetValue = new System.Windows.Forms.Label();
            this.lblSubnetTitle = new System.Windows.Forms.Label();
            this.lblHostNet = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblHostMaxBin = new System.Windows.Forms.Label();
            this.lblHostMax = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblHostMinBin = new System.Windows.Forms.Label();
            this.lblHostMin = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lblBroadcastBin = new System.Windows.Forms.Label();
            this.lblBroadcast = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNetwork = new System.Windows.Forms.Label();
            this.lblNetworkBin = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblClassRange = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblClasse = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWildcardBin = new System.Windows.Forms.Label();
            this.lblWildCard = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNetmaskBin = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNetmask = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAddressBin = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(18, 36);
            this.textBox1.MaxLength = 15;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(221, 36);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(110, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(197, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Address (Host or Network)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(218, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Netmask (i.e. 24)";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(357, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 78);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(458, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 26);
            this.button2.TabIndex = 6;
            this.button2.Text = "Sobre";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(12, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(559, 278);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.panel9);
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Controls.Add(this.panel7);
            this.groupBox4.Controls.Add(this.panel6);
            this.groupBox4.Controls.Add(this.panel5);
            this.groupBox4.Controls.Add(this.panel4);
            this.groupBox4.Location = new System.Drawing.Point(9, 102);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(541, 167);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel9.Controls.Add(this.lblTypeNet);
            this.panel9.Controls.Add(this.lblSubnetValue);
            this.panel9.Controls.Add(this.lblSubnetTitle);
            this.panel9.Controls.Add(this.lblHostNet);
            this.panel9.Controls.Add(this.label17);
            this.panel9.Location = new System.Drawing.Point(3, 139);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(535, 25);
            this.panel9.TabIndex = 18;
            // 
            // lblTypeNet
            // 
            this.lblTypeNet.AutoSize = true;
            this.lblTypeNet.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeNet.ForeColor = System.Drawing.Color.Blue;
            this.lblTypeNet.Location = new System.Drawing.Point(416, 6);
            this.lblTypeNet.Name = "lblTypeNet";
            this.lblTypeNet.Size = new System.Drawing.Size(0, 13);
            this.lblTypeNet.TabIndex = 16;
            // 
            // lblSubnetValue
            // 
            this.lblSubnetValue.AutoSize = true;
            this.lblSubnetValue.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubnetValue.ForeColor = System.Drawing.Color.Blue;
            this.lblSubnetValue.Location = new System.Drawing.Point(342, 5);
            this.lblSubnetValue.Name = "lblSubnetValue";
            this.lblSubnetValue.Size = new System.Drawing.Size(0, 15);
            this.lblSubnetValue.TabIndex = 15;
            // 
            // lblSubnetTitle
            // 
            this.lblSubnetTitle.AutoSize = true;
            this.lblSubnetTitle.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubnetTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblSubnetTitle.Location = new System.Drawing.Point(255, 6);
            this.lblSubnetTitle.Name = "lblSubnetTitle";
            this.lblSubnetTitle.Size = new System.Drawing.Size(81, 13);
            this.lblSubnetTitle.TabIndex = 14;
            this.lblSubnetTitle.Text = "Subnetting:";
            this.lblSubnetTitle.Visible = false;
            // 
            // lblHostNet
            // 
            this.lblHostNet.AutoSize = true;
            this.lblHostNet.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostNet.ForeColor = System.Drawing.Color.Blue;
            this.lblHostNet.Location = new System.Drawing.Point(85, 5);
            this.lblHostNet.Name = "lblHostNet";
            this.lblHostNet.Size = new System.Drawing.Size(0, 15);
            this.lblHostNet.TabIndex = 13;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(3, 6);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Host/Net:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel8.Controls.Add(this.lblHostMaxBin);
            this.panel8.Controls.Add(this.lblHostMax);
            this.panel8.Controls.Add(this.label16);
            this.panel8.Location = new System.Drawing.Point(3, 113);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(535, 25);
            this.panel8.TabIndex = 17;
            // 
            // lblHostMaxBin
            // 
            this.lblHostMaxBin.AutoSize = true;
            this.lblHostMaxBin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostMaxBin.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblHostMaxBin.Location = new System.Drawing.Point(255, 6);
            this.lblHostMaxBin.Name = "lblHostMaxBin";
            this.lblHostMaxBin.Size = new System.Drawing.Size(0, 13);
            this.lblHostMaxBin.TabIndex = 13;
            // 
            // lblHostMax
            // 
            this.lblHostMax.AutoSize = true;
            this.lblHostMax.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostMax.ForeColor = System.Drawing.Color.Blue;
            this.lblHostMax.Location = new System.Drawing.Point(85, 5);
            this.lblHostMax.Name = "lblHostMax";
            this.lblHostMax.Size = new System.Drawing.Size(0, 15);
            this.lblHostMax.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 11;
            this.label16.Text = "HostMax:";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel7.Controls.Add(this.lblHostMinBin);
            this.panel7.Controls.Add(this.lblHostMin);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Location = new System.Drawing.Point(3, 87);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(535, 25);
            this.panel7.TabIndex = 16;
            // 
            // lblHostMinBin
            // 
            this.lblHostMinBin.AutoSize = true;
            this.lblHostMinBin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostMinBin.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblHostMinBin.Location = new System.Drawing.Point(255, 6);
            this.lblHostMinBin.Name = "lblHostMinBin";
            this.lblHostMinBin.Size = new System.Drawing.Size(0, 13);
            this.lblHostMinBin.TabIndex = 12;
            // 
            // lblHostMin
            // 
            this.lblHostMin.AutoSize = true;
            this.lblHostMin.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHostMin.ForeColor = System.Drawing.Color.Blue;
            this.lblHostMin.Location = new System.Drawing.Point(85, 5);
            this.lblHostMin.Name = "lblHostMin";
            this.lblHostMin.Size = new System.Drawing.Size(0, 15);
            this.lblHostMin.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label15.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(3, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "HostMin:";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel6.Controls.Add(this.lblBroadcastBin);
            this.panel6.Controls.Add(this.lblBroadcast);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(3, 61);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(535, 25);
            this.panel6.TabIndex = 15;
            // 
            // lblBroadcastBin
            // 
            this.lblBroadcastBin.AutoSize = true;
            this.lblBroadcastBin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroadcastBin.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblBroadcastBin.Location = new System.Drawing.Point(255, 6);
            this.lblBroadcastBin.Name = "lblBroadcastBin";
            this.lblBroadcastBin.Size = new System.Drawing.Size(0, 13);
            this.lblBroadcastBin.TabIndex = 11;
            // 
            // lblBroadcast
            // 
            this.lblBroadcast.AutoSize = true;
            this.lblBroadcast.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroadcast.ForeColor = System.Drawing.Color.Blue;
            this.lblBroadcast.Location = new System.Drawing.Point(85, 5);
            this.lblBroadcast.Name = "lblBroadcast";
            this.lblBroadcast.Size = new System.Drawing.Size(0, 15);
            this.lblBroadcast.TabIndex = 10;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(3, 6);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Broadcast:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.lblNetwork);
            this.panel5.Controls.Add(this.lblNetworkBin);
            this.panel5.Location = new System.Drawing.Point(3, 35);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(535, 25);
            this.panel5.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(3, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Network:";
            // 
            // lblNetwork
            // 
            this.lblNetwork.AutoSize = true;
            this.lblNetwork.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetwork.ForeColor = System.Drawing.Color.Blue;
            this.lblNetwork.Location = new System.Drawing.Point(85, 5);
            this.lblNetwork.Name = "lblNetwork";
            this.lblNetwork.Size = new System.Drawing.Size(0, 15);
            this.lblNetwork.TabIndex = 9;
            // 
            // lblNetworkBin
            // 
            this.lblNetworkBin.AutoSize = true;
            this.lblNetworkBin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetworkBin.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblNetworkBin.Location = new System.Drawing.Point(255, 6);
            this.lblNetworkBin.Name = "lblNetworkBin";
            this.lblNetworkBin.Size = new System.Drawing.Size(0, 13);
            this.lblNetworkBin.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel4.Controls.Add(this.lblClassRange);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lblClasse);
            this.panel4.Location = new System.Drawing.Point(3, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(535, 25);
            this.panel4.TabIndex = 10;
            // 
            // lblClassRange
            // 
            this.lblClassRange.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblClassRange.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassRange.ForeColor = System.Drawing.Color.Blue;
            this.lblClassRange.Location = new System.Drawing.Point(257, 6);
            this.lblClassRange.Name = "lblClassRange";
            this.lblClassRange.Size = new System.Drawing.Size(271, 13);
            this.lblClassRange.TabIndex = 2;
            this.lblClassRange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Class:";
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClasse.ForeColor = System.Drawing.Color.Blue;
            this.lblClasse.Location = new System.Drawing.Point(85, 5);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(0, 13);
            this.lblClasse.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(9, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(541, 89);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel3.Controls.Add(this.lblWildcardBin);
            this.panel3.Controls.Add(this.lblWildCard);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Location = new System.Drawing.Point(3, 61);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(535, 25);
            this.panel3.TabIndex = 9;
            // 
            // lblWildcardBin
            // 
            this.lblWildcardBin.AutoSize = true;
            this.lblWildcardBin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWildcardBin.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblWildcardBin.Location = new System.Drawing.Point(255, 6);
            this.lblWildcardBin.Name = "lblWildcardBin";
            this.lblWildcardBin.Size = new System.Drawing.Size(0, 13);
            this.lblWildcardBin.TabIndex = 9;
            // 
            // lblWildCard
            // 
            this.lblWildCard.AutoSize = true;
            this.lblWildCard.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWildCard.ForeColor = System.Drawing.Color.Blue;
            this.lblWildCard.Location = new System.Drawing.Point(85, 5);
            this.lblWildCard.Name = "lblWildCard";
            this.lblWildCard.Size = new System.Drawing.Size(0, 15);
            this.lblWildCard.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Wildcard:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.lblNetmaskBin);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.lblNetmask);
            this.panel2.Location = new System.Drawing.Point(3, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 25);
            this.panel2.TabIndex = 9;
            // 
            // lblNetmaskBin
            // 
            this.lblNetmaskBin.AutoSize = true;
            this.lblNetmaskBin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetmaskBin.ForeColor = System.Drawing.Color.Red;
            this.lblNetmaskBin.Location = new System.Drawing.Point(255, 6);
            this.lblNetmaskBin.Name = "lblNetmaskBin";
            this.lblNetmaskBin.Size = new System.Drawing.Size(0, 13);
            this.lblNetmaskBin.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(3, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Netmask:";
            // 
            // lblNetmask
            // 
            this.lblNetmask.AutoSize = true;
            this.lblNetmask.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetmask.ForeColor = System.Drawing.Color.Blue;
            this.lblNetmask.Location = new System.Drawing.Point(85, 5);
            this.lblNetmask.Name = "lblNetmask";
            this.lblNetmask.Size = new System.Drawing.Size(0, 15);
            this.lblNetmask.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.lblAddressBin);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Location = new System.Drawing.Point(3, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 25);
            this.panel1.TabIndex = 9;
            // 
            // lblAddressBin
            // 
            this.lblAddressBin.AutoSize = true;
            this.lblAddressBin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressBin.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblAddressBin.Location = new System.Drawing.Point(255, 6);
            this.lblAddressBin.Name = "lblAddressBin";
            this.lblAddressBin.Size = new System.Drawing.Size(0, 13);
            this.lblAddressBin.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Address:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.Color.Blue;
            this.lblAddress.Location = new System.Drawing.Point(85, 5);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 15);
            this.lblAddress.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(455, 377);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "© Andre Devecchi";
            // 
            // frmPrimcipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(582, 398);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmPrimcipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora IP (IPv4)";
            this.Load += new System.EventHandler(this.frmPrimcipal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmPrimcipal_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAddressBin;
        private System.Windows.Forms.Label lblNetmaskBin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblNetmask;
        private System.Windows.Forms.Label lblNetwork;
        private System.Windows.Forms.Label lblNetworkBin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblWildcardBin;
        private System.Windows.Forms.Label lblWildCard;
        private System.Windows.Forms.Label lblBroadcastBin;
        private System.Windows.Forms.Label lblBroadcast;
        private System.Windows.Forms.Label lblHostNet;
        private System.Windows.Forms.Label lblHostMaxBin;
        private System.Windows.Forms.Label lblHostMax;
        private System.Windows.Forms.Label lblHostMinBin;
        private System.Windows.Forms.Label lblHostMin;
        private System.Windows.Forms.Label lblSubnetValue;
        private System.Windows.Forms.Label lblSubnetTitle;
        private System.Windows.Forms.Label lblTypeNet;
        private System.Windows.Forms.Label lblClassRange;
    }
}

