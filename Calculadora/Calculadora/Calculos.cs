using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Calculos
    {

        private string _Cadena;
        private double _Resultado;
        private bool _Suma;
        private bool _Resta;
        private bool _Multiplicacion;
        private bool _Division;

        public Calculos()
        {
            _Cadena = "";

        }
        private void apagabanderas() 
        {
            _Suma = false;
            _Resta = false;
            _Multiplicacion = false;
            _Division = false;
        }

        public string concatenar(string cadena) 
        {
            _Cadena += cadena;
            return _Cadena;
        }

        public void suma(string cadena) 
        {
            _Resultado = Convert.ToDouble(cadena);
            _Suma = true;
            _Cadena = "";
        }

        public void resta(string cadena)
        {
            _Resultado = Convert.ToDouble(cadena);
            _Resta = true;
            _Cadena = "";
        }
        public void multiplicacion(string cadena)
        {
            _Resultado = Convert.ToDouble(cadena);
            _Multiplicacion= true;
            _Cadena = "";
        }
        public void division(string cadena)
        {
            _Resultado = Convert.ToDouble(cadena);
            _Division = true;
            _Cadena = "";
        }


        public double resultado(string numero) 
        {
            if (_Suma) 
            {
                _Resultado += Convert.ToDouble(numero);
            }
            else if (_Resta)
            {
                _Resultado -= Convert.ToDouble(numero);
            }
            else if (_Multiplicacion)
            {
                _Resultado *= Convert.ToDouble(numero);
            }
            else if(_Division)
            {
                _Resultado /= Convert.ToDouble(numero);
            }
            apagabanderas();
            return _Resultado;
        
        }

        public void clear() 
        {
            _Resultado = 0;
            _Cadena = "";
            apagabanderas();
        }

        

    }
}
