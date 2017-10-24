# XamarinAlbums
A simple app in Xamarin Forms to get images from a remote server

Foi Criado um simples app utilizando o Pattern MVVM
Os dados foram otidos do serviço RESt: https://jsonplaceholder.typicode.com/photos/ 
Pensando num possível crescimento do app, onde poderão haver mais serviços remotos, foi criada a Pasta Services e nesta, a PhotoRepository.
O Servidor Rest retorna apenas uma lista de "Photos", onde apenas contém o ID do Album.
Para Separar os Albums doi utilizado um Dicionário, atribuindo para cada Id, uma lista de Photos.
Para a View que lista os Albuns, foi utilizada uma ListView, apresentando a imagem da primeira foto de cada album e seu ID;
Quando um ítem é selecionado, é Chamada a tela do Album selecionado, passando como parâmetro, a lista de imagens, préviamente separada.
Na tela de Photos, é apresentada uma ListView, apresentando a miniatura de cada foto, juntamente com a sua descrição.
Quando alguma foto pe selecionada, é apresentada outra tela com a imagem em tamanho real.
Os títulos das telas, que exibiam conteúdo diferente, eram atualizados conforme o conteúdo.
## Fiz testes com WrapContent para a exibição das fotos do album em formato de grade dinâmica, este apresentava os dados corretamente
## Não encontrei na documentação do WrapContent como fazer para selecionar um item ( para que eu pudesse apresetar a foto), então acabei mudando a estratégia.

Buscando um menor acoplamento, as chamadas das telas doram feitas pelo MessaginCenter do Xamarin, e as chamadas foram feitas através de Binding pelo XAML

Foi implantada uma MasterDetailView, porém faltou um pouco de ideias de o que colocar nela.

Havendo mais tempo, faria a tela de splash e um serviço de cash local utilizando o sqlite e os diretorios para salvar as imagens localmente.

