# School_Asp.net

# FERRAMENTAS
 - Visual Stúdio Community 2019: https://visualstudio.microsoft.com/pt-br/vs/
 - Banco de dados sql server - Qualquer versão

# TECNOLOGIA
  -C#, ASP.NET MVC, MsSQL

# ATIVIDADE

 - Criar um banco de dados nome: Escola
 
 - Criar as seguintes tabelas
	
	[x] Aluno ( Id, Nome, CPF, RG, Telefone , Endereco, Número (do endereço), IdCidade) 
	* todos os campos são obrigatórios exeto o RG
		
	
	[x] Cidade ( Nome, UF) (esta tabela deve ser populada manualmente, não precisa de todos os registros do Brasil, basta alguns para testes)

 - Criar uma aplicação utilizando ASP.NET MVC
 
	[x] Criar uma página de listagem de alunos
	Nesta listagem va ter que tem um botão adicionar em algum lugar que redirecionará para o formulário de adicionar alunos
	Todos os campos da tabela deverão ser listados
	Ao clicar em qualquer campo da tabela deverá redirecionar para uma página de edição do aluno 
	Em cada linha também deverá ter um botão excluir, e ao clicar sobre o botão deverá pedir uma confirmação, que caso seja concedida, deverá excluir os registros e atualizar a listagem
	
	[x] Criar um formulário de cadastro de alunos
	Todas os campos da tabela devem ser contemplados no cadastro
	Ao final do formulário deve ter um botão salvar, que irá salvar as informações inseridas no banco de dados e um botão voltar que voltará para a tela de listagem
		
	[x] Criar um formulário de edição  de alunos
	Todas os campos da tabela devem ser contemplados no cadastro
	Ao final do formulário deve ter um botão salvar, que irá salvar as informações inseridas no banco de dados e um botão voltar que voltará para a tela de listagem

 # Diferencial
 
[x] Utilização do bootstrap para layout

[ ] Validação dos campos no servidor e com javascript

[ ] Utilização de máscaras para telefone e CPF

[ ] Busca das cidades por estado com ajax

[x] Salvar todos as sqls de criação das tabelas e insersão dos registros em um arquivo dentro do projeto

[x] EntityFramework
