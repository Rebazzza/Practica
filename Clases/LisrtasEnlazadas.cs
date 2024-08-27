using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class LisrtasEnlazadas
    {
        Nodo primero = new Nodo();
        public void insertar(int num)
        {

            Nodo nuevo = new Nodo();
            nuevo.dato = num;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temp = primero;
                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public void mostrar()
        {
            Nodo temp = primero;
            while (temp != null)
            {
                Console.Write(temp.dato);
                if (temp.sig != null)
                {
                    Console.Write("->");
                }
                temp = temp.sig;
            }
        }
        public bool buscar(int bus)
        {
            Nodo temp = primero;
            bool val = false;
            int cont = 0;
            while (temp != null)
            {
                if (temp.dato == bus)
                {

                    cont++;
                    val = true;
                }
                temp = temp.sig;
            }
            if (cont == 0)
            {
                Console.WriteLine("Elemento no encontrado");
                val = false;
            }
            return val;

        }
        public void actualizar(int busc, int nuevo)
        {
            Nodo temp = primero;
            int cont = 0;
            while (temp != null)
            {
                if (temp.dato == busc)
                {
                    temp.dato = nuevo;
                    cont++;

                }
                temp = temp.sig;
            }
        }
        public void eliminar(int el)
        {
            Nodo temp = primero;
            Nodo anterior = null;
            while (temp != null)
            {
                if (primero.dato == el)
                {
                    primero = primero.sig;
                } else if (temp.dato == el)
                {
                    anterior.sig = temp.sig;
                }

                anterior = temp;
                temp = temp.sig;
            }
        }
        public void Ord_Asc()
        {
            Nodo temp = primero;
            
            while (temp != null)
            {
                Nodo temp2 = primero;
                while (temp2.sig != null)
                {
                    if (temp2.dato > temp2.sig.dato)
                    {
                        int aux = temp2.dato;
                        temp2.dato = temp2.sig.dato;
                        temp2.sig.dato = aux;
                    }
                    temp2 = temp2.sig;
                }
                temp = temp.sig;
            }
        }
        public void Ord_Desc()
        {

            Nodo temp = primero;

            while (temp != null)
            {
                Nodo temp2 = primero;
                while (temp2.sig != null)
                {
                    if (temp2.dato < temp2.sig.dato)
                    {
                        int aux = temp2.dato;
                        temp2.dato = temp2.sig.dato;
                        temp2.sig.dato = aux;
                    }
                    temp2 = temp2.sig;
                }
                temp = temp.sig;
            }

        }
    }
}
