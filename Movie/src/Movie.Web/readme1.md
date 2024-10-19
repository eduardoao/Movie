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
http://localhost:8080/realms/eaotech

http://localhost:8080/admin
http://localhost:8080/admin/master/console/

Exemplo de integração de uma aplicação NetCore com o keycloak

https://nikiforovall.github.io/keycloak-authorization-services-dotnet/
https://medium.com/@luylucas10/asp-net-core-api-blazor-and-mvc-keycloak-part-1-74f5eb779dc2
https://github.com/luylucas10/aspnetcore-keycloak-examples


https://marraia.medium.com/utiliza%C3%A7%C3%A3o-do-keycloak-em-aplica%C3%A7%C3%B5es-net-6-0-4a787520c85b


Colection do postman com autenticação.

Em client Movie-api, habilitar authorization
Aba authorization, criar um resource, scope, policy [scope-based permission]

# Front e Back - Keycloak
React SPA frontend with WebAPI backend using Keycloak open source OIDC provider
https://www.youtube.com/watch?v=n-ia1hk3eUE


# esport real
https://www.youtube.com/watch?v=1u8GlfKyB_Q

# Customizer page login 
https://www.baeldung.com/keycloak-custom-login-page

# https://www.youtube.com/watch?v=LphlwLonTwA
> autorização de usuários
# https://www.youtube.com/watch?v=lQREPSZsRc8

# Keycloak - dockercompose com BD e arquivo .env 
https://medium.com/@disa2aka/docker-deployments-for-keycloak-and-postgresql-e75707b155e5#id_token=eyJhbGciOiJSUzI1NiIsImtpZCI6IjI4YTQyMWNhZmJlM2RkODg5MjcxZGY5MDBmNGJiZjE2ZGI1YzI0ZDQiLCJ0eXAiOiJKV1QifQ.eyJpc3MiOiJodHRwczovL2FjY291bnRzLmdvb2dsZS5jb20iLCJhenAiOiIyMTYyOTYwMzU4MzQtazFrNnFlMDYwczJ0cDJhMmphbTRsamRjbXMwMHN0dGcuYXBwcy5nb29nbGV1c2VyY29udGVudC5jb20iLCJhdWQiOiIyMTYyOTYwMzU4MzQtazFrNnFlMDYwczJ0cDJhMmphbTRsamRjbXMwMHN0dGcuYXBwcy5nb29nbGV1c2VyY29udGVudC5jb20iLCJzdWIiOiIxMDUxNTk0MDc2OTg1NDcwMzY5NjIiLCJlbWFpbCI6ImVvYWxjYW50YXJhQGdtYWlsLmNvbSIsImVtYWlsX3ZlcmlmaWVkIjp0cnVlLCJuYmYiOjE3Mjg0MTU3MTksIm5hbWUiOiJFZHVhcmRvIEFsY2FudGFyYSBkZSBPbGl2ZWlyYSIsImdpdmVuX25hbWUiOiJFZHVhcmRvIiwiZmFtaWx5X25hbWUiOiJBbGNhbnRhcmEgZGUgT2xpdmVpcmEiLCJpYXQiOjE3Mjg0MTYwMTksImV4cCI6MTcyODQxOTYxOSwianRpIjoiYWMwZDIzNzI2OTFlMDg5YzNlOTUyNzNmYjA0OTA3OTY2YzhlZGI2YyJ9.d8_o14-cvngPbnZhBD4OYLgTDUGi8I6Q5TKfWi-2lVAHGy-hOk1KSjm3EwyrcYDkTlEh3VWDDR2uCBE4gMjUZYvuTCwkitDflMTv57Lr4uq7LIzLMYWsvxbR6qghFKMFaW_yd-bByduIKRpJaM2hUTo2FQqRCk3WBOY9ACjiFjttpQzTlsqKpg11y4nwKctygGENvsSc9W8W6ehiGW3uiSgv03sHKfkcAPwpVUge53W8fZjDfH7B8noH6IIbbz6UGhJnSC5DPcX9HhfDNjlu2ulvzAnHnVQnBDshNsipAlE82xxu5w7qZq6v1h9xgv3SZVdbM68KP0BHr8-FtDhKDw




# ADICIONANDO PGADMIN 4 
https://renatogroffe.medium.com/postgresql-pgadmin-4-docker-compose-montando-rapidamente-um-ambiente-para-uso-55a2ab230b89

http://localhost:16543/browser/
Host: movie-postgres-1. nome da imagem
usuário : keycloak_db_user
senha : keycloak_db_user_password



Na arquitetura hexagonal, um aggregate é uma coleção de objetos de valor e entidades. É uma forma de simplificar o modelo de domínio, tratando o todo como uma unidade coesa. 
A arquitetura hexagonal, também conhecida como "arquitetura porta e adaptador", é uma metodologia de desenvolvimento de software. Ela é orientada a objetos, onde as portas são as interfaces e os adapters são as implementações. 
