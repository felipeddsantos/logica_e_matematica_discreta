/*

Lógica e Matemática Discreta - Algoritmo de Dijkstra (Interface Gráfica)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace AlgoritmoDeDijkstra{

    partial class Interface{
    
        ///Variável de designer necessária
        private System.ComponentModel.IContainer components = null;

        ///Limpar os recursos que estão sendo usados
        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        ///Método necessário para suporte ao Designer - não modifique o conteúdo deste método com o editor de código
        private void InitializeComponent(){
        
            this.button1 = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.NO = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.MN = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.LM = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.JK = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.HL = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.HI = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.IJ = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.JL = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.EF = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BC = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FG = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.CD = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.AB = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.EK = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.GK = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.KM = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.KO = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.FK = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.DG = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.DF = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.BF = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Tupaciguara = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Douradinhos = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.EstreladoSul = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Uberlândia = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Grupiara = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Araguari = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Indianópolis = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.SantaJuliana = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Romaria = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.MonteAlegredeMinas = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.CascalhoRico = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Centralina = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Capinópolis = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Ituiutaba = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.AE = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.Itumbiara = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.Caminho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Distância = new System.Windows.Forms.Label();
            this.tbOrigem = new System.Windows.Forms.ComboBox();
            this.tbDestino = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1127, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 63);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular Menor Distância";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.NO,
            this.MN,
            this.LM,
            this.JK,
            this.HL,
            this.HI,
            this.IJ,
            this.JL,
            this.EF,
            this.BC,
            this.FG,
            this.CD,
            this.AB,
            this.EK,
            this.GK,
            this.KM,
            this.KO,
            this.FK,
            this.DG,
            this.DF,
            this.BF,
            this.Tupaciguara,
            this.Douradinhos,
            this.EstreladoSul,
            this.Uberlândia,
            this.Grupiara,
            this.Araguari,
            this.Indianópolis,
            this.SantaJuliana,
            this.Romaria,
            this.MonteAlegredeMinas,
            this.CascalhoRico,
            this.Centralina,
            this.Capinópolis,
            this.Ituiutaba,
            this.AE,
            this.Itumbiara});
            this.shapeContainer1.Size = new System.Drawing.Size(1325, 618);
            this.shapeContainer1.TabIndex = 5;
            this.shapeContainer1.TabStop = false;
            // 
            // NO
            // 
            this.NO.BorderWidth = 10;
            this.NO.Name = "NO";
            this.NO.X1 = 980;
            this.NO.X2 = 981;
            this.NO.Y1 = 426;
            this.NO.Y2 = 496;
            // 
            // MN
            // 
            this.MN.BorderWidth = 10;
            this.MN.Name = "MN";
            this.MN.X1 = 975;
            this.MN.X2 = 975;
            this.MN.Y1 = 264;
            this.MN.Y2 = 332;
            // 
            // LM
            // 
            this.LM.BorderWidth = 10;
            this.LM.Name = "LM";
            this.LM.X1 = 967;
            this.LM.X2 = 967;
            this.LM.Y1 = 114;
            this.LM.Y2 = 170;
            // 
            // JK
            // 
            this.JK.BorderWidth = 10;
            this.JK.Name = "JK";
            this.JK.X1 = 695;
            this.JK.X2 = 699;
            this.JK.Y1 = 430;
            this.JK.Y2 = 496;
            // 
            // HL
            // 
            this.HL.BorderWidth = 10;
            this.HL.Name = "HL";
            this.HL.X1 = 745;
            this.HL.X2 = 914;
            this.HL.Y1 = 62;
            this.HL.Y2 = 62;
            // 
            // HI
            // 
            this.HI.BorderWidth = 10;
            this.HI.Name = "HI";
            this.HI.X1 = 689;
            this.HI.X2 = 689;
            this.HI.Y1 = 114;
            this.HI.Y2 = 171;
            // 
            // IJ
            // 
            this.IJ.BorderWidth = 10;
            this.IJ.Name = "IJ";
            this.IJ.X1 = 696;
            this.IJ.X2 = 697;
            this.IJ.Y1 = 265;
            this.IJ.Y2 = 336;
            // 
            // JL
            // 
            this.JL.BorderWidth = 10;
            this.JL.Name = "JL";
            this.JL.X1 = 736;
            this.JL.X2 = 936;
            this.JL.Y1 = 350;
            this.JL.Y2 = 103;
            // 
            // EF
            // 
            this.EF.BorderWidth = 10;
            this.EF.Name = "EF";
            this.EF.X1 = 407;
            this.EF.X2 = 407;
            this.EF.Y1 = 164;
            this.EF.Y2 = 258;
            // 
            // BC
            // 
            this.BC.BorderWidth = 10;
            this.BC.Name = "BC";
            this.BC.X1 = 80;
            this.BC.X2 = 80;
            this.BC.Y1 = 257;
            this.BC.Y2 = 333;
            // 
            // FG
            // 
            this.FG.BorderWidth = 10;
            this.FG.Name = "FG";
            this.FG.X1 = 406;
            this.FG.X2 = 404;
            this.FG.Y1 = 351;
            this.FG.Y2 = 452;
            // 
            // CD
            // 
            this.CD.BorderWidth = 10;
            this.CD.Name = "CD";
            this.CD.X1 = 81;
            this.CD.X2 = 81;
            this.CD.Y1 = 427;
            this.CD.Y2 = 493;
            // 
            // AB
            // 
            this.AB.BorderWidth = 10;
            this.AB.Name = "AB";
            this.AB.X1 = 80;
            this.AB.X2 = 80;
            this.AB.Y1 = 105;
            this.AB.Y2 = 163;
            // 
            // EK
            // 
            this.EK.BorderWidth = 10;
            this.EK.Name = "EK";
            this.EK.X1 = 450;
            this.EK.X2 = 669;
            this.EK.Y1 = 154;
            this.EK.Y2 = 506;
            // 
            // GK
            // 
            this.GK.BorderWidth = 10;
            this.GK.Name = "GK";
            this.GK.X1 = 459;
            this.GK.X2 = 648;
            this.GK.Y1 = 503;
            this.GK.Y2 = 542;
            // 
            // KM
            // 
            this.KM.BorderWidth = 10;
            this.KM.Name = "KM";
            this.KM.X1 = 737;
            this.KM.X2 = 936;
            this.KM.Y1 = 507;
            this.KM.Y2 = 253;
            // 
            // KO
            // 
            this.KO.BorderWidth = 10;
            this.KO.Name = "KO";
            this.KO.X1 = 757;
            this.KO.X2 = 933;
            this.KO.Y1 = 542;
            this.KO.Y2 = 547;
            // 
            // FK
            // 
            this.FK.BorderWidth = 10;
            this.FK.Name = "FK";
            this.FK.X1 = 456;
            this.FK.X2 = 657;
            this.FK.Y1 = 333;
            this.FK.Y2 = 517;
            // 
            // DG
            // 
            this.DG.BorderWidth = 10;
            this.DG.Name = "DG";
            this.DG.X1 = 140;
            this.DG.X2 = 345;
            this.DG.Y1 = 534;
            this.DG.Y2 = 505;
            // 
            // DF
            // 
            this.DF.BorderWidth = 10;
            this.DF.Name = "DF";
            this.DF.X1 = 131;
            this.DF.X2 = 364;
            this.DF.Y1 = 513;
            this.DF.Y2 = 333;
            // 
            // BF
            // 
            this.BF.BorderWidth = 10;
            this.BF.Name = "BF";
            this.BF.X1 = 137;
            this.BF.X2 = 355;
            this.BF.Y1 = 217;
            this.BF.Y2 = 295;
            // 
            // Tupaciguara
            // 
            this.Tupaciguara.BorderColor = System.Drawing.SystemColors.Desktop;
            this.Tupaciguara.BorderWidth = 10;
            this.Tupaciguara.Location = new System.Drawing.Point(358, 75);
            this.Tupaciguara.Name = "Tupaciguara";
            this.Tupaciguara.Size = new System.Drawing.Size(109, 85);
            // 
            // Douradinhos
            // 
            this.Douradinhos.BorderWidth = 10;
            this.Douradinhos.Location = new System.Drawing.Point(348, 457);
            this.Douradinhos.Name = "Douradinhos";
            this.Douradinhos.Size = new System.Drawing.Size(106, 85);
            // 
            // EstreladoSul
            // 
            this.EstreladoSul.BorderWidth = 10;
            this.EstreladoSul.Location = new System.Drawing.Point(918, 23);
            this.EstreladoSul.Name = "EstreladoSul";
            this.EstreladoSul.Size = new System.Drawing.Size(111, 87);
            // 
            // Uberlândia
            // 
            this.Uberlândia.BorderWidth = 10;
            this.Uberlândia.Location = new System.Drawing.Point(652, 501);
            this.Uberlândia.Name = "Uberlândia";
            this.Uberlândia.Size = new System.Drawing.Size(101, 85);
            // 
            // Grupiara
            // 
            this.Grupiara.BorderWidth = 10;
            this.Grupiara.Location = new System.Drawing.Point(641, 24);
            this.Grupiara.Name = "Grupiara";
            this.Grupiara.Size = new System.Drawing.Size(101, 85);
            // 
            // Araguari
            // 
            this.Araguari.BorderWidth = 10;
            this.Araguari.Location = new System.Drawing.Point(648, 341);
            this.Araguari.Name = "Araguari";
            this.Araguari.Size = new System.Drawing.Size(101, 85);
            // 
            // Indianópolis
            // 
            this.Indianópolis.BorderWidth = 10;
            this.Indianópolis.Location = new System.Drawing.Point(936, 500);
            this.Indianópolis.Name = "Indianópolis";
            this.Indianópolis.Size = new System.Drawing.Size(101, 85);
            // 
            // SantaJuliana
            // 
            this.SantaJuliana.BorderWidth = 10;
            this.SantaJuliana.Location = new System.Drawing.Point(929, 336);
            this.SantaJuliana.Name = "SantaJuliana";
            this.SantaJuliana.Size = new System.Drawing.Size(107, 85);
            // 
            // Romaria
            // 
            this.Romaria.BorderWidth = 10;
            this.Romaria.Location = new System.Drawing.Point(920, 175);
            this.Romaria.Name = "Romaria";
            this.Romaria.Size = new System.Drawing.Size(101, 85);
            // 
            // MonteAlegredeMinas
            // 
            this.MonteAlegredeMinas.BorderWidth = 10;
            this.MonteAlegredeMinas.Location = new System.Drawing.Point(358, 262);
            this.MonteAlegredeMinas.Name = "MonteAlegredeMinas";
            this.MonteAlegredeMinas.Size = new System.Drawing.Size(105, 85);
            // 
            // CascalhoRico
            // 
            this.CascalhoRico.BorderWidth = 10;
            this.CascalhoRico.Location = new System.Drawing.Point(644, 175);
            this.CascalhoRico.Name = "CascalhoRico";
            this.CascalhoRico.Size = new System.Drawing.Size(111, 85);
            // 
            // Centralina
            // 
            this.Centralina.BorderWidth = 10;
            this.Centralina.Location = new System.Drawing.Point(32, 167);
            this.Centralina.Name = "Centralina";
            this.Centralina.Size = new System.Drawing.Size(101, 85);
            // 
            // Capinópolis
            // 
            this.Capinópolis.BorderWidth = 10;
            this.Capinópolis.Location = new System.Drawing.Point(32, 337);
            this.Capinópolis.Name = "Capinópolis";
            this.Capinópolis.Size = new System.Drawing.Size(101, 85);
            // 
            // Ituiutaba
            // 
            this.Ituiutaba.BorderWidth = 10;
            this.Ituiutaba.Location = new System.Drawing.Point(35, 497);
            this.Ituiutaba.Name = "Ituiutaba";
            this.Ituiutaba.Size = new System.Drawing.Size(101, 85);
            // 
            // AE
            // 
            this.AE.BorderWidth = 10;
            this.AE.Name = "AE";
            this.AE.X1 = 136;
            this.AE.X2 = 359;
            this.AE.Y1 = 64;
            this.AE.Y2 = 111;
            // 
            // Itumbiara
            // 
            this.Itumbiara.BorderWidth = 10;
            this.Itumbiara.Location = new System.Drawing.Point(31, 15);
            this.Itumbiara.Name = "Itumbiara";
            this.Itumbiara.Size = new System.Drawing.Size(101, 85);
            // 
            // Caminho
            // 
            this.Caminho.AutoSize = true;
            this.Caminho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caminho.Location = new System.Drawing.Point(1079, 379);
            this.Caminho.Name = "Caminho";
            this.Caminho.Size = new System.Drawing.Size(0, 20);
            this.Caminho.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1079, 337);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Caminho:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1079, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1079, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Origem:";
            // 
            // Distância
            // 
            this.Distância.AutoSize = true;
            this.Distância.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Distância.Location = new System.Drawing.Point(1079, 528);
            this.Distância.Name = "Distância";
            this.Distância.Size = new System.Drawing.Size(94, 20);
            this.Distância.TabIndex = 11;
            this.Distância.Text = "Distância: ";
            // 
            // tbOrigem
            // 
            this.tbOrigem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbOrigem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOrigem.FormattingEnabled = true;
            this.tbOrigem.Items.AddRange(new object[] {
            "Araguari",
            "Capinópolis",
            "Cascalho Rico",
            "Centralina",
            "Douradinhos",
            "Estrela do Sul",
            "Grupiara",
            "Indianópolis",
            "Ituiutaba",
            "Itumbiara",
            "Monte Alegre de Minas",
            "Romaria",
            "Santa Juliana",
            "Tupaciguara",
            "Uberlândia"});
            this.tbOrigem.Location = new System.Drawing.Point(1156, 66);
            this.tbOrigem.Name = "tbOrigem";
            this.tbOrigem.Size = new System.Drawing.Size(121, 24);
            this.tbOrigem.TabIndex = 12;
            // 
            // tbDestino
            // 
            this.tbDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbDestino.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDestino.FormattingEnabled = true;
            this.tbDestino.Items.AddRange(new object[] {
            "Araguari",
            "Capinópolis",
            "Cascalho Rico",
            "Centralina",
            "Douradinhos",
            "Estrela do Sul",
            "Grupiara",
            "Indianópolis",
            "Ituiutaba",
            "Itumbiara",
            "Monte Alegre de Minas",
            "Romaria",
            "Santa Juliana",
            "Tupaciguara",
            "Uberlândia"});
            this.tbDestino.Location = new System.Drawing.Point(1161, 124);
            this.tbDestino.Name = "tbDestino";
            this.tbDestino.Size = new System.Drawing.Size(121, 24);
            this.tbDestino.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Itumbiara";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(926, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Estrela do Sul";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(936, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Romaria";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(936, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Santa Juliana";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(57, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Ituiutaba";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(662, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Araguari";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(661, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Grupiara";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(364, 298);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 15);
            this.label11.TabIndex = 21;
            this.label11.Text = "Monte Alegre";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(945, 533);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 15);
            this.label12.TabIndex = 22;
            this.label12.Text = "Indianópolis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(651, 215);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 15);
            this.label13.TabIndex = 23;
            this.label13.Text = "Cascalho Rico";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(364, 112);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 16);
            this.label14.TabIndex = 24;
            this.label14.Text = "Tupaciguara";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(41, 377);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 15);
            this.label15.TabIndex = 25;
            this.label15.Text = "Capinópolis";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(355, 494);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(89, 15);
            this.label16.TabIndex = 26;
            this.label16.Text = "Douradinhos";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(661, 542);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(85, 16);
            this.label17.TabIndex = 27;
            this.label17.Text = "Uberlândia";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(46, 203);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 16);
            this.label18.TabIndex = 28;
            this.label18.Text = "Centralina";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(88, 128);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(49, 16);
            this.label19.TabIndex = 29;
            this.label19.Text = "20 Km";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(88, 298);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(49, 16);
            this.label20.TabIndex = 30;
            this.label20.Text = "40 Km";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(227, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(49, 16);
            this.label21.TabIndex = 31;
            this.label21.Text = "55 Km";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(705, 457);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(49, 16);
            this.label22.TabIndex = 32;
            this.label22.Text = "30 Km";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(638, 297);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 16);
            this.label23.TabIndex = 33;
            this.label23.Text = "28 Km";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(556, 297);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(49, 16);
            this.label24.TabIndex = 34;
            this.label24.Text = "60 Km";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(345, 203);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(49, 16);
            this.label25.TabIndex = 35;
            this.label25.Text = "44 Km";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(88, 457);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(49, 16);
            this.label26.TabIndex = 36;
            this.label26.Text = "30 Km";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(786, 35);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(49, 16);
            this.label30.TabIndex = 40;
            this.label30.Text = "38 Km";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(802, 553);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(49, 16);
            this.label31.TabIndex = 41;
            this.label31.Text = "45 Km";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(204, 217);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 16);
            this.label32.TabIndex = 42;
            this.label32.Text = "75 Km";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(621, 132);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(49, 16);
            this.label33.TabIndex = 43;
            this.label33.Text = "32 Km";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(519, 533);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(49, 16);
            this.label34.TabIndex = 44;
            this.label34.Text = "63 Km";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(345, 411);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(49, 16);
            this.label35.TabIndex = 45;
            this.label35.Text = "28 Km";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(987, 298);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(49, 16);
            this.label36.TabIndex = 46;
            this.label36.Text = "28 Km";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(217, 533);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(49, 16);
            this.label37.TabIndex = 47;
            this.label37.Text = "90 Km";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(204, 389);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(49, 16);
            this.label38.TabIndex = 48;
            this.label38.Text = "85 Km";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(828, 406);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(49, 16);
            this.label39.TabIndex = 49;
            this.label39.Text = "78 Km";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(802, 185);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(49, 16);
            this.label40.TabIndex = 50;
            this.label40.Text = "34 Km";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(987, 457);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(49, 16);
            this.label41.TabIndex = 51;
            this.label41.Text = "40 Km";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(977, 132);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(49, 16);
            this.label42.TabIndex = 52;
            this.label42.Text = "27 Km";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(501, 430);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(49, 16);
            this.label43.TabIndex = 53;
            this.label43.Text = "60 Km";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 618);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDestino);
            this.Controls.Add(this.tbOrigem);
            this.Controls.Add(this.Distância);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Caminho);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Interface";
            this.Text = "Algoritmo de Djikstra";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape AE;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Itumbiara;
        private System.Windows.Forms.Label Caminho;
        private Microsoft.VisualBasic.PowerPacks.LineShape NO;
        private Microsoft.VisualBasic.PowerPacks.LineShape MN;
        private Microsoft.VisualBasic.PowerPacks.LineShape LM;
        private Microsoft.VisualBasic.PowerPacks.LineShape JK;
        private Microsoft.VisualBasic.PowerPacks.LineShape HL;
        private Microsoft.VisualBasic.PowerPacks.LineShape HI;
        private Microsoft.VisualBasic.PowerPacks.LineShape IJ;
        private Microsoft.VisualBasic.PowerPacks.LineShape JL;
        private Microsoft.VisualBasic.PowerPacks.LineShape EF;
        private Microsoft.VisualBasic.PowerPacks.LineShape BC;
        private Microsoft.VisualBasic.PowerPacks.LineShape FG;
        private Microsoft.VisualBasic.PowerPacks.LineShape CD;
        private Microsoft.VisualBasic.PowerPacks.LineShape AB;
        private Microsoft.VisualBasic.PowerPacks.LineShape EK;
        private Microsoft.VisualBasic.PowerPacks.LineShape GK;
        private Microsoft.VisualBasic.PowerPacks.LineShape KM;
        private Microsoft.VisualBasic.PowerPacks.LineShape KO;
        private Microsoft.VisualBasic.PowerPacks.LineShape FK;
        private Microsoft.VisualBasic.PowerPacks.LineShape DG;
        private Microsoft.VisualBasic.PowerPacks.LineShape DF;
        private Microsoft.VisualBasic.PowerPacks.LineShape BF;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Tupaciguara;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Douradinhos;
        private Microsoft.VisualBasic.PowerPacks.OvalShape EstreladoSul;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Uberlândia;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Grupiara;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Araguari;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Indianópolis;
        private Microsoft.VisualBasic.PowerPacks.OvalShape SantaJuliana;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Romaria;
        private Microsoft.VisualBasic.PowerPacks.OvalShape MonteAlegredeMinas;
        private Microsoft.VisualBasic.PowerPacks.OvalShape CascalhoRico;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Centralina;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Capinópolis;
        private Microsoft.VisualBasic.PowerPacks.OvalShape Ituiutaba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Distância;
        private System.Windows.Forms.ComboBox tbOrigem;
        private System.Windows.Forms.ComboBox tbDestino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
    }
}
