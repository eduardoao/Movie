Links utilizados para criação desse estudo: 
https://www.tabnews.com.br/uriel/5c6dad5f-7c23-4174-a2e8-896021e9c323
https://shopee.com.br/blog/generos-de-filmes/
https://stackoverflow.com/questions/25436312/gitignore-not-working



1 - Filme > título, uma descrição e uma imagem de pôster 
2 - Usuário > 
3 - Cinema > Unidade física do evento 
4 - Cartaz > Para uma determinada unidade, o evento ocorrerá em um determinado prazo, horário, preço 
5 - Reserva > um usuário pode fazer a reserva 
6 - Ticket > Informação sobre a unidade, cartaz, usuário 
7 - Pagamento > A definir


Para autorização e autenticação, vou usar o keycloak
Comando para inciar o container

consulta de Informação
1 - https://www.youtube.com/watch?v=fvxQ8bW0vO8
2 - https://www.youtube.com/watch?v=Blrn5JyAl6E


docker run --name keycloak -p 8080:8080 -e KEYCLOAK_ADMIN=admin -e KEYCLOAK_ADMIN_PASSWORD=admin quay.io/keycloak/keycloak start-dev

Criar  um realms. Ex: eaotech
http://localhost:8081/realms/eaotech

Exemplo de integração de uma aplicação NetCore com o keycloak

https://nikiforovall.github.io/keycloak-authorization-services-dotnet/
https://medium.com/@luylucas10/asp-net-core-api-blazor-and-mvc-keycloak-part-1-74f5eb779dc2
https://github.com/luylucas10/aspnetcore-keycloak-examples

# https://www.youtube.com/watch?v=LphlwLonTwA
> autorização de usuários
# https://www.youtube.com/watch?v=lQREPSZsRc8



Na arquitetura hexagonal, um aggregate é uma coleção de objetos de valor e entidades. É uma forma de simplificar o modelo de domínio, tratando o todo como uma unidade coesa. 
A arquitetura hexagonal, também conhecida como "arquitetura porta e adaptador", é uma metodologia de desenvolvimento de software. Ela é orientada a objetos, onde as portas são as interfaces e os adapters são as implementações. 
