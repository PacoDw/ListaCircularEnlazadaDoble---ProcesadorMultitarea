using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtencionProcesos_ListaCircularEnlazada
{
    public partial class FormMain : Form
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //ATRIBUTOS DE LA CLASE
        private ListaProcesos listaProcesos;
        private static Random alea = new Random();
        private static Random aleatorio = new Random();
        private int _probabilidad;
        private int _vidaProceso;
        private int _ciclosOcio;
        private int _numMayorCiclos;
        private int _EnQueCiclo;
        private int _totalProcesosA;
        private string _reporte;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public FormMain()
        {
            InitializeComponent();
            _probabilidad = 0;
            _vidaProceso = 0;
            _ciclosOcio = 0;
            _numMayorCiclos = 0;
            _EnQueCiclo = 0;
            _totalProcesosA = 0;
            _reporte = string.Empty;

            bttonMostrarReportes.Enabled = false;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON COMENZAR - realiza todo lo necesario para procesar los ciclos
        private void bttonComenzar_Click(object sender, EventArgs e)
        {
            listaProcesos = new ListaProcesos();
            _ciclosOcio = 0;
            _numMayorCiclos = 0;
            _EnQueCiclo = 0;
            _totalProcesosA = 0;
            _reporte = string.Empty;

            bttonMostrarReportes.Enabled = false;
            Comenzar();
            bttonMostrarReportes.Enabled = true;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //BUTTON MOSTRAR PROCESOS - muestra todas las estidisticas
        private void bttonMostrarReportes_Click(object sender, EventArgs e)
        {
            txtListaProcesosPendientes.Text = listaProcesos.ToString();
            txtCilcosOcio.Text = Convert.ToString(_ciclosOcio);
            txtNumMaximoProcesos.Text = Convert.ToString(_numMayorCiclos + " desde el ciclo " + _EnQueCiclo);
            txtProcesosPendientes.Text = Convert.ToString(listaProcesos.Count);
            txtCiclosPendientes.Text = Convert.ToString(listaProcesos.CiclosPendientes);
            txtProcesosAtendidos.Text = Convert.ToString(_totalProcesosA);

            txtMostrarActividad.Text = _reporte;
        }

        private void Comenzar()
        {
            int num = 1;

            Proceso temp = null;

            for (int i = 1; i <= 200; i++)
            {
                //Contamos cada vuelta el ciclo para mostrarlo en el reporte
                _reporte += "===========================" + Environment.NewLine
                          + "             Ciclo:  " + i + Environment.NewLine
                          + "===========================" + Environment.NewLine;

                _probabilidad = alea.Next(1, 12);
                _vidaProceso = aleatorio.Next(4, 12);
                if (_probabilidad >= 1 && _probabilidad <= 3)
                {
                    Proceso nuevo = new Proceso(num++, _vidaProceso);
                    listaProcesos.Agregar(nuevo);

                    if (num == 2)
                        temp = listaProcesos.Inicio;

                    _totalProcesosA++;
                }

                if (listaProcesos.Actual() != null)
                {

                    if (listaProcesos.Actual().VidaRestante > 0)
                    {
                        listaProcesos.Actual().VidaRestante -= 1;
                        _reporte += listaProcesos.Actual().ToString();
                        listaProcesos.moverAsiguiente();
                    }
                    else
                    {
                        _reporte += "Proceso: " + listaProcesos.Actual().NumProceso + Environment.NewLine
                                  + "Ciclos originales:  Null" + Environment.NewLine
                                  + "    Proceso ELIMINADO" + Environment.NewLine
                                  + "-----------------------------" + Environment.NewLine;
                        listaProcesos.Eliminar(listaProcesos.Actual());
                    }
                }
                else
                {
                    _reporte += "Proceso: Sin proceso" + Environment.NewLine
                              + "Ciclos originales:  Null" + Environment.NewLine
                              + "Ciclos restabtes:   Null" + Environment.NewLine
                              + "-----------------------------" + Environment.NewLine;
                    _ciclosOcio++;
                }

                if (_numMayorCiclos < listaProcesos.Count)
                {
                    _numMayorCiclos = listaProcesos.Count;
                    _EnQueCiclo = i;
                }
            }
        }
    }
}
