## 💰 Simulador de Caixa Eletrônico💻

Projeto simples e interativo de terminal que simula um caixa eletrônico.  
Permite ao usuário inserir um valor para saque, e o programa calcula quantas cédulas de cada valor devem ser entregues.

[Clique aqui para baixar](https://github.com/biancazevedo/CaixaEletronico/commit/ce69647332e8aaca1124ec4b53bc3aebaa236e12)

---

# 🏗️ Como o Programa Funciona

### 🎯 Entrada dos dados:

- O usuário digita um valor para sacar (por exemplo: `280`, `398`, ou `298,00` com vírgula).
- O programa aceita números com vírgula conforme o **padrão brasileiro (pt-BR)**.
- **Não aceita centavos** — apenas valores inteiros.

---

### ✅ Validação:

- Verifica se o valor digitado:
  - É numérico.
  - É positivo.
  - **Não contém centavos** (como 298,75).
- Se a entrada for inválida, o programa mostra uma mensagem de erro clara.

---

### 🧮 Processamento:

- Calcula quantas notas de cada valor serão entregues:
  - R$200,00  
  - R$100,00  
  - R$50,00  
  - R$20,00  
  - R$10,00  
  - R$5,00  
  - R$2,00  
  - R$1,00  

---

### 🔁 Repetição:

- Ao final da operação, o usuário pode escolher se deseja **fazer um novo saque** digitando `s` ou `n`.
- Se digitar `s`, o programa reinicia.  
- Se digitar `n`, o programa encerra com uma mensagem.

---

## 📦 Exemplo de Uso

```bash
--- Caixa Eletrônico ---

Digite o valor a ser sacado...: 388


O caixa deve entregar:

1 nota(s) de R$200,00

1 nota(s) de R$100,00

1 nota(s) de R$50,00

1 nota(s) de R$20,00

1 nota(s) de R$10,00

1 nota(s) de R$5,00

1 nota(s) de R$2,00

1 nota(s) de R$1,00


Deseja realizar outro saque? (s/n): n
Encerrando o programa...

