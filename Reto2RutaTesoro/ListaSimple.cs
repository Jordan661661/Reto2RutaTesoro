using edSimpleLinkedList;
using System;
using System.Collections.Generic;

namespace Reto2RutaTesoro
{
   
    public class ListaSimple
    {
        // Único puntero real de la estructura: el inicio de la ruta.
        private Node inicio;

        public bool EstaVacia => inicio == null;

        /// <summary>
        /// Inserta un nuevo nodo al final de la lista (al final de la ruta).
        /// </summary>
        public void Insertar(int id, string nombre, string pista, int nivelPeligro)
        {
            if (Buscar(id) != null)
                throw new InvalidOperationException($"Ya existe una ubicación con ID {id}.");

            Node nuevo = new Node(id, nombre, pista, nivelPeligro);

            if (inicio == null)
            {
                inicio = nuevo;
                return;
            }

            Node actual = inicio;
            while (actual.Next != null)
            {
                actual = actual.Next;
            }
            actual.Next = nuevo;
        }

        /// <summary>
        /// Busca un nodo por su ID recorriendo la lista desde Inicio.
        /// Devuelve null si no existe.
        /// </summary>
        public Node Buscar(int id)
        {
            Node actual = inicio;
            while (actual != null)
            {
                if (actual.Id == id)
                    return actual;
                actual = actual.Next;
            }
            return null;
        }

        /// <summary>
        /// Modifica los datos de un nodo existente, identificado por ID.
        /// </summary>
        public bool Modificar(int id, string nombre, string pista, int nivelPeligro)
        {
            Node nodo = Buscar(id);
            if (nodo == null)
                return false;

            nodo.Nombre = nombre;
            nodo.Pista = pista;
            nodo.NivelPeligro = nivelPeligro;
            return true;
        }

        /// <summary>
        /// Elimina el nodo con el ID indicado, reconectando los punteros
        /// del nodo anterior y el siguiente.
        /// </summary>
        public bool Eliminar(int id)
        {
            if (inicio == null)
                return false;

            // Caso especial: el nodo a eliminar es el primero.
            if (inicio.Id == id)
            {
                inicio = inicio.Next;
                return true;
            }

            Node anterior = inicio;
            Node actual = inicio.Next;

            while (actual != null)
            {
                if (actual.Id == id)
                {
                    anterior.Next = actual.Next;
                    return true;
                }
                anterior = actual;
                actual = actual.Next;
            }

            return false; // No se encontró el ID.
        }

        /// <summary>
        /// Recorre la lista desde Inicio hasta NULL y devuelve los nodos
        /// en una colección temporal, únicamente para fines de visualización
        /// (por ejemplo, refrescar el DataGridView). La lista enlazada real
        /// sigue siendo la única fuente de almacenamiento de los datos.
        /// </summary>
        public IEnumerable<Node> Recorrer()
        {
            List<Node> resultado = new List<Node>();
            Node actual = inicio;
            while (actual != null)
            {
                resultado.Add(actual);
                actual = actual.Next;
            }
            return resultado;
        }

        /// <summary>
        /// Cantidad de nodos actualmente en la ruta.
        /// </summary>
        public int Contar()
        {
            int contador = 0;
            Node actual = inicio;
            while (actual != null)
            {
                contador++;
                actual = actual.Next;
            }
            return contador;
        }
    }
}