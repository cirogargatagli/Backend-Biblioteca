using System.Collections.Generic;
using TP2.REST.Domain.DTO;

namespace TP2.REST.Domain.Interfaces.Services
{
    public interface IAlquilerService
    {
        GenericCreatedResponseDTO CreateAlquiler(AlquilerDTO alquiler);
        List<ResponseGetAlquilerByEstadoId> GetByEstadoID(int estadoid);
        void ModifyReserva(ResponseModifyDTO responseModify);
        List<ResponseGetLibrosByCliente> GetLibroByCliente(int idcliente);
        ResponseBadRequest ValidarAlquiler(AlquilerDTO alquilerDTO);
        ResponseBadRequest ValidarModifyReserva(ResponseModifyDTO responseModify);
    }
}
