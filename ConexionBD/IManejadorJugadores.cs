using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConexionBD
{
    [ServiceContract(CallbackContract = typeof(IJugadorCallback))]
    public interface IManejadorJugadores
    {
        [OperationContract]
        void AgregarJugador(Jugador jugador);
        [OperationContract]
        void EliminarJugador(Jugador jugador);
        [OperationContract]
        void ModificarJugador(Jugador jugador, Jugador nuevoJugador);
        [OperationContract]
        void MostrarJugador(string nombreUsuario, string contraseña);
        [OperationContract]
        void BuscarJugador(string nombreUsuario, string contraseña);
    }
    [ServiceContract]
    public interface IJugadorCallback
    {
        [OperationContract]
        void RespuestaAgregarJugador(bool respuesta);
        [OperationContract]
        void RespuestaEliminarJugador(bool respuesta);
        [OperationContract]
        void RespuestaModificarJugador(bool respuesta);
        [OperationContract]
        void RespuestaMostrarJugador(Jugador respuesta);
        [OperationContract]
        void RespuestaBuscarJugador(bool respuesta);
    }
}
