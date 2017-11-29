﻿using System;
using System.Collections.Generic;

namespace Project
{
    public class Graph_
    {
        /*
         Jeder Graph besteht aus zwei Teilen. Der Graphliste die per Index [i][j] angesprochen werden kann. Hierbei werden die Kosten vom Pfad von 
         Knoten i zu Knoten j definiert/wiedergegeben.
         Und jeder Graph eine Liste von Absetzpunkten, nach welchen der Roboter beim Drucken absetzen muss.
         */
        private List<List<double>> m_graph;
        private List<List<bool>> m_absetzPunkte;
        private List<ushort[]> m_VoxelKoordinaten;
        
        //Konstruktoren
        public Graph_()
        {
            m_graph = new List<List<double>>();
            m_absetzPunkte = new List<List<bool>>();
            m_VoxelKoordinaten = new List<ushort[]>();
        }

        public Graph_(List<List<double>> graph, List<List<bool>> absetzPunkte, List<ushort[]> voxelKoordinaten)
        {
            m_graph = graph;
            m_absetzPunkte = absetzPunkte;
            m_VoxelKoordinaten = voxelKoordinaten;
        }

        public Graph_(Graph_ graph)
        {
            m_graph = graph.GetGraph();
            m_absetzPunkte = graph.GetAlleAbsetzpunkte();
            m_VoxelKoordinaten = graph.GetVoxelKoordinaten();
        }

        //Getter für ganze Listen und einzelne Elemente
        public List<List<double>> GetGraph()
        {
            return m_graph;
        }

        public double GetGraphElement(int i, int j)
        {
            return m_graph[i][j];
        }

        public List<List<bool>> GetAlleAbsetzpunkte()
        {
            return m_absetzPunkte;
        }

        public bool GetAbsetzpunkt(int i, int j)
        {
            return m_absetzPunkte[i][j];
        }

        public List<ushort[]> GetVoxelKoordinaten()
        {
            return m_VoxelKoordinaten;
        }

        public ushort[] GetVoxelKoordinaten(int i)
        {
            return m_VoxelKoordinaten[i];
        }

        
        //Setter für ganze Listen und einzelne Elemente
        public void SetGraph(List<List<double>> graph)
        {
            m_graph = graph;
        }

        public void SetGraph(double d, int i, int j)
        {
            m_graph[i][j] = d;
        }

        public void SetAbsetzPunkte(List<List<bool>> absetzPunkte)
        {
            m_absetzPunkte = absetzPunkte;
        }

        public void SetAbsetzPunkte(bool b, int i, int j)
        {
            m_absetzPunkte[i][j] = b;
        }

        public void SetVoxelKoordinaten(ushort[] k ,int i)
        {
            m_VoxelKoordinaten[i] = k;
        }
        
        //Add falls set nicht verfügbar (leere liste)
        public void AddGraphElement(List<double> d)
        {
            m_graph.Add(d);
        }

        public void AddAbsetzPunkt(List<bool> b)
        {
            m_absetzPunkte.Add(b);
        }

        public void AddVoxelKoordinaten(ushort[] k)
        {
            m_VoxelKoordinaten.Add(k);
        }
    }
}