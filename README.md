<img src="D:\PROJETOS\C#\M-V-C\Model-View-Controller\wwwroot\img\img.png" alt="logo" style="zoom:60%;" />

### **Padrão Arquitetural MVC ( Model - View - Controller )**

<hr>
- É um padrão de arquitetura de software ( design pattern ) que separa um aplicativo em três componentes principais: modelo, exibição e controlador.

- Divisão em camadas torna mais fácil e defini melhor as responsabilidades.

- Altamente testável ( favorece o TDD )




#### Model ( Modelo)

------

- São as partes do aplicativo que implementam a lógica para o dominio de dados do aplicativo. Muitas vezes, os objetos de modelo recuperam e armazenam o estado do modelo em um banco de dados.



#### Controller ( Controlador)

------

- Controlador ( controller ) : São os componentes que lidam a interação do usuario, trabalham com o modelo e, finalmente, selecionam uma exibição de renderização que mostra essa UI. Em um aplicativo MVC, a exibição só mostra informações; o contrlador manipula e responde à entrada e a interação do usuario.



#### View ( Visão )

------

- São os componentes que exibem a interface do usuario ( UI ) do aplicativo.





**Neste projeto foi utilizado os seguintes packages:**

------



```
Microsoft.EntityFrameworkCore.SqlServer

Microsoft.EntityFrameworkCore.Tools
```




Para instalar o Entity Framework em nosso projeto vamos usar a opção do menu **Tools-> Nuget Package Manager ->  Package Manage Console.**

```
Install-Package Microsoft.EntityFrameworkCore.SqlServer

Install-Package Microsoft.EntityFrameworkCore.Tools
```

E também o **Migrations:**

```
add-migration CriacaoBD
```



#### Screenshots:

------

#### Inicial				 <img src="D:\PROJETOS\C#\M-V-C\Model-View-Controller\wwwroot\img\Index.png" style="zoom:50%;" />

------

#### Cadastro			<img src="D:\PROJETOS\C#\M-V-C\Model-View-Controller\wwwroot\img\Inclusao.png" style="zoom:50%;" />

------

#### Atualizar			 <img src="D:\PROJETOS\C#\M-V-C\Model-View-Controller\wwwroot\img\Atualizar.png" style="zoom:50%;" />

------

#### Apagar				 <img src="D:\PROJETOS\C#\M-V-C\Model-View-Controller\wwwroot\img\Apagar.png" style="zoom:50%;" />





