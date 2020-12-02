namespace TP2.REST.Domain.DTO
{
    public class ResponseGetLibrosByCliente
    {
        public string AlquilerId { get; set; }
        public string FechaAlquiler { get; set; }

        public string FechaReserva { get; set; }

        public string FechaDevolucion { get; set; }

        public string ISBN { get; set; }

        public string Titulo { get; set; }

        public string Autor { get; set; }

        public string Editorial { get; set; }

        public string Edicion { get; set; }

        public string Genero { get; set; }

        public string Sinopsis { get; set; }

        public string Imagen { get; set; }

    }
}
