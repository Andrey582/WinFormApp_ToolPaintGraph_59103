using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using s_network = WinFormsApp_ToolPaintGraph_59103.Class_Network.SimpleNetwork;
using s_vertex = WinFormsApp_ToolPaintGraph_59103.Class_Network.SimpleNetwork.SimpleVertex;
using s_edge = WinFormsApp_ToolPaintGraph_59103.Class_Network.SimpleNetwork.SimpleEdge;

namespace WinFormsApp_ToolPaintGraph_59103
{
    class Class_Alghorithms//класс для описания алгоритмов работы программы 
    { //метод для создания сети 
        public static s_network vertexes(s_network netwrk, Color firstColor, Color secondColor, Color thirdColor, int height, int width)
        {// создаем пустой массив под узлы 
            netwrk.arr_vertexes = new List<s_vertex>();
            //создаем пустой массив под ветви 
            netwrk.arr_edges = new List<s_edge>();
            netwrk.num_of_vertexes = 12;//устанавливаем кол‐во узлов 
            netwrk.num_of_edges = netwrk.num_of_vertexes - 1;//устанавливаем кол‐во ветвей
            for (int num_i = 0; num_i < netwrk.num_of_vertexes; num_i++)
            {//цикл для заполнения сети узлами и ветвями  
                s_vertex new_v = new s_vertex();
                s_edge new_ed = new s_edge();
                int disp = num_i / 3 * 65 + 40;
                new_v.number = num_i;
                switch (num_i)
                {
                    case 0:
                        {
                            new_v.color = firstColor;
                            new_v.x_coord = 10;
                            new_v.y_coord = height / 3;
                            break;
                        }
                    case 1://для средней строки узлов 
                        {
                            new_v.color = secondColor;
                            new_v.x_coord = width * 2 / 12;
                            new_v.y_coord = 10;
                            break;
                        }
                    case 2://для нижней строки узлов 
                        {
                            new_v.color = thirdColor;
                            new_v.x_coord = width * 2 / 12;
                            new_v.y_coord = height - 30;
                            break;
                        }
                    case 3:
                        {
                            new_v.color = firstColor;
                            new_v.x_coord = width * 7 / 12;
                            new_v.y_coord = height - 30;
                            break; 
                        }
                    case 4:
                        {
                            new_v.color = secondColor;
                            new_v.x_coord = width * 7 / 12;
                            new_v.y_coord = 10;
                            break;
                        }
                    case 5:
                        {
                            new_v.color = thirdColor;
                            new_v.x_coord = width * 4 / 12;
                            new_v.y_coord = 10;
                            break;
                        }
                    case 6:
                        {
                            new_v.color = firstColor;
                            new_v.x_coord = width * 4 / 12;
                            new_v.y_coord = height - 30;
                            break;
                        }
                    case 7:
                        {
                            new_v.color = secondColor;
                            new_v.x_coord = width * 9 / 12;
                            new_v.y_coord = height - 30;
                            break;
                        }
                    case 8:
                        {
                            new_v.color = thirdColor;
                            new_v.x_coord = width - 30;
                            new_v.y_coord = height / 2;
                            break;
                        }
                    case 9:
                        {
                            new_v.color = firstColor;
                            new_v.x_coord = width * 9 / 12;
                            new_v.y_coord = height / 2;
                            break;
                        }
                    case 10:
                        {
                            new_v.color = secondColor;
                            new_v.x_coord = width - 30;
                            new_v.y_coord = 10;
                            break;
                        }
                    case 11:
                        {
                            new_v.color = thirdColor;
                            new_v.x_coord = width * 9 / 12;
                            new_v.y_coord = 10;
                            break;
                        }
                }
                netwrk.arr_vertexes.Add(new_v);
                // ветвь соединяет предыдущий узел с текущим, поэтому счетчик >0
                if (num_i > 0)
                {
                    new_ed.begin_SimpleVertex = netwrk.arr_vertexes[num_i - 1];
                    new_ed.end_SimpleVertex = netwrk.arr_vertexes[num_i];
                    new_ed.color = Color.Black;
                    netwrk.arr_edges.Add(new_ed);
                }
            }
            return netwrk;//возвращаем сеть 
        }
        public static s_network editVertexes(s_network netwrk, Color firstColor,
        Color secondColor, int height, int width)
        {//метод изменения узлов для 2 задания 
            for (int num_i = 0; num_i < netwrk.num_of_vertexes; num_i++)
            {//цикл в котором узлы принимают координаты для отображения "змейкой"
                int disp = num_i % 4 * 60 + 80;
                switch (num_i)
                {
                    case 0:
                    case 1:
                    case 2:  
                    case 3:
                        {
                            netwrk.arr_vertexes.ElementAt(num_i).x_coord = 40;
                            netwrk.arr_vertexes.ElementAt(num_i).y_coord = disp;
                            break;
                        }
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                        {
                            netwrk.arr_vertexes.ElementAt(num_i).x_coord = width / 2;
                            netwrk.arr_vertexes.ElementAt(num_i).y_coord = height - disp;
                            break;
                        }
                    case 8: 
                    case 9:
                    case 10:
                    case 11:
                        {
                            netwrk.arr_vertexes.ElementAt(num_i).x_coord = width - 40;
                            netwrk.arr_vertexes.ElementAt(num_i).y_coord = disp;
                            break;
                        }
                }
            }
            return netwrk;//возвращаем сеть 
        }
        public static Graphics drawVert(Graphics graf, s_network netwrk)
        {//метод для графического представления узлов  
            for (int num_i = 0; num_i < netwrk.num_of_vertexes; num_i++)
            {
                //рисуем контур узла 
                graf.DrawEllipse(new
                    Pen(netwrk.arr_vertexes.ElementAt(num_i).color),
                    netwrk.arr_vertexes.ElementAt(num_i).x_coord,
                    netwrk.arr_vertexes.ElementAt(num_i).y_coord, 20, 20);
                //заполняем его цветом 
                graf.FillEllipse(new
                    SolidBrush(netwrk.arr_vertexes.ElementAt(num_i).color),
                    netwrk.arr_vertexes.ElementAt(num_i).x_coord,
                    netwrk.arr_vertexes.ElementAt(num_i).y_coord, 20, 20);
                //пишет строкой номер внутри узла 
                graf.DrawString(num_i.ToString(), new Font("Verdana", 14), 
                    new SolidBrush(Color.Black), 
                    new Point(netwrk.arr_vertexes.ElementAt(num_i).x_coord,
                    netwrk.arr_vertexes.ElementAt(num_i).y_coord));
            }
            return graf;//возвращаем графическое представление 
        }
        public static Graphics drawEdges(Graphics graf, s_network netwrk)
        {  //метод первичной отрисовки ветвей для 1 и 2 заданий 
            Pen myPen = new Pen(Color.Black, 4);
            for (int num_i = 1; num_i < netwrk.num_of_vertexes; num_i++)
            {
                graf.DrawLine(myPen, new Point(netwrk.arr_edges.ElementAt(num_i - 1).begin_SimpleVertex.x_coord + 10, 
                    netwrk.arr_edges.ElementAt(num_i - 1).begin_SimpleVertex.y_coord + 10), 
                    new Point(netwrk.arr_edges.ElementAt(num_i - 1).end_SimpleVertex.x_coord + 10, 
                    netwrk.arr_edges.ElementAt(num_i - 1).end_SimpleVertex.y_coord + 10));
            }
            return graf;
        }
        public static Graphics editEdges(Graphics graf, s_network netwrk, bool taskFlag, 
            bool taskFlagWiperColor, Color firstColor, Color secondColor,
            Color edgesColor, int height, int width)
        {//метод изменения ветвей и рисования для 3 задания 
            Pen myPen = new Pen(Color.Black, 4);
            if (taskFlag == true)//флаг, указывающий о выполнении 1 задания 
            {
                for (int num_i = 1; num_i < netwrk.num_of_vertexes; num_i++)
                {//проверяем цвета узлов 
                    if (netwrk.arr_vertexes.ElementAt(num_i).color == netwrk.arr_vertexes.ElementAt(num_i - 1).color)
                    {
                        myPen.Color = edgesColor;//если цвета одинаковые ‐ меняем цвет ветви 
                    }
                    else
                    {
                        myPen.Color = Color.Black;//иначе ‐ оставляем цвет прежним 
                    }
                    //отрисовка ветвей 
                    graf.DrawLine(myPen, new Point(netwrk.arr_edges.ElementAt(num_i - 1).begin_SimpleVertex.x_coord + 10, 
                        netwrk.arr_edges.ElementAt(num_i - 1).begin_SimpleVertex.y_coord + 10), 
                        new Point(netwrk.arr_edges.ElementAt(num_i - 1).end_SimpleVertex.x_coord + 10, 
                        netwrk.arr_edges.ElementAt(num_i - 1).end_SimpleVertex.y_coord + 10));
                }
                graf = drawVert(graf, netwrk);//вызов метода для отрисовки узлов 
            }
            else if (taskFlagWiperColor == true)//флаг, указывающий о выполнении 2 задания
            {
                netwrk = editVertexes(netwrk, firstColor, secondColor, height, width);//вызов метода для 2 задания 
                for (int num_i = 1; num_i < netwrk.num_of_vertexes; num_i++)
                {//проверяем цвета узлов 
                    if (netwrk.arr_vertexes.ElementAt(num_i).color == netwrk.arr_vertexes.ElementAt(num_i - 1).color)
                    {
                        myPen.Color = edgesColor;
                    }
                    else
                    {
                        myPen.Color = Color.Black;
                    }
                    graf.DrawLine(myPen, new Point(netwrk.arr_edges.ElementAt(num_i - 1).begin_SimpleVertex.x_coord + 10, 
                        netwrk.arr_edges.ElementAt(num_i - 1).begin_SimpleVertex.y_coord + 10), 
                        new Point(netwrk.arr_edges.ElementAt(num_i - 1).end_SimpleVertex.x_coord + 10, 
                        netwrk.arr_edges.ElementAt(num_i - 1).end_SimpleVertex.y_coord + 10));
                }
                graf = drawVert(graf, netwrk);
            }
            return graf;//возвращаем графическое представление 
        }
        public static Color colors(string txt)
        {//метод для определения цвета, выбранного в форме по названию 
            Color newColor = Color.Black;
            switch (txt)
            {
                case "Red":
                    {
                        newColor = Color.Red;
                        break;
                    }
                case "Green":
                    {
                        newColor = Color.Green;
                        break;
                    }
                case "Blue":
                    {
                        newColor = Color.Blue;
                        break;
                    }
                case "Yellow":
                    {
                        newColor = Color.Yellow;
                        break;
                    }
                case "Silver":
                    {
                        newColor = Color.Silver;
                        break;
                    }
                case "Orange":
                    {
                        newColor = Color.Orange;
                        break;
                    }
            }
            return newColor;//возвращаем цвет 
        }
    }
}
