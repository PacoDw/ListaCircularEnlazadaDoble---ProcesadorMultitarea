using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtencionProcesos_ListaCircularEnlazada
{
    class ListaProcesos
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //PROPIEDADES DE LA CLASE
        private Proceso _inicio;
        public Proceso Inicio { get { return _inicio; } }

        private Proceso _ultimo;
        public Proceso Ultimo { get { return _ultimo; } }

        private int _count;
        public int Count { get { return _count; } }

        private int _ciclosPendientes;
        public int CiclosPendientes { get { return _ciclosPendientes; } }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //CONSTRUCTOR DE LA CLASE
        public ListaProcesos()
        {
            this._inicio = null;
            this._ultimo = null;
            this._count = 0;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO AGREGAR ELEMENTO POR PARAMETRO
        public void Agregar(Proceso nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                nuevo.Siguiente = _inicio;
                nuevo.Anterior = _inicio;
            }
            else
            {
                nuevo.Siguiente = _inicio;
                nuevo.Anterior = _ultimo;

                _ultimo.Siguiente = nuevo;
                _inicio.Anterior = nuevo;
            }
            _ultimo = nuevo;
            _count++;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ELIMINAR ELEMENTO POR PARAMETRO
        public void Eliminar(Proceso proceso)
        {
            Proceso temp = null;
            bool encontrado = false;

            if(_inicio != null)
            {
                if (proceso == _inicio)
                    EliminarPrimero();
                else if (proceso == _ultimo)
                    EliminarUltimo();
                else
                {
                    temp = _inicio.Siguiente;

                    while(temp != _inicio && encontrado != true && temp != null)
                    {
                        if(temp.Siguiente == proceso)
                        {
                            temp.Siguiente = proceso.Siguiente;
                            proceso.Siguiente.Anterior = temp;
                            encontrado = true;
                            _count--;
                        }
                        temp = temp.Siguiente;
                    }
                }
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ELIMINAR PRIMER ELEMENTO
        public void EliminarPrimero()
        {
            if(Inicio != null)
            {
                if (_inicio == _ultimo)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _ultimo.Siguiente = _inicio.Siguiente;
                    _inicio = Inicio.Siguiente;
                    _inicio.Anterior = _ultimo;
                }
                _count--;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ELIMINAR ULTIMO ELEMENTO
        public void EliminarUltimo()
        {
            if (Inicio != null)
            {
                if (_inicio == _ultimo)
                {
                    _inicio = null;
                    _ultimo = null;
                }
                else
                {
                    _inicio.Anterior = _ultimo.Anterior;
                    _ultimo = _ultimo.Anterior;
                    _ultimo.Siguiente = _inicio;
                }
                _count--;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ACTUAL - retorna el proceso que esta siendo atendido
        public Proceso Actual()
        {
            return _inicio;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO MOVERASIGUIENTE - es un temp = temp.siguiente pero en metodo
        public void moverAsiguiente()
        {
            _inicio = _inicio.Siguiente;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        //METODO ToString
        public override string ToString()
        {
            string cadena = string.Empty;
            _ciclosPendientes = 0;

            Proceso temp = _inicio;

            while(temp != _ultimo)
            {
                cadena += temp.ToString();
                _ciclosPendientes += temp.VidaRestante;

                temp = temp.Siguiente;
            }
            cadena += _ultimo.ToString();
            _ciclosPendientes += _ultimo.VidaRestante;

            return cadena;
        }
    }
}
