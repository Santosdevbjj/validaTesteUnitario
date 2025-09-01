## Implementando Validações de Testes Unitários com C# 


![WexQA](https://github.com/user-attachments/assets/62673043-fa27-4802-8c64-68a9411dcfcf)




**Bootcamp WEX - Desenvolvimento .NET e QA**

---

**DESCRIÇÃO**
Neste desafio você utilizará seus conhecimentos adquiridos no módulo de Testes Unitários com c# da trilha de .NET.

---

**Estrutura do Repositório**


<img width="1000" height="1297" alt="Screenshot_20250901-144138" src="https://github.com/user-attachments/assets/ce7060bf-10d0-447e-90c6-b25cf9d0cc08" />


---


**Motivação e benefícios**

**Qualidade de código:** Testes automatizados asseguram que funcionalidades críticas funcionam como esperado, mesmo após alterações.

**Manutenção fácil:** Isolamento claro da lógica e testes facilitam refatorações futuras.

**Base para evolução:** Projeto simples que pode ser expandido com novos métodos, testes adicionais ou integração contínua (CI). 

---


### Estrutura e Funções:

- **`ValidacoesLista.cs`**  
  Contém métodos para operações distintas em listas de inteiros:
  - `RemoverNumerosNegativos`: retorna uma nova lista sem valores negativos.  
  - `ListaContemDeterminadoNumero`: verifica se um número específico existe na lista.  
  - `MultiplicarNumerosLista`: multiplica cada elemento da lista por um fator.  
  - `RetornarMaiorNumeroLista`: obtém o maior número da lista.  
  - `RetornarMenorNumeroLista`: obtém o menor número da lista.  

- **`ValidacoesString.cs`**  
  Lida com validações em strings:
  - `RetornarQuantidadeCaracteres`: retorna o tamanho da string.  
  - `ContemCaractere`: verifica se uma substring está presente.  
  - `TextoTerminaCom`: verifica se o texto termina com um trecho específico.  

- **Testes xUnit (`ValidacoesListaTests.cs`, `ValidacoesStringTests.cs`)**  
  Cobre cenários positivos e negativos para cada método das classes de validação, garantindo que:
  - Listas com números negativos removam corretamente os itens.  
  - Presença e ausência de valores específicos sejam detectadas.  
  - Multiplicações e seleções de máximo/mínimo estejam corretas.  
  - Operações de strings (comprimento, substring, sufixo) funcionem conforme esperado.

---

##  Requisitos

- [.NET 8 SDK (ou superior)](https://dotnet.microsoft.com/download) instalado para compilar e executar o projeto.
- Sistema operacional compatível: Windows, Linux ou macOS.

---

##  Como Executar

Acesse a raiz do projeto e execute os comandos:

```bash
dotnet restore       # Restaura dependências
dotnet build         # Compila todos os projetos
dotnet test          # Executa os testes automatizados





