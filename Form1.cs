using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using s_network = WinFormsApp_ToolPaintGraph_59103.Class_Network.SimpleNetwork;
using s_vertex = WinFormsApp_ToolPaintGraph_59103.Class_Network.SimpleNetwork.SimpleVertex;
using s_edge = WinFormsApp_ToolPaintGraph_59103.Class_Network.SimpleNetwork.SimpleEdge;
using alghorithms = WinFormsApp_ToolPaintGraph_59103.Class_Alghorithms;
namespace WinFormsApp_ToolPaintGraph_59103
{
    public partial class Form_Main : Form//класс работы графической формы
    {
        s_network _netw = new s_network();//создаем сеть
        bool _TaskFlag = false;//флаг выполнения 1 задания 
        bool _TaskFlagWiper = false;// флаг выполнения 2 задания        

        public Form_Main()
        {
            InitializeComponent();
            comboBox_Draw.SelectedIndex = 0;
            comboBox_DrawCentr.SelectedIndex = 1;
            comboBox_DrawDown.SelectedIndex = 2;
            comboBox_Edge.SelectedIndex = 3;
        }
             
        private void button_DrawByAlghorithm_Click(object sender, EventArgs e)
        {//событие кнопки для 1 задания 
            _TaskFlag = true;//текущее графическое представление для 1 задания
            _TaskFlagWiper = false;// поэтому 2ой флаг в false
            panel_Draw.Refresh();//стираем всю графику, что была до нажатия кнопки
            Graphics graph = panel_Draw.CreateGraphics();//создаём графическое представление
            //заполняем сеть информацией 
            _netw = alghorithms.vertexes(_netw, panel_Color.BackColor, panel_DrawCentr.BackColor, 
                panel_DrawDown.BackColor, panel_Draw.Height, panel_Draw.Width);
            graph = alghorithms.drawEdges(graph, _netw);//сначала рисуем ветви на основе информации о сети
            graph = alghorithms.drawVert(graph, _netw);//поверх рисуются узлы
            graph.Dispose();//отображение графики
        }

        private void button_DrawingWiper_Click(object sender, EventArgs e)
        {//событие кнопки для 2 задания 
            _TaskFlag = false;//текущее графическое представление для 2 задания
            _TaskFlagWiper = true;//поэтому 1ый флаг false
            panel_Draw.Refresh();//стираем всю графику, что была до нажатия кнопки
            Graphics graph = panel_Draw.CreateGraphics();//создаём графическое представление
            //заполняем сеть информацией 
            _netw = alghorithms.vertexes(_netw, panel_Color.BackColor, panel_DrawCentr.BackColor, 
                panel_DrawDown.BackColor, panel_Draw.Height, panel_Draw.Width);
            //изменяем информацию о расположении узлов по заданию 
            _netw = alghorithms.editVertexes(_netw, panel_Color.BackColor, 
                panel_DrawDown.BackColor, panel_Draw.Height, panel_Draw.Width);
            graph = alghorithms.drawEdges(graph, _netw);//сначала рисуем ветви на основе информации о сети
            graph = alghorithms.drawVert(graph, _netw);//поверх рисуются узлы
            graph.Dispose();//отображение графики
        }

        private void button_DrawEdges_Click(object sender, EventArgs e)
        {//событие кнопки, выполняющей 3 задание 
            Graphics graph = panel_Draw.CreateGraphics();
            //заполняем сеть информацией 
            _netw = alghorithms.vertexes(_netw, panel_Color.BackColor, panel_DrawCentr.BackColor, 
                panel_DrawDown.BackColor, panel_Draw.Height, panel_Draw.Width);
            //изменяем цвет ветвей по заданию 
            graph = alghorithms.editEdges(graph, _netw, _TaskFlag, _TaskFlagWiper, panel_Color.BackColor, 
                panel_DrawDown.BackColor, panel_Edge.BackColor, panel_Draw.Height, panel_Draw.Width);
            graph.Dispose();//отображение графики
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {//вся графика стирается с рабочей области 
            panel_Draw.Refresh();
        }

        //далее: изменяем цвета панелей на выбранные пользователем 
        private void comboBox_Draw_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_Color.BackColor = alghorithms.colors(comboBox_Draw.Text);//цвет для верхних узлов
        }

        private void comboBox_DrawCentr_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_DrawCentr.BackColor = alghorithms.colors(comboBox_DrawCentr.Text);//цвет для средних узлов
        }

        private void comboBox_DrawDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_DrawDown.BackColor = alghorithms.colors(comboBox_DrawDown.Text); //цвет для нижних узлов             
        }

        private void comboBox_Edge_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel_Edge.BackColor = alghorithms.colors(comboBox_Edge.Text);//цвет для ветвей ‐ нужен только для 3 задания
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}