using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    public List<Contato> contatos = new List<Contato>();

    protected void Page_Load(object sender, EventArgs e)
    {
        ctrLogin.Mensagem = "Default pagina";

        contatos.Add(new Contato() { Nome = "Danilo", Id = 1 });
        contatos.Add(new Contato() { Nome = "Sheila", Id = 2 });
        contatos.Add(new Contato() { Nome = "Lana", Id = 3 });
        contatos.Add(new Contato() { Nome = "Billy", Id = 4 });

        ddlContatos.DataSource = contatos;
        ddlContatos.DataValueField = "Id";
        ddlContatos.DataTextField = "Nome";
        ddlContatos.DataBind();

        GridView1.DataSource = contatos;
        GridView1.DataBind();
    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        Response.Write("Olá " + txtMensagem.Text + "<br>");
        Response.Write("Olá " + Request["txtMensagem"]);
        Response.Write("Telefone " + Request["telefone"] + telefone.Value);
        //Response.Write("<script>alert('Olá " + txtMensagem.Text + "')</script>");
    }
}