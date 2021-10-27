/*

Lógica e Matemática Discreta - Algoritmo de Dijkstra (Programa Principal)
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace AlgoritmoDeDijkstra{

    public partial class Interface : Form{
    
        public Interface(){

            InitializeComponent();

            tbOrigem.SelectedIndex = 0;
            tbDestino.SelectedIndex = 0;
        }

        static void initialize_single_source(Grafo g, Vertice s){

            foreach(KeyValuePair<string, Vertice> v in g.get_vertices()){

                v.Value.set_distancia(int.MaxValue);
            }

            s.set_distancia(0);
        }

        static Vertice extract_min(SortedDictionary<string, Vertice> Q){

            var key = Q.Keys.ToList()[0];
            Vertice min = Q[key];

            foreach(KeyValuePair<string, Vertice> v in Q){

                if(v.Value.get_distancia() < min.get_distancia())
                
                    min = v.Value;
            }

            Q.Remove(min.get_id());

            return min;
        }

        static void relax(Vertice u, Vertice v){

            int distancia = u.get_distancia() + u.get_peso(v);

            if(v.get_distancia() > distancia){

                v.set_distancia(distancia);
                v.set_vertice_caminho_anterior(u);
            }
        }

        static void add_S(Vertice u, SortedDictionary<string, Vertice> S){

            Vertice vertice;

            if(S.TryGetValue(u.get_id(), out vertice))
            
                vertice = u;
            
            else
            
                S.Add(u.get_id(), u);
        }

        static void calcula_caminho(Vertice alvo, List<Vertice> caminho){

            if(caminho.Count() == 0)
            
                caminho.Add(alvo);
            
            while(alvo.get_vertice_caminho_anterior() != null){

                caminho.Add(alvo.get_vertice_caminho_anterior());
                alvo = alvo.get_vertice_caminho_anterior();
            }
        }

          static void Dijkstra(Grafo g, Vertice s){

            SortedDictionary<string, Vertice> Q = new SortedDictionary<string, Vertice>();

            initialize_single_source(g, s);

            Q = g.get_vertices();

            SortedDictionary<string, Vertice> S = new SortedDictionary<string, Vertice>();

            while(Q.Count > 0){

                Vertice u = extract_min(Q);
                u.set_visitado(true);

                foreach(KeyValuePair<Vertice, int> v in u.get_adjacentes()){

                    if(v.Key.get_visitado() == true)
                    
                        continue;
                    
                    relax(u, v.Key);
                }

                add_S(u, S);
            }

            g.set_vertices(S);
        }

        private void Button1_Click(object sender, EventArgs e){

            Grafo g = new Grafo(true);

            Caminho.Text = "";
            Distância.Text = "";

            Itumbiara.BorderColor = Color.Black;
            Centralina.BorderColor = Color.Black;
            Capinópolis.BorderColor = Color.Black;
            Ituiutaba.BorderColor = Color.Black;
            Tupaciguara.BorderColor = Color.Black;
            MonteAlegredeMinas.BorderColor = Color.Black;
            Douradinhos.BorderColor = Color.Black;
            Grupiara.BorderColor = Color.Black;
            CascalhoRico.BorderColor = Color.Black;
            Araguari.BorderColor = Color.Black;
            Uberlândia.BorderColor = Color.Black;
            EstreladoSul.BorderColor = Color.Black;
            Romaria.BorderColor = Color.Black;
            SantaJuliana.BorderColor = Color.Black;
            Indianópolis.BorderColor = Color.Black;

            AB.BorderColor = Color.Black;
            BC.BorderColor = Color.Black;
            CD.BorderColor = Color.Black;
            AE.BorderColor = Color.Black;
            BF.BorderColor = Color.Black;
            DF.BorderColor = Color.Black;
            DG.BorderColor = Color.Black;
            EF.BorderColor = Color.Black;
            FG.BorderColor = Color.Black;
            EK.BorderColor = Color.Black;
            FK.BorderColor = Color.Black;
            GK.BorderColor = Color.Black;
            JK.BorderColor = Color.Black;
            KM.BorderColor = Color.Black;
            KO.BorderColor = Color.Black;
            IJ.BorderColor = Color.Black;
            JL.BorderColor = Color.Black;
            HI.BorderColor = Color.Black;
            HL.BorderColor = Color.Black;
            LM.BorderColor = Color.Black;
            MN.BorderColor = Color.Black;
            NO.BorderColor = Color.Black;

            g.inserir_vertice("Capinópolis");
            g.inserir_vertice("Ituiutaba");
            g.inserir_vertice("Itumbiara");
            g.inserir_vertice("Centralina");
            g.inserir_vertice("Tupaciguara");
            g.inserir_vertice("Monte Alegre de Minas");
            g.inserir_vertice("Douradinhos");
            g.inserir_vertice("Araguari");
            g.inserir_vertice("Uberlândia");
            g.inserir_vertice("Cascalho Rico");
            g.inserir_vertice("Indianópolis");
            g.inserir_vertice("Grupiara");
            g.inserir_vertice("Estrela do Sul");
            g.inserir_vertice("Romaria");
            g.inserir_vertice("Santa Juliana");

            g.inserir_aresta("Capinópolis", "Ituiutaba", 30);
            g.inserir_aresta("Capinópolis", "Centralina", 40);
            g.inserir_aresta("Itumbiara", "Centralina", 20);
            g.inserir_aresta("Ituiutaba", "Monte Alegre de Minas", 85);
            g.inserir_aresta("Itumbiara", "Tupaciguara", 55);
            g.inserir_aresta("Centralina", "Monte Alegre de Minas", 75);
            g.inserir_aresta("Tupaciguara", "Monte Alegre de Minas", 44);
            g.inserir_aresta("Ituiutaba", "Douradinhos", 90);
            g.inserir_aresta("Monte Alegre de Minas", "Douradinhos", 28);
            g.inserir_aresta("Tupaciguara", "Uberlândia", 60);
            g.inserir_aresta("Monte Alegre de Minas", "Uberlândia", 60);
            g.inserir_aresta("Douradinhos", "Uberlândia", 63);
            g.inserir_aresta("Araguari", "Uberlândia", 30);
            g.inserir_aresta("Araguari", "Cascalho Rico", 28);
            g.inserir_aresta("Araguari", "Estrela do Sul", 34);
            g.inserir_aresta("Uberlândia", "Indianópolis", 45);
            g.inserir_aresta("Uberlândia", "Romaria", 78);
            g.inserir_aresta("Cascalho Rico", "Grupiara", 32);
            g.inserir_aresta("Indianópolis", "Santa Juliana", 40);
            g.inserir_aresta("Grupiara", "Estrela do Sul", 38);
            g.inserir_aresta("Estrela do Sul", "Romaria", 27);
            g.inserir_aresta("Romaria", "Santa Juliana", 28);

            g.inserir_aresta("Ituiutaba", "Capinópolis", 30);
            g.inserir_aresta("Centralina", "Capinópolis", 40);
            g.inserir_aresta("Centralina", "Itumbiara", 20);
            g.inserir_aresta("Monte Alegre de Minas", "Ituiutaba", 85);
            g.inserir_aresta("Tupaciguara", "Itumbiara", 55);
            g.inserir_aresta("Monte Alegre de Minas", "Centralina", 75);
            g.inserir_aresta("Monte Alegre de Minas", "Tupaciguara", 44);
            g.inserir_aresta("Douradinhos", "Ituiutaba", 90);
            g.inserir_aresta("Douradinhos", "Monte Alegre de Minas", 28);
            g.inserir_aresta("Uberlândia", "Tupaciguara", 60);
            g.inserir_aresta("Uberlândia", "Monte Alegre de Minas", 60);
            g.inserir_aresta("Uberlândia", "Douradinhos", 63);
            g.inserir_aresta("Uberlândia", "Araguari", 30);
            g.inserir_aresta("Cascalho Rico", "Araguari", 28);
            g.inserir_aresta("Estrela do Sul", "Araguari", 34);
            g.inserir_aresta("Indianópolis", "Uberlândia", 45);
            g.inserir_aresta("Romaria", "Uberlândia", 78);
            g.inserir_aresta("Grupiara", "Cascalho Rico", 32);
            g.inserir_aresta("Santa Juliana", "Indianópolis", 40);
            g.inserir_aresta("Estrela do Sul", "Grupiara", 38);
            g.inserir_aresta("Romaria", "Estrela do Sul", 27);
            g.inserir_aresta("Santa Juliana", "Romaria", 28);

            List<Vertice> caminho = new List<Vertice>();
 
            Vertice origem = g.get_vertice(tbOrigem.Text.ToString());

            Vertice vertice_alvo = g.get_vertice(tbDestino.Text.ToString());

            String s = "";

            Dijkstra(g, origem);

            calcula_caminho(vertice_alvo, caminho);

            for(int i = caminho.Count() - 1; i >= 0; i--){

                Vertice v = caminho[i];

                if(v.get_id() == "Itumbiara")

                    Itumbiara.BorderColor = Color.Red;

                if(v.get_id() == "Centralina")

                    Centralina.BorderColor = Color.Red;

                if(v.get_id() == "Capinópolis")

                    Capinópolis.BorderColor = Color.Red;

                if(v.get_id() == "Ituiutaba")

                    Ituiutaba.BorderColor = Color.Red;

                if(v.get_id() == "Tupaciguara")

                    Tupaciguara.BorderColor = Color.Red;

                if(v.get_id() == "Monte Alegre de Minas")

                    MonteAlegredeMinas.BorderColor = Color.Red;

                if(v.get_id() == "Douradinhos")

                    Douradinhos.BorderColor = Color.Red;

                if(v.get_id() == "Grupiara")

                    Grupiara.BorderColor = Color.Red;

                if(v.get_id() == "Cascalho Rico")

                    CascalhoRico.BorderColor = Color.Red;

                if(v.get_id() == "Araguari")

                    Araguari.BorderColor = Color.Red;

                if(v.get_id() == "Uberlândia")

                    Uberlândia.BorderColor = Color.Red;

                if(v.get_id() == "Estrela do Sul")

                    EstreladoSul.BorderColor = Color.Red;

                if(v.get_id() == "Romaria")

                    Romaria.BorderColor = Color.Red;

                if(v.get_id() == "Santa Juliana")

                    SantaJuliana.BorderColor = Color.Red;

                if(v.get_id() == "Indianópolis")

                    Indianópolis.BorderColor = Color.Red;

                if(i > 0){

                    Vertice v1 = caminho[i - 1];

                    if((v.get_id() == "Itumbiara" && v1.get_id() == "Centralina") || (v.get_id() == "Centralina" && v1.get_id() == "Itumbiara"))

                        AB.BorderColor = Color.Red;

                    if((v.get_id() == "Centralina" && v1.get_id() == "Capinópolis") || (v.get_id() == "Capinópolis" && v1.get_id() == "Centralina"))

                        BC.BorderColor = Color.Red;

                    if((v.get_id() == "Capinópolis" && v1.get_id() == "Ituiutaba") || (v.get_id() == "Ituiutaba" && v1.get_id() == "Capinópolis"))

                        CD.BorderColor = Color.Red;

                    if((v.get_id() == "Itumbiara" && v1.get_id() == "Tupaciguara") || (v.get_id() == "Tupaciguara" && v1.get_id() == "Itumbiara"))

                        AE.BorderColor = Color.Red;

                    if((v.get_id() == "Centralina" && v1.get_id() == "Monte Alegre de Minas") || (v.get_id() == "Monte Alegre de Minas" && v1.get_id() == "Centralina"))

                        BF.BorderColor = Color.Red;

                    if((v.get_id() == "Ituiutaba" && v1.get_id() == "Monte Alegre de Minas") || (v.get_id() == "Monte Alegre de Minas" && v1.get_id() == "Ituiutaba"))

                        DF.BorderColor = Color.Red;

                    if((v.get_id() == "Ituiutaba" && v1.get_id() == "Douradinhos") || (v.get_id() == "Douradinhos" && v1.get_id() == "Ituiutaba"))

                        DG.BorderColor = Color.Red;

                    if((v.get_id() == "Tupaciguara" && v1.get_id() == "Monte Alegre de Minas") || (v.get_id() == "Monte Alegre de Minas" && v1.get_id() == "Tupaciguara"))

                        EF.BorderColor = Color.Red;

                    if((v.get_id() == "Monte Alegre de Minas" && v1.get_id() == "Douradinhos") || (v.get_id() == "Douradinhos" && v1.get_id() == "Monte Alegre de Minas"))

                        FG.BorderColor = Color.Red;

                    if((v.get_id() == "Tupaciguara" && v1.get_id() == "Uberlândia") || (v.get_id() == "Uberlândia" && v1.get_id() == "Tupaciguara"))

                        EK.BorderColor = Color.Red;

                    if((v.get_id() == "Monte Alegre de Minas" && v1.get_id() == "Uberlândia") || (v.get_id() == "Uberlândia" && v1.get_id() == "Monte Alegre de Minas"))

                        FK.BorderColor = Color.Red;

                    if((v.get_id() == "Douradinhos" && v1.get_id() == "Uberlândia") || (v.get_id() == "Uberlândia" && v1.get_id() == "Douradinhos"))

                        GK.BorderColor = Color.Red;

                    if((v.get_id() == "Uberlândia" && v1.get_id() == "Araguari") || (v.get_id() == "Araguari" && v1.get_id() == "Uberlândia"))

                        JK.BorderColor = Color.Red;

                    if((v.get_id() == "Uberlândia" && v1.get_id() == "Romaria") || (v.get_id() == "Romaria" && v1.get_id() == "Uberlândia"))

                        KM.BorderColor = Color.Red;

                    if((v.get_id() == "Uberlândia" && v1.get_id() == "Indianópolis") || (v.get_id() == "Indianópolis" && v1.get_id() == "Uberlândia"))

                        KO.BorderColor = Color.Red;

                    if((v.get_id() == "Araguari" && v1.get_id() == "Cascalho Rico") || (v.get_id() == "Cascalho Rico" && v1.get_id() == "Araguari"))

                        IJ.BorderColor = Color.Red;

                    if((v.get_id() == "Araguari" && v1.get_id() == "Estrela do Sul") || (v.get_id() == "Estrela do Sul" && v1.get_id() == "Araguari"))

                        JL.BorderColor = Color.Red;

                    if((v.get_id() == "Cascalho Rico" && v1.get_id() == "Grupiara") || (v.get_id() == "Grupiara" && v1.get_id() == "Cascalho Rico"))

                        HI.BorderColor = Color.Red;

                    if((v.get_id() == "Grupiara" && v1.get_id() == "Estrela do Sul") || (v.get_id() == "Estrela do Sul" && v1.get_id() == "Grupiara"))

                        HL.BorderColor = Color.Red;

                    if((v.get_id() == "Estrela do Sul" && v1.get_id() == "Romaria") || (v.get_id() == "Romaria" && v1.get_id() == "Estrela do Sul"))

                        LM.BorderColor = Color.Red;

                    if((v.get_id() == "Romaria" && v1.get_id() == "Santa Juliana") || (v.get_id() == "Santa Juliana" && v1.get_id() == "Romaria"))

                        MN.BorderColor = Color.Red;

                    if((v.get_id() == "Santa Juliana" && v1.get_id() == "Indianópolis") || (v.get_id() == "Indianópolis" && v1.get_id() == "Santa Juliana"))

                        NO.BorderColor = Color.Red;
                }

                s = s + v.get_id() + "\n";
            }

            Caminho.Text = s;
            Distância.Text = "Distância: " + vertice_alvo.get_distancia().ToString() + " Km";
        }
    }
}
