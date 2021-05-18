## AspNetMvc5Ajax
Exemplo simples utilizando o framework ASP NET MVC 5 + Razor com chamadas assincronas com ajax

<img alt="HTML" src="https://img.shields.io/badge/HTML5-E34F26?style=for-the-badge&logo=html5&logoColor=white">&nbsp;<img alt=".Net" src="https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=dot-net&logoColor=white">&nbsp;<img alt="C#" src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white">&nbsp;

## O que é o Razor?

Vamos entender um pouco do Razor para que possamos entender como utilizar Html Helpers...
Razor é uma sintaxe de marcação para a incorporação de código baseado em servidor em páginas da Web. A Razor sintaxe consiste em Razor marcação, C# e HTML. Os arquivos que Razor contêm geralmente têm uma extensão de arquivo .cshtml. Razor também é encontrado em arquivos Razor de componentes (.razor).

~~~html
<p>Last week: @DateTime.Now - TimeSpan.FromDays(7)</p>
~~~

## Algumas Funções Utilizadas no projeto (HtmlHelper)

<h5>AntiForgeryToken:</h5> Gera um campo de formulário oculto (token anti-falsificação) que é validado quando o formulário é enviado. O valor do campo é gerado usando o valor salt especificado.

~~~C#
   @Html.AntiForgeryToken()
~~~

Adicione o [ValidateAntiForgeryToken] em todas as ações que aceitam POST HTTP
~~~C#
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Index(){
        return View();
    }
~~~

<h5>TextBoxFor():</h5>é o método de extensão genérico que cria o input.

~~~C#
     @Html.TextBoxFor(m => m.Text, new { placeholder = Html.DisplayNameFor(m => m.Text), @class = "form-control" })
~~~

<h5>ValidationMessageFor():</h5>
étodo é uma expressão lambda para especificar uma propriedade para a qual queremos mostrar uma mensagem de erro

~~~C#
    @Html.ValidationMessageFor(m => m.Text, "", new { @class = "text-danger custom-danger" })
~~~

<h5>Ajax.BeginForm():</h5>
    Ajax.BeginForm é o método de extensão da  classe auxiliar ASP.NET MVC Ajax, que é usado para enviar dados de formulário para o servidor sem postback de página inteira.

~~~C#
      @using (Ajax.BeginForm("Index", "RazorAjax", 
            new AjaxOptions { HttpMethod = "POST", OnSuccess = "onAjaxRequestSuccess" },
            new { @id = "AjaxformId", @class = "form-horizontal", role = "form" })) 
        {
            ...
        }
~~~

O Ajax.BeginForm assume os seguintes parâmetros
- actionName
- nome do controlador
- routeValues
- ajaxOptions
- htmlAttributes

### :link: Links Úteis
> https://docs.microsoft.com/pt-br/aspnet/core/mvc/views/razor?view=aspnetcore-5.0

> https://www.c-sharpcorner.com/UploadFile/0c1bb2/ajax-beginform-in-Asp-Net-mvc-5/
