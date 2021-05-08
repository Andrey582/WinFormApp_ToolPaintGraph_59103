
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_ToolPaintGraph_59103
{
    public class Class_Network
    {

        public class SimpleNetwork//класс сети
        {
            public IList<SimpleVertex> arr_vertexes;//массив узлов
            public IList<SimpleEdge> arr_edges;//массив ветвей
            public int num_of_vertexes { get; set; }//кол‐во узлов
            public int num_of_edges { get; set; }//кол‐во ветвей

            public class SimpleVertex //класс узла
            {
                public SimpleVertex()//конструктор класса по умолчанию
                {
                    number = 0;
                    color = Color.White;
                    x_coord = 0;
                    y_coord = 0;
                }
                public int number { get; set; }//номер узла
                public Color color { get; set; }//его цвет
                public int x_coord { get; set; }//координато по оси х
                public int y_coord { get; set; }// координата по оси у


            }

            public class SimpleEdge // класс ветви
            {
                public SimpleEdge()//конструктор по умолчанию
                {
                    begin_SimpleVertex = new SimpleVertex();
                    end_SimpleVertex = new SimpleVertex();
                    color = Color.White;
                }
                public SimpleVertex begin_SimpleVertex
                {
                    get; set;
                }//начальный узел
                public SimpleVertex end_SimpleVertex
                {
                    get; set;
                }//конечный узел
                public Color color { get; set; }//цвет ветви

            }
        }
    }
}
