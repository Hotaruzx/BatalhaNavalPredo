# ⚓ Batalha Naval

> **Projeto:** Simulador de Batalha Naval  
> **Linguagem:** C#  
> **Objetivo:** Desenvolver um jogo de Batalha Naval executado pelo console, utilizando posicionamento aleatório de embarcações, coordenadas, estruturas condicionais e controle de tentativas.

---

## Objetivo da atividade

Criar um programa que simule o jogo **Batalha Naval**, no qual o jogador deverá lançar bombas em coordenadas de um mapa para tentar destruir embarcações posicionadas aleatoriamente. O programa deverá registrar os acertos e erros, calcular a pontuação do jogador e apresentar o resultado final da partida.

## Requisitos do programa

### 1. Criação do mapa

- Criar um mapa com **10 linhas e 10 colunas**.
- Iniciar cada partida com o mapa limpo.
- Posicionar as embarcações aleatoriamente, sem repetir posições.
- Distribuir as seguintes embarcações:
  - **10 porta-aviões**
  - **1 cruzador**
  - **2 rebocadores**

### 2. Tentativas do jogador

- O jogador terá **15 tentativas** para informar as coordenadas em que deseja lançar bombas.
- As coordenadas utilizadas não poderão ser repetidas.
- Cada disparo deverá verificar se atingiu uma embarcação ou se caiu na água.
- As marcações realizadas no mapa deverão permanecer visíveis durante todas as rodadas.

### 3. Sistema de pontuação

Ao atingir uma embarcação, o jogador receberá pontos de acordo com o tipo atingido:

| Embarcação | Pontuação por acerto |
|:--|--:|
| Porta-aviões | 🟢 5 pontos |
| Cruzador | 🟢 15 pontos |
| Rebocador | 🟢 10 pontos |

### 4. Identificação dos disparos

O programa deverá utilizar cores para diferenciar os resultados dos disparos no mapa.

| Cor | Significado |
|:--|:--|
| 🔴 **Vermelho** | Embarcação atingida, indicando a posição e o tipo destruído. |
| 🟢 **Verde** | Disparo que não atingiu nenhuma embarcação, indicando também a distância do erro. |
| 🔵 **Azul** | Embarcação que permaneceu intacta ao final da partida. |

### 5. Distância dos erros

Quando o jogador não atingir uma embarcação, o programa deverá destacar o disparo em **verde** e informar o tamanho do erro:

- **1** — Existe uma embarcação a uma casa de distância, nas direções horizontal ou vertical.
- **2** — Existe uma embarcação a duas casas de distância, nas direções horizontal ou vertical.
- **3** — Existe uma embarcação a três casas de distância, nas direções horizontal ou vertical.
- **M** — Erro por muito!

### 6. Resultado final

Após as **15 tentativas**, o programa deverá:

- Revelar no mapa a posição de todas as embarcações.
- Exibir o tipo de cada embarcação.
- Destacar em **vermelho** as embarcações atingidas.
- Destacar em **azul** as embarcações que permaneceram intactas.
- Manter as marcações dos disparos realizados, diferenciando acertos e erros.
- Apresentar a pontuação total obtida pelo jogador.

### 7. Encerramento ou nova partida

Após apresentar os resultados, o programa deverá oferecer ao jogador duas opções:

- **Iniciar uma nova partida:** gerar um novo mapa e posicionar novamente todas as embarcações.
- **Sair do programa:** encerrar a execução.

---

## Resumo dos requisitos

- [ ] Criar um mapa de 10 × 10.
- [ ] Posicionar aleatoriamente 10 porta-aviões, 1 cruzador e 2 rebocadores.
- [ ] Garantir que as posições das embarcações não se sobreponham.
- [ ] Permitir 15 tentativas por partida.
- [ ] Impedir a repetição de coordenadas de disparo.
- [ ] Implementar a identificação de acertos e erros.
- [ ] Calcular a pontuação de acordo com a embarcação atingida.
- [ ] Destacar os resultados utilizando cores.
- [ ] Informar a distância dos disparos que não atingirem embarcações.
- [ ] Preservar as marcações durante todas as rodadas.
- [ ] Revelar as embarcações restantes ao final da partida.
- [ ] Exibir a pontuação final.
- [ ] Permitir iniciar uma nova partida ou sair do programa.

---

## Tecnologias

- **C#** — desenvolvimento da lógica do jogo.
- **.NET** — execução do programa.
- **Git e GitHub** — versionamento e documentação do projeto.

---

*⚓ Projeto desenvolvido com o objetivo de praticar lógica de programação, manipulação de matrizes, geração de números aleatórios, validação de entradas e estruturas de controle em C#.*