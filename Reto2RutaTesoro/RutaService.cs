using System.Linq;
using System.Collections.Generic;

namespace Reto2RutaTesoro
{
    public class RutaService
    {
        private readonly ListaSimple _lista = new ListaSimple();

        public void Insertar(int id, string nombre, string pista, int nivelPeligro)
        {
            _lista.Insertar(id, nombre, pista, nivelPeligro);
        }

        public bool Modificar(int id, string nombre, string pista, int nivelPeligro)
        {
            return _lista.Modificar(id, nombre, pista, nivelPeligro);
        }

        public bool Eliminar(int id) => _lista.Eliminar(id);

        public IEnumerable<UbicacionDto> ListarParaUI()
        {
            return _lista.Recorrer().Select(n => new UbicacionDto
            {
                Id = n.Id,
                Nombre = n.Nombre,
                Pista = n.Pista,
                NivelPeligro = n.NivelPeligro
            });
        }

        public UbicacionDto? BuscarParaUI(int id)
        {
            var node = _lista.Buscar(id);
            if (node == null) return null;
            return new UbicacionDto
            {
                Id = node.Id,
                Nombre = node.Nombre,
                Pista = node.Pista,
                NivelPeligro = node.NivelPeligro
            };
        }

        public int Contar() => _lista.Contar();
    }
}
