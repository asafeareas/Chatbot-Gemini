<h1> 🚀 Integração com a API do Gemini em C# <h1>
Este projeto consome a API do Gemini (IA generativa do Google) para criar um sistema de perguntas e respostas no console usando C#. A aplicação envia perguntas digitadas pelo usuário para a API e exibe as respostas geradas pela IA. Para garantir segurança, a API key é armazenada em variáveis de ambiente, evitando exposição no código. O projeto foi organizado com classes bem definidas, como GeminiService, que encapsula a lógica de comunicação com a API, e modelos para representar a estrutura da resposta JSON.

Tecnologias utilizadas incluem HttpClient para requisições HTTP, Newtonsoft.Json para manipulação de JSON e boas práticas de desenvolvimento. O código é fácil de executar: basta configurar a variável de ambiente GEMINI_API_KEY e rodar o projeto com dotnet run. Futuramente, pode ser expandido para uma interface gráfica ou integrado a um chatbot. Contribuições são bem-vindas!

![0203](https://github.com/user-attachments/assets/0d7edd81-9b24-4b59-91f8-a07ad56b22e0)
