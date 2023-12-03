using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Grafos
{
    public partial class Simulator : Form
    {
        private CGrafo grafo;
        private CVertice nuevoNodo;
        private CVertice NodoOrigen;
        private CVertice NodoDestino;
        private int var_control;
        private Vertice ventanaVertice;
        private EliminarVertice VentanaEliminar;
        private EliminarArco vEliminarArco;
        public Simulator()
        {
            InitializeComponent();
            grafo = new CGrafo();
            nuevoNodo = null;
            /**
             * Variable de control, para saber que accion se esta realizando en la pizarra.
             * Si es 0 -> sin accion, 1 -> Dibujando arco, 2 -> Nuevo vértice
             **/
            var_control = 0;
            ventanaVertice = new Vertice();
            VentanaEliminar = new EliminarVertice();
            vEliminarArco = new EliminarArco();
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        private void Pizarra_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
                grafo.DibujarGrafo(e.Graphics);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pizarra_MouseLeave(object sender, EventArgs e)
        {
            Pizarra.Refresh();
        }

        private void Simulator_Load(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            nuevoNodo = new Grafos.CVertice();
            var_control = 2;
        }

        private void Pizarra_MouseUp(object sender, MouseEventArgs e)
        {
            switch (var_control)
            {
                case 1:
                    if ((NodoDestino = grafo.DetectarPunto(e.Location)) != null && NodoOrigen != NodoDestino)
                    {
                        if (grafo.AgregarArco(NodoOrigen, NodoDestino))
                        {
                            int distancia = 0;
                            NodoOrigen.ListaAdyacencia.Find(v => v.nDestino == NodoDestino).peso = distancia;
                        }
                    }
                    var_control = 0;
                    NodoDestino = null;
                    NodoOrigen = null;
                    Pizarra.Refresh();
                    break;
            }
        }

        private void Pizarra_MouseMove(object sender, MouseEventArgs e)
        {
            switch (var_control) //Utilizamos la variable de control para saber si al mover el mouse, 
                                 //si el valor es 2, se crea un nuevo vertice
            {
                case 2: //Creando nuevo nodo
                    if (nuevoNodo != null) //nuevoNodo es una instancia de la clase CVertice, si es diferente de null procedemos a dibujarlo
                    {
                        int posX = e.Location.X;    //Obtenemos la posicion del mouse en un instante (x,y)
                        int posY = e.Location.Y;

                        if (posX < nuevoNodo.Dimensiones.Width / 2) //Verificamos con todas estas condiciones si el espacio en el que se intenta colocar
                            posX = nuevoNodo.Dimensiones.Width / 2; //el vertice es suficiente, o si no se sale del espacio especificado para este
                        else if (posX > Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2)
                            posX = Pizarra.Size.Width - nuevoNodo.Dimensiones.Width / 2;

                        if (posY < nuevoNodo.Dimensiones.Height / 2)
                            posY = nuevoNodo.Dimensiones.Height / 2;
                        else if (posY > Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2)
                            posY = Pizarra.Size.Height - nuevoNodo.Dimensiones.Width / 2;

                        nuevoNodo.Posicion = new Point(posX, posY); //Una vez verificado el espacio creamos un nuevo punto y lo 
                                                                    //pasamos a la clase CVertice como La posicion en la que debe estar el vertice
                        Pizarra.Refresh();
                        nuevoNodo.DibujarVertice(Pizarra.CreateGraphics()); //Redibujamos el grafico y mantenemos el valor de la variable de control en 2
                    }
                    break;

                case 1: // En el caso que movamos el mouse y el valor de la variable de control sea 1, entonces Dibujamos un arco
                    AdjustableArrowCap bigArrow = new AdjustableArrowCap(4, 4, false); //instanciamos esta clase para dibujar una flecha
                    bigArrow.BaseCap = System.Drawing.Drawing2D.LineCap.Triangle;
                    Pizarra.Refresh();
                    Pizarra.CreateGraphics().DrawLine(new Pen(Brushes.AliceBlue, 2) { CustomEndCap = bigArrow }, NodoOrigen.Posicion, e.Location);
                    break;
            }
        }


        private void Pizarra_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                { //La funcion DetectarPunto nos devuelve null si el lugar donde se esta dando click
                  //no esta sobre un vertice, es decir que no podra salir de este lugar un arco
                    var_control = 1;
                    // recordemos que es usado para indicar el estado en la pizarra:
                    // 0 -> sin accion, 1 -> Dibujando arco, 2 -> Nuevo vértice
                }

                if (nuevoNodo != null && NodoOrigen == null)
                { //si los valores de nuevoNodo es diferente de null (Este valor cambia cuando damos click en Nuevo vertice en el menu)
                  //y ademas el nodo origen Es igual a null
                    ventanaVertice.Visible = false;
                    ventanaVertice.control = false;
                    grafo.AgregarVertice(nuevoNodo);          //Llamamos a la funcion agregar vertice perteneciente a la clase CGrafo
                    ventanaVertice.ShowDialog();              //Mostramoso el form que nos pedira el valor del vertice

                    if (ventanaVertice.control) //control el una variable tipo Bool que pertenece al form Vertice
                    {
                        if (grafo.BuscarVertice(ventanaVertice.txtVertice.Text) == null) //si ese nodo no existe aun lo creamos
                        {
                            nuevoNodo.Valor = ventanaVertice.txtVertice.Text;
                        }
                        else //si ese nodo ya existe enviamos un error
                        {
                            MessageBox.Show("El Nodo " + ventanaVertice.txtVertice.Text + " ya existe en el " + "grafo", "Error nuevo Nodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            grafo.EliminarVertice(""); //el vertice se crea o se dibuja desde antes que abramos el form, por lo cual lo eliminamos con esta funcion.
                        }
                    }
                    else
                    {
                        grafo.EliminarVertice("");
                    }

                    nuevoNodo = null; //Dejamos las variables de control en su valor inicial
                    var_control = 0;
                    Pizarra.Refresh();
                }
            }

            // Si se ha presionado el botón derecho del mouse
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (var_control == 0)
                {
                    if ((NodoOrigen = grafo.DetectarPunto(e.Location)) != null)
                    {
                        CMSCrearVertice.Text = "Nodo " + NodoOrigen.Valor;
                    }
                    else
                        Pizarra.ContextMenuStrip = this.CMSCrearVertice;
                }
            }
        }

        private void eliminarVerticeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaEliminar.Visible = false;
            VentanaEliminar.Econtrol = false;
            VentanaEliminar.ShowDialog();  //Mostramos el Form donde especificaremos el valor del nodo que queremos borrar
            CVertice VerticeOrigen = grafo.BuscarVertice(VentanaEliminar.txtVertice.Text);
            if (VerticeOrigen != null) //si existe entonces lo eliminamos
            {
                grafo.EliminarVertice(VerticeOrigen); //Para eliminar el vertice llamamos al procedimiento EliminarVerice de la clase CGrafo
                Pizarra.Refresh();
            }
            else //sino existe mostramos un error
            {
                MessageBox.Show("El Nodo " + VentanaEliminar.txtVertice.Text + " No existe en el grafo", "Error Eliminar Nodo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Pizarra.Refresh();
        }

        private void eliminarArcoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vEliminarArco.Visible = false;
            vEliminarArco.Econtrol = false;
            vEliminarArco.ShowDialog();
            CVertice eNodoOrigen = grafo.BuscarVertice(vEliminarArco.txtVerticeOrigen.Text);
            CVertice eNodoDestino = grafo.BuscarVertice(vEliminarArco.txtVerticeDestino.Text);

            if (eNodoOrigen == null || eNodoDestino == null)
            {
                MessageBox.Show("Este arco no existe", "Error al eliminar de arco");
            }
            else
            {
                try
                {
                    grafo.EliminarArco(eNodoOrigen, eNodoDestino);
                    Pizarra.Refresh();
                }
                catch
                {
                    MessageBox.Show("Error");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAncho_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
