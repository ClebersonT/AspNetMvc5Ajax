## AspNetMvc5Ajax
Exemplo simples utilizando o framework ASP NET MVC 5 + Razor com chamadas assincronas com ajax

## Algumas Funções Utilizadas no projeto

<h5>AntiForgeryToken:</h5> Gera um campo de formulário oculto (token anti-falsificação) que é validado quando o formulário é enviado. O valor do campo é gerado usando o valor salt especificado.
<pre>
   @Html.AntiForgeryToken()
</pre>
Adicione o [ValidateAntiForgeryToken] em todas as ações que aceitam POST HTTP
<pre>
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Index(){
        return View();
    }
</pre>
