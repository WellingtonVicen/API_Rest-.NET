# API_Rest-.NET-Core
<p>API Rest Desenvolvida em .NET Core Utilizando EF Core e MySQL</p>
<br>
<br><br>
<br>

<h3 align="center">Para Executar o Projeto Configure as Variaveis de Ambiente com os Seguintes comandos</h3>
<br>
<p>Abra o terminal e digite </p>
<pre>
dotnet user-secrets init
</pre>
<br>
<br>
<p>Configure a string de conexão com o DB</p>
<br>
<pre>
dotnet user-secrets set "ConnectionStrings:USER_MANAGER" "[STRING CONNECTION]"
</pre>
<br>
<br>
<p>Configure os Dados de autenticação a API (JWT)</p>
<br>
<pre>
dotnet user-secrets set "Jwt:Key" "[JWT CRYPTOGRAPHY KEY]"
dotnet user-secrets set "Jwt:Login" "[JWT LOGIN]"
dotnet user-secrets set "Jwt:Password" "[JWT PASSWORD]"
</pre>
<br>
<br>
<br>
<h3 align="center">Alguns comandos que podem ser úteis :)</h3>
<br>
<br>
<p>Listar segredo.</p>
<br>
<pre>
dotnet user-secrets list
</pre>
<br>
<br>
<p>Deletar segredo.</p>
<br>
<pre>
dotnet user-secrets remove "[CHAVE]"
</pre>
<br><br>
<br><br>
<br><br>
<p align="center">2021&copy;</p>
