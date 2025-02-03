<h1 align="center">🚀 Integração com a API do Gemini em C#</h1>

<p align="center">
  <strong>Projeto que consome a API do Gemini (IA generativa do Google) para criar um sistema de perguntas e respostas no console usando C#.</strong>
</p>

<p>
  Este projeto envia perguntas digitadas pelo usuário para a API do Gemini e exibe as respostas geradas pela IA diretamente no console. Para garantir segurança, a API key é armazenada em <strong>variáveis de ambiente</strong>, evitando sua exposição no código. A aplicação foi organizada com classes bem definidas, como a <code>GeminiService</code>, que encapsula a lógica de comunicação com a API, e modelos para representar a estrutura da resposta JSON.
</p>

<p>
  <strong>Tecnologias utilizadas:</strong> <code>HttpClient</code> para requisições HTTP, <code>Newtonsoft.Json</code> para manipulação de JSON e boas práticas de desenvolvimento. O código é fácil de executar: basta configurar a variável de ambiente <code>GEMINI_API_KEY</code> e rodar o projeto com <code>dotnet run</code>. Futuramente, pode ser expandido para uma interface gráfica ou integrado a um chatbot. <strong>Contribuições são bem-vindas!</strong>
</p>

![0203](https://github.com/user-attachments/assets/4db303d1-4f05-4a99-8414-eec9f2c97c9e)
