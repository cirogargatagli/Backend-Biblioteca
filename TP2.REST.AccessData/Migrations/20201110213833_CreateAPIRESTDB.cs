using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TP2.REST.AccessData.Migrations
{
    public partial class CreateAPIRESTDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    ClienteId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DNI = table.Column<string>(type: "varchar(10)", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(45)", nullable: false),
                    Apellido = table.Column<string>(type: "varchar(45)", nullable: false),
                    Email = table.Column<string>(type: "varchar(45)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.ClienteId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoAlquiler",
                columns: table => new
                {
                    EstadoAlquilerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "varchar(45)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoAlquiler", x => x.EstadoAlquilerId);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "varchar(50)", nullable: false),
                    Titulo = table.Column<string>(type: "varchar(45)", nullable: false),
                    Autor = table.Column<string>(type: "varchar(45)", nullable: false),
                    Editorial = table.Column<string>(type: "varchar(45)", nullable: false),
                    Edicion = table.Column<string>(type: "varchar(45)", nullable: false),
                    Genero = table.Column<string>(type: "varchar(45)", nullable: false),
                    Sinopsis = table.Column<string>(type: "varchar(500)", nullable: false),
                    Stock = table.Column<int>(nullable: false),
                    Imagen = table.Column<string>(type: "varchar(110)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Alquiler",
                columns: table => new
                {
                    AlquilerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteID = table.Column<int>(nullable: false),
                    ISBN = table.Column<string>(type: "varchar(50)", nullable: false),
                    EstadoID = table.Column<int>(nullable: false),
                    FechaAlquiler = table.Column<DateTime>(nullable: true),
                    FechaReserva = table.Column<DateTime>(nullable: true),
                    FechaDevolucion = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Alquiler", x => x.AlquilerId);
                    table.ForeignKey(
                        name: "FK_Alquiler_Cliente_ClienteID",
                        column: x => x.ClienteID,
                        principalTable: "Cliente",
                        principalColumn: "ClienteId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_EstadoAlquiler_EstadoID",
                        column: x => x.EstadoID,
                        principalTable: "EstadoAlquiler",
                        principalColumn: "EstadoAlquilerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Alquiler_Libro_ISBN",
                        column: x => x.ISBN,
                        principalTable: "Libro",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Cliente",
                columns: new[] { "ClienteId", "Apellido", "DNI", "Email", "Nombre" },
                values: new object[] { 1, "Gargatagli", "40394722", "ciroshaila@gmail.com", "Ciro" });

            migrationBuilder.InsertData(
                table: "EstadoAlquiler",
                columns: new[] { "EstadoAlquilerId", "Descripcion" },
                values: new object[,]
                {
                    { 1, "Reservado" },
                    { 2, "Alquilado" },
                    { 3, "Cancelado" }
                });

            migrationBuilder.InsertData(
                table: "Libro",
                columns: new[] { "ISBN", "Autor", "Edicion", "Editorial", "Genero", "Imagen", "Sinopsis", "Stock", "Titulo" },
                values: new object[,]
                {
                    { "8478884459", "J.K. Rowling", "1997", "Salamandra", "Fantasía", "https://images.cdn2.buscalibre.com/fit-in/360x360/a2/9e/a29ebbd39810f964999f2a9f5f773af8.jpg", "El día de su cumpleaños, Harry Potter descubre que es hijo de dos conocidos hechiceros, de los que ha heredado poderes mágicos. Debe asistir a una famosa escuela de magia y hechicería, donde entabla una amistad con dos jóvenes que se convertirán en sus compañeros de aventura. Durante su primer año en Hogwarts, descubre que un malévolo y poderoso mago llamado Voldemort está en busca de una piedra filosofal que alarga la vida de quien la posee.", 10, "Harry Potter y la piedra filosofal" },
                    { "6071121639", "Stephen Chbosky", "2013", "Alfaguara", "Novela", "https://images-na.ssl-images-amazon.com/images/I/514XOeteoRL._SX319_BO1,204,203,200_.jpg", "La novela trata sobre un año en la vida de Charlie, desde sus 15 hasta sus 16 años. El joven, retraido y antisocial, ve cambiar su vida cuando conoce a Sam y Patrick, que van a ser muy importantes en su adaptación al mundo de la High School (Escuela Secundaria). Esta escrita en primera persona, a modo de diario.", 7, "Las ventajas de ser invisible" },
                    { "9789876295116", "Eduardo Galeano", "2014", "SIGLO XXI EDITORES", "Literatura Latinoamericana", "https://contentv2.tap-commerce.com/cover/large/9789876295116_1.jpg?id_com=1113", "Las venas abiertas de América Latina, es un ensayo periodístico del escritor uruguayo Eduardo Galeano, contiene crónicas y narraciones que dan pruebas del constante saqueo de recursos naturales que sufrió el continente latinoamericano a lo largo de su historia a manos de naciones colonialistas, del siglo XV al siglo XIX, e imperialistas, del siglo XX en adelante.", 9, "Las Venas Abiertas De America Latina" },
                    { "9788416709823", "Joe Padilla", "2017", "RESERVOIR BOOKS", "Biografía", "https://www.isadoralibros.com.uy/sitio/repo/img/9788417125011.jpg", "Los Ramones explicados a tus hijos. La increíble historia de cuatro amigos que se convirtieron en leyendas del punk rock.Si hay una historia universal de superación esa es la de los Ramones.Y sirve y gusta a todo el mundo.Cuatro inadaptados de Queens,con serios problemas cognitivos,mentales y sociales,lograron el éxito sin saber apenas tocar un instrumento. ¿Su secreto ? El amor por la música y la cultura de serie B", 15, "Ramones" },
                    { "9789872813635", "Sebastián Duarte", "2016", "Sebastián Duarte, Sr", "Biografía", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTuZGW7GD3BU0e-JZs2CocWnq28bBt3qS8Rtw&usqp=CAU", "Biografía documentada sobre el emblemático cantante de punk rock y su paso por Flema.", 10, "Ricky de Flema, El último Punk" },
                    { "9789874109019", "Roberto Arlt", "2016", "EDITORIAL BARENHAUS", "Novela", "https://image.isu.pub/181210203225-bdf0823d1bf285c49563674ba22812f3/jpg/page_1.jpg", "Silvio Astier forma el Club de los Caballeros de Media Noche con los que realiza pequeños hurtos para escapar de su entorno social. ... Silvio Astier, el protagonista de esta novela, es inteligente, de opiniones agudas y culto, pero vive en un entorno social pobre y limitado.", 6, "El Juguete Rabioso" },
                    { "9788491053538", "Piotr Kropotkin", "2017", "PENGUIN CLASICOS", "Novela", "https://images-na.ssl-images-amazon.com/images/I/31XJ19CQG1L._SX311_BO1,204,203,200_.jpg", "Este aristócrata de cuna perseguido por el régimen zarista ofrece un retrato terrible y desolador de los años convulsos previos a las revoluciones de 1905 y 1917, en los que la vida en el palacio de Invierno contrastaba con la situación atroz de los campesinos.", 13, "La conquista del pan" },
                    { "9788491053543", "Jorge Luis Borges", "2018", "Debolsillo", "Literatura Latinoamericana", "https://images.cdn1.buscalibre.com/fit-in/360x360/fd/af/fdafb136b6266281c67c860626a8490d.jpg", "El Aleph es un cuento del escritor argentino Jorge Luis Borges publicado en la revista Sur en 1945 y en el libro homónimo por la editorial Emecé de Buenos Aires en 1949 Argentina. El original se encuentra en la Biblioteca Nacional de España, que lo adquirió por subasta en 1985.", 6, "El Aleph" },
                    { "9732401053543", "J. R. R. Tolkien", "2019", "Minotauro", "Novela", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9788/4450/9788445007709.jpg", "En la adormecida e idílica Comarca, un joven hobbit recibe un encargo: custodiar el Anillo Único y emprender el viaje para su destrucción en las Grietas del Destino. Consciente de la importancia de su misión, Frodo abandona la Comarca e inicia el camino hacia Mordor con la compañía inesperada de Sam, Pippin y Merry. Pero sólo con la ayuda de Aragorn conseguirán vencer a los Jinetes Negros y alcanzar el refugio de la Casa de Elrond en Rivendel.", 13, "El señor de los anillos" },
                    { "9732401053555", "Julio Cortazar", "2018", "Debolsillo", "Novela", "https://d1w7fb2mkkr3kw.cloudfront.net/assets/images/book/lrg/9788/4663/9788466331906.jpg", "La obra maestra de Julio Cortázar. Una novela que conmocionó el panorama cultural de su tiempo y marcó un hito insoslayable dentro de la narrativa contemporánea.", 5, "Rayuela" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_ClienteID",
                table: "Alquiler",
                column: "ClienteID");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_EstadoID",
                table: "Alquiler",
                column: "EstadoID");

            migrationBuilder.CreateIndex(
                name: "IX_Alquiler_ISBN",
                table: "Alquiler",
                column: "ISBN");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Alquiler");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "EstadoAlquiler");

            migrationBuilder.DropTable(
                name: "Libro");
        }
    }
}
