🏦 EstacionamentoAdapter — Padrão Adapter em C#

📌 Sobre o projeto

Este projeto é um exercício prático para aprender e aplicar o padrão de projeto Adapter utilizando
C#.

O cenário simula um sistema de estacionamento que precisa integrar uma classe antiga de pagamento
a uma nova interface, sem modificar o código original.

O Adapter funciona como um intermediário, permitindo que classes com interfaces diferentes
trabalhem juntas.

🎯 Objetivos

Compreender o funcionamento do padrão Adapter.

Praticar o uso de interfaces em C#.

Aplicar encapsulamento e construtores.

Integrar uma classe existente sem modificar seu código.

Organizar o código em arquivos separados.

🛠️ Tecnologias utilizadas

C#

.NET

Visual Studio

Aplicação de Console

📂 Estrutura do projeto

EstacionamentoAdapter/
├── IPagamento.cs
├── PagamentoAntigo.cs
├── PagamentoAdapter.cs
├── Program.cs
└── README.md

⚙️ O desafio

O sistema utiliza a interface IPagamento, que define o método:

void Pagar(decimal valor);

Entretanto, a classe antiga PagamentoAntigo possui o método:

void RealizarCobranca(double quantia);

Como os métodos possuem nomes e tipos de parâmetros diferentes, é necessário criar
uma classe adaptadora que implemente IPagamento e encaminhe a chamada para o método 
antigo.

Regra importante: a classe PagamentoAntigo não deve ser modificada.

▶️ Resultado esperado

Ao executar o programa, o sistema deverá realizar um pagamento de R$ 35,50 e exibir:

Pagamento de R$ 35,50 realizado.

🧠 Conceitos praticados

Adapter: permite integrar interfaces incompatíveis.

Interface: define um contrato que uma classe deve implementar.

Encapsulamento: protege e organiza o acesso aos objetos.

Construtor: permite receber as dependências necessárias para a adaptação.

Conversão de tipos: permite converter decimal para double para utilizar o método legado.

🚀 Como executar

Clone este repositório ou baixe os arquivos.

Abra o projeto no Visual Studio.

Execute a aplicação pelo botão Iniciar ou pelo terminal.

Confira o resultado no console.

📚 Aprendizado

O principal aprendizado deste exercício é entender como o padrão Adapter permite reutilizar
classes existentes e integrar sistemas com interfaces diferentes, evitando alterações
desnecessárias no código original.