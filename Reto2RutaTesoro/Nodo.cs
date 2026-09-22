using System;

namespace edSimpleLinkedList
{
    // Nodo ajustado para la lógica de ListaSimple
    public class Node
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Pista { get; set; } = string.Empty;
        public int NivelPeligro { get; set; }
        public Node? Next { get; set; }

        public Node()
        {
            Id = 0;
            Nombre = string.Empty;
            Pista = string.Empty;
            NivelPeligro = 1;
            Next = null;
        }

        // Constructor compatible con ListaSimple.Insertar
        public Node(int id, string nombre, string pista, int nivelPeligro, Node? next = null)
        {
            Id = id;
            Nombre = nombre;
            Pista = pista;
            NivelPeligro = nivelPeligro;
            Next = next;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nombre: {Nombre}, Pista: {Pista}, NivelPeligro: {NivelPeligro}";
        }
    }
}
