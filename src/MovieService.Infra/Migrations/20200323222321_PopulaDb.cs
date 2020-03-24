using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieService.Infra.Migrations
{
    public partial class PopulaDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(
                @"insert into Movie values (
                    newid(), 
                    'Aves de Rapina - Arlequina e sua Emacipação Fantabulosa', 
                    '01:49:00', 
                    5, 
                    1, 
                    2, 
                    'Warner', 
                    'Cathy Yan', 
                    'Margot Robbie, Mary Elizabeth Winstead, Jurnee Smollett-Bell', 
                    'Arlequina (Margot Robbie), Canário Negro (Jurnee Smollett), Caçadora (Mary Elizabeth Winstead), Cassandra Cain e a policial Renée Montoya (Rosie Perez) formam um grupo inusitado de heroínas. Quando um perigoso criminoso começa a causar destruição em Gotham, as cinco mulheres precisam se unir para defender a cidade.', 
                    'https://www.youtube.com/embed/M2LMRXkAZSY', 
                    'https://br.web.img2.acsta.net/c_215_290/pictures/19/09/17/19/29/5316438.jpg', 
                    'https://br.web.img3.acsta.net/r_1920_1080/pictures/19/12/18/16/46/0174996.jpg', 
                    '2020-02-06')");

            migrationBuilder.Sql(
                @"insert into Movie values (
                    newid(), 
                    'O Chamado da Floresta', 
                    '01:40:00', 
                    3, 
                    2, 
                    2, 
                    'Disney', 
                    'Chris Sanders', 
                    'Harrison Ford, Omar Sy, Dan Stevens', 
                    'Depois de anos vivendo como um cachorro de estimação na casa de uma família na Califórnia, Buck precisa entrar em contato com os seus instintos mais selvagens para conseguir sobreviver em um ambiente hostil como o Alaska. Com o tempo, seu lado feroz se desenvolve e ele se torna o grande líder de sua matilha. Baseado no livro homônimo de Jack London, lançado em 1903.', 
                    'https://www.youtube.com/embed/3kMHTbr5g68', 
                    'https://br.web.img3.acsta.net/c_215_290/pictures/19/11/21/07/27/5498230.jpg', 
                    'https://br.web.img3.acsta.net/r_1920_1080/pictures/19/11/20/16/02/5660491.jpg', 
                    '2020-02-20')");

            migrationBuilder.Sql(
                @"insert into Movie values (
                    newid(), 
                    'Sonic - O Filme', 
                    '01:40:00', 
                    1, 
                    2, 
                    2, 
                    'Paramount', 
                    'Jeff Fowler', 
                    'Jim Carrey, James Marsden, Tika Sumpter', 
                    'Sonic, o porco-espinho azul mais famoso do mundo, se junta com os seus amigos para derrotar o terrível Doutor Eggman, um cientista louco que planeja dominar o mundo, e o Doutor Robotnik, responsável por aprisionar animais inocentes em robôs. A sinopse oficial ainda não foi divulgada.', 
                    'https://www.youtube.com/embed/zQEjE_M2Esw', 
                    'https://br.web.img2.acsta.net/c_215_290/pictures/19/11/12/13/02/4217574.jpg', 
                    'https://br.web.img2.acsta.net/r_1920_1080/pictures/20/01/23/09/08/4712919.jpg', 
                    '2020-02-13')");

            migrationBuilder.Sql(
                @"insert into Movie values (
                    newid(), 
                    'A Família Addams', 
                    '01:17:00', 
                    1, 
                    3, 
                    1, 
                    'Universal',
                    'Conrad Vernon, Greg Tiernan', 
                    'Na versão original com as vozes de: Charlize Theron, Oscar Isaac, Chloë Grace Moretz', 
                    'Prepare-se para estalar os dedos! A Família Addams está de volta às telonas na primeira animação de comédia sobre o clã mais excêntrico do pedaço. Engraçada, estranha e completamente icônica, a Família Addams redefine o que significa ser um bom vizinho. Classificação indicativa livre, contém violência fantasiosa.', 
                    'https://www.youtube.com/embed/qhBqWdJ-g3w', 
                    'https://br.web.img3.acsta.net/c_215_290/pictures/19/08/07/23/04/5933410.jpg', 
                    'https://br.web.img3.acsta.net/r_1920_1080/pictures/19/08/07/15/51/4328630.jpg', 
                    '2019-10-31')");

            migrationBuilder.Sql(
            @"insert into Movie values (
                newid(), 
                'Dora e A Cidade Perdida', 
                '01:02:00', 
                2, 
                2, 
                1, 
                'Paramount',
                'James Bobin', 
                'Isabela Moner, Eugenio Derbez, Adriana Barraza', 
                'As aventuras de Dora (Isabela Moner) junto com o seu macaco Botas e a sua mochila falante. Os anos se passaram e novas responsabilidades surgiram na vida de Dora, agora ela frequenta a escola e mora na cidade junto com o seu primo Diego (Micke Moreno). No entanto, ela precisará embarcar em uma nova aventura para salvar seus pais e resolver o mistério de uma antiga civilização perdida. Classificação indicativa 10 anos, contém violência.', 
                'https://www.youtube.com/embed/i6AjfTxNOd4', 
                'https://br.web.img3.acsta.net/c_215_290/pictures/19/07/11/20/16/2463436.jpg', 
                'https://br.web.img3.acsta.net/r_1920_1080/pictures/19/08/02/12/24/1241895.jpg', 
                '2019-11-14')");

            migrationBuilder.Sql(
                @"insert into Movie values (
                    newid(), 
                    'Maria do Caritó', 
                    '01:35:00', 
                    3, 
                    6, 
                    2, 
                    'Imagem Filmes',
                    'João Paulo Jabur', 
                    'Lilia Cabral, Leopoldo Pacheco, Juliana Carneiro da Cunha, Larissa Bracher, Alice Assef, Kelzy Ecard, Fernando Sampaio, Priscila Steinman, Gustavo Vaz, Sylvio Zilber', 
                    'Cansada da vida solitária que leva, Maria (Lilia Cabral) sonha em encontrar um verdadeiro amor. Prometida pelo pai para ser entregue virgem a São Djalminha, um santo de quem ninguém nunca ouviu falar, só mesmo um milagre poderia ajudar. A única certeza que Maria tem é que, custe o que custar, ela precisa desencalhar e sair de uma vez desse Caritó. Classificação indicativa 12 anos, contém violência e conteúdo sexual.', 
                    'https://www.youtube.com/embed/MxSGO6fuJps', 
                    'http://br.web.img2.acsta.net/c_215_290/pictures/19/06/13/17/11/5965947.jpg', 
                    'http://br.web.img3.acsta.net/r_1920_1080/pictures/18/10/03/19/13/1610196.jpg', 
                    '2019-10-31')");

            migrationBuilder.Sql(
                @"insert into Movie values (
                    newid(), 
                    'Invasão ao Serviço Secreto', 
                    '02:00:00', 
                    4, 
                    1, 
                    2, 
                    'Imagem Filmes',
                    'Ric Roman Waugh', 
                    'Gerard Butler, Holt McCallany, Morgan Freeman', 
                    'Após uma tentativa de assassinato ao presidente dos Estados Unidos (Morgan Freeman), o agente do Serviço Secreto, Mike Banning (Gerard Butler), é injustamente acusado e levado sob custódia. Determinado a provar sua inocência, ele se torna um alvo do FBI à medida em que tenta encontrar o verdadeiro culpado. Ele vai precisar de toda a ajuda possível para proteger sua família e salvar seu país de um ataque sem precedentes. Classificação indicativa 14 anos, contém drogas lícitas, linguagem imprópria, violência.', 
                    'https://www.youtube.com/embed/MewNCnQ0PC0', 
                    'https://br.web.img3.acsta.net/c_215_290/pictures/19/06/12/14/10/0645123.jpg', 
                    'https://br.web.img3.acsta.net/r_1920_1080/pictures/19/06/18/14/37/5159081.jpg', 
                    '2019-11-14')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete Movie");
        }
    }
}
