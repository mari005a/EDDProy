using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
//using GraphVizWrapper;
//using GraphVizWrapper.Commands;
//using GraphVizWrapper.Queries;

namespace EDDemo.Estructuras_No_Lineales
{
    public partial class frmArboles : Form
    {
        ArbolBusqueda miArbol;
        NodoBinario miRaiz;

        public frmArboles()
        {
            InitializeComponent();
            miArbol = new ArbolBusqueda();
            miRaiz = null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
 
            //Obtenemos el nodo Raiz del arbol
            miRaiz = miArbol.RegresaRaiz();

            //Limpiamos la cadena donde se concatenan los nodos del arbol 
            miArbol.strArbol = "";

            //Se inserta el nodo con el dato capturado
            miArbol.InsertaNodo(int.Parse(txtDato.Text),
                                ref miRaiz);

            //Leer arbol completo y mostrarlo en caja de texto
            miArbol.Muestra(1, miRaiz);
            txtArbol.Text = miArbol.strArbol;
            
            txtDato.Text = "";

 
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            miArbol = null;
            miRaiz = null;
            miArbol = new ArbolBusqueda();
            txtArbol.Text  = "";
            txtDato.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var getStartProcessQuery = new GetStartProcessQuery();
            //var getProcessStartInfoQuery = new GetProcessStartInfoQuery();
            //var registerLayoutPluginCommand = new RegisterLayoutPluginCommand(getProcessStartInfoQuery, getStartProcessQuery);

            //// GraphGeneration can be injected via the IGraphGeneration interface

            //var wrapper = new GraphGeneration(getStartProcessQuery,
            //                                  getProcessStartInfoQuery,
            //                                  registerLayoutPluginCommand);

            //byte[] output = wrapper.GenerateGraph("digraph{a -> b; b -> c; c -> a;}", Enums.GraphReturnType.Png);
            
            ////String graphVizString = @" digraph g{ label=""Graph""; labelloc=top;labeljust=left;}";
            ////Bitmap bm = FileDotEngine.Run(graphVizString);
        }
    }
}
