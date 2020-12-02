using Microsoft.EntityFrameworkCore;
using TP2.REST.Domain.Entities;

namespace TP2.REST.AccessData
{
    public class BibliotecaContext : DbContext
    {
        private DbSet<Cliente> cliente;
        private DbSet<Libro> libro;
        private DbSet<Alquiler> alquiler;
        private DbSet<EstadoAlquiler> estadoAlquiler;

        public DbSet<Cliente> Cliente { get => cliente; set => cliente = value; }
        public DbSet<Libro> Libro { get => libro; set => libro = value; }
        public DbSet<Alquiler> Alquiler { get => alquiler; set => alquiler = value; }
        public DbSet<EstadoAlquiler> EstadoAlquiler { get => estadoAlquiler; set => estadoAlquiler = value; }

        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Cargo libros a la tabla Libro
            modelBuilder.Entity<Libro>(entity =>
            {
                entity.ToTable("Libro");
                entity.HasData(new Libro
                {
                    ISBN = "8478884459",
                    Titulo = "Harry Potter y la piedra filosofal",
                    Autor = "J.K. Rowling",
                    Editorial = "Salamandra",
                    Edicion = "1997",
                    Genero = "Fantasía",
                    Sinopsis = "El día de su cumpleaños, Harry Potter descubre que es hijo de dos conocidos hechiceros, de los que ha heredado poderes mágicos. Debe asistir a una famosa escuela de magia y hechicería, donde entabla una amistad con dos jóvenes que se convertirán en sus compañeros de aventura. Durante su primer año en Hogwarts, descubre que un malévolo y poderoso mago llamado Voldemort está en busca de una piedra filosofal que alarga la vida de quien la posee.",
                    Stock = 10,
                    Imagen = "https://images.cdn2.buscalibre.com/fit-in/360x360/a2/9e/a29ebbd39810f964999f2a9f5f773af8.jpg"
                });
                entity.HasData(new Libro
                {
                    ISBN = "6071121639",
                    Titulo = "Las ventajas de ser invisible",
                    Autor = "Stephen Chbosky",
                    Editorial = "Alfaguara",
                    Edicion = "2013",
                    Genero = "Novela",
                    Sinopsis = "La novela trata sobre un año en la vida de Charlie, desde sus 15 hasta sus 16 años. El joven, retraido y antisocial, ve cambiar su vida cuando conoce a Sam y Patrick, que van a ser muy importantes en su adaptación al mundo de la High School (Escuela Secundaria). Esta escrita en primera persona, a modo de diario.",
                    Stock = 7,
                    Imagen = "https://images-na.ssl-images-amazon.com/images/I/514XOeteoRL._SX319_BO1,204,203,200_.jpg"
                });
                entity.HasData(new Libro
                {
                    ISBN = "9789876295116",
                    Titulo = "Las Venas Abiertas De America Latina",
                    Autor = "Eduardo Galeano",
                    Editorial = "SIGLO XXI EDITORES",
                    Edicion = "2014",
                    Genero = "Literatura Latinoamericana",
                    Sinopsis = "Las venas abiertas de América Latina, es un ensayo periodístico del escritor uruguayo Eduardo Galeano, contiene crónicas y narraciones que dan pruebas del constante saqueo de recursos naturales que sufrió el continente latinoamericano a lo largo de su historia a manos de naciones colonialistas, del siglo XV al siglo XIX, e imperialistas, del siglo XX en adelante.",
                    Stock = 9,
                    Imagen = "https://contentv2.tap-commerce.com/cover/large/9789876295116_1.jpg?id_com=1113"
                });
                entity.HasData(new Libro
                {
                    ISBN = "9788416709823",
                    Titulo = "Ramones",
                    Autor = "Joe Padilla",
                    Editorial = "RESERVOIR BOOKS",
                    Edicion = "2017",
                    Genero = "Biografía",
                    Sinopsis = "Los Ramones explicados a tus hijos. La increíble historia de cuatro amigos que se convirtieron en leyendas del punk rock.Si hay una historia universal de superación esa es la de los Ramones.Y sirve y gusta a todo el mundo.Cuatro inadaptados de Queens,con serios problemas cognitivos,mentales y sociales,lograron el éxito sin saber apenas tocar un instrumento. ¿Su secreto ? El amor por la música y la cultura de serie B",
                    Stock = 15,
                    Imagen = "https://www.isadoralibros.com.uy/sitio/repo/img/9788417125011.jpg"
                });
                entity.HasData(new Libro
                {
                    ISBN = "9789872813635",
                    Titulo = "Ricky de Flema, El último Punk",
                    Autor = "Sebastián Duarte",
                    Editorial = "Sebastián Duarte, Sr",
                    Edicion = "2016",
                    Genero = "Biografía",
                    Sinopsis = "Biografía documentada sobre el emblemático cantante de punk rock y su paso por Flema.",
                    Stock = 10,
                    Imagen = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTuZGW7GD3BU0e-JZs2CocWnq28bBt3qS8Rtw&usqp=CAU"
                });
                entity.HasData(new Libro
                {
                    ISBN = "9789874109019",
                    Titulo = "El Juguete Rabioso",
                    Autor = "Roberto Arlt",
                    Editorial = "EDITORIAL BARENHAUS",
                    Edicion = "2016",
                    Genero = "Novela",
                    Sinopsis = "Silvio Astier forma el Club de los Caballeros de Media Noche con los que realiza pequeños hurtos para escapar de su entorno social. ... Silvio Astier, el protagonista de esta novela, es inteligente, de opiniones agudas y culto, pero vive en un entorno social pobre y limitado.",
                    Stock = 6,
                    Imagen = "https://image.isu.pub/181210203225-bdf0823d1bf285c49563674ba22812f3/jpg/page_1.jpg"
                });
                entity.HasData(new Libro
                {
                    ISBN = "9788491053538",
                    Titulo = "La conquista del pan",
                    Autor = "Piotr Kropotkin",
                    Editorial = "PENGUIN CLASICOS",
                    Edicion = "2017",
                    Genero = "Novela",
                    Sinopsis = "Este aristócrata de cuna perseguido por el régimen zarista ofrece un retrato terrible y desolador de los años convulsos previos a las revoluciones de 1905 y 1917, en los que la vida en el palacio de Invierno contrastaba con la situación atroz de los campesinos.",
                    Stock = 13,
                    Imagen = "https://images-na.ssl-images-amazon.com/images/I/31XJ19CQG1L._SX311_BO1,204,203,200_.jpg"
                });
                entity.HasData(new Libro
                {
                    ISBN = "9788491053543",
                    Titulo = "El Aleph",
                    Autor = "Jorge Luis Borges",
                    Editorial = "Debolsillo",
                    Edicion = "2018",
                    Genero = "Literatura Latinoamericana",
                    Sinopsis = "El Aleph es un cuento del escritor argentino Jorge Luis Borges publicado en la revista Sur en 1945 y en el libro homónimo por la editorial Emecé de Buenos Aires en 1949 Argentina. El original se encuentra en la Biblioteca Nacional de España, que lo adquirió por subasta en 1985.",
                    Stock = 6,
                    Imagen = "https://images.cdn1.buscalibre.com/fit-in/360x360/fd/af/fdafb136b6266281c67c860626a8490d.jpg"
                });
                entity.HasData(new Libro
                {
                    ISBN = "9732401053543",
                    Titulo = "El señor de los anillos",
                    Autor = "J. R. R. Tolkien",
                    Editorial = "Minotauro",
                    Edicion = "2019",
                    Genero = "Novela",
                    Sinopsis = "En la adormecida e idílica Comarca, un joven hobbit recibe un encargo: custodiar el Anillo Único y emprender el viaje para su destrucción en las Grietas del Destino. Consciente de la importancia de su misión, Frodo abandona la Comarca e inicia el camino hacia Mordor con la compañía inesperada de Sam, Pippin y Merry. Pero sólo con la ayuda de Aragorn conseguirán vencer a los Jinetes Negros y alcanzar el refugio de la Casa de Elrond en Rivendel.",
                    Stock = 13,
                    Imagen = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9788/4450/9788445007709.jpg"
                });
                entity.HasData(new Libro
                {
                    ISBN = "9732401053555",
                    Titulo = "Rayuela",
                    Autor = "Julio Cortazar",
                    Editorial = "Debolsillo",
                    Edicion = "2018",
                    Genero = "Novela",
                    Sinopsis = "La obra maestra de Julio Cortázar. Una novela que conmocionó el panorama cultural de su tiempo y marcó un hito insoslayable dentro de la narrativa contemporánea.",
                    Stock = 5,
                    Imagen = "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9788/4663/9788466331906.jpg"
                });
            });

            //Cargo estados a tabla EstadoAlquiler
            modelBuilder.Entity<EstadoAlquiler>(entity =>
            {
                entity.ToTable("EstadoAlquiler");
                entity.HasData(new EstadoAlquiler { EstadoAlquilerId = 1, Descripcion = "Reservado" });
                entity.HasData(new EstadoAlquiler { EstadoAlquilerId = 2, Descripcion = "Alquilado" });
                entity.HasData(new EstadoAlquiler { EstadoAlquilerId = 3, Descripcion = "Cancelado" });
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Cliente");
                entity.HasData(new Cliente
                {
                    ClienteId = 1,
                    Nombre = "Ciro",
                    Apellido = "Gargatagli",
                    DNI = "40394722",
                    Email = "ciroshaila@gmail.com"
                });
            });
        }
    }
}