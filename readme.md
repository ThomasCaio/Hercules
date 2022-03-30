## Os 12 trabalhos de Hércules

Alcmena era esposa de Anfitrião. Quando seu marido estava na guerra, Zeus tomou a sua forma para fazer amor com Alcmena. Anfitrião desconfiou da infidelidade da esposa, e no fim, Zeus esclareceu-lhe tudo. Mas, surpreendentemente, Anfitrião ficou contente e honrado com a presença do deus em sua casa. A partir daí, o termo anfitrião passou a ter o sentido de "aquele que recebe em casa". Daquela noite de amor nasceu o semideus Hércules (ou Héracles, em grego).
O nascimento de Hércules provocou a ira de Hera, a ciumenta esposa oficial de Zeus, que mandou duas serpentes matarem o recém-nascido fruto do adultério. Este, porém, sem grande esforço, estrangulou as cobras, mostrando desde cedo possuir uma força descomunal. Hércules cresceu, mas Hera continuou a persegui-lo e usou seus poderes para provocar um acesso de loucura ao herói, que acabou matando a própria esposa, Mégara, e os filhos, ateando fogo na própria casa. Quando Hércules recuperou a razão, procurou o Oráculo de Delfos - o mais famoso templo de consulta às divindades gregas - para buscar orientação sobre como enfrentar a tragédia. O Oráculo mandou-o se entregar em servidão a Euristeus, rei da cidade de Micenas, que ordenou a realização das 12 famosas tarefas. Os 12 trabalhos foram realizados para que Hércules se redimisse das mortes que cometeu.

### 1. O ORÁCULO
Escreva um programa que receba um caractere informado pelo usuário e determine se o caractere é uma string maiúscula ou minúscula, um dígito ou um símbolo especial. Vamos usar a tabela ASCII padrão e estendida para exibir o código do caractere digitado e fazer a verificação:


 

### 2. CONSTELAÇÕES
Faça um programa onde de a opção de visualizar 3 constelações de sua preferência no console, mas utilizando o caracter ‘*’ para representar as estrelas. Neste programa o usuário deve escolher a constelação que quer visualizar e ela deve ser reproduzida em console.

### 3. SOLDADOS DE VOSSO EXÉRCITO
Escreva um programa que imprima todos os valores dos códigos ASCII e seus respectivos caracteres usando um laço do-while.

### 4. FORMAÇÃO DE BATALHA
Escreva um programa que imprime no Console uma matriz identidade n por n usando um laço for.
Matriz identidade, em matemática, é uma matriz quadrada e uma matriz diagonal, cuja função é de ser o elemento neutro, na multiplicação de matrizes. É denotada por In (onde n é a ordem da matriz), ou simplesmente por I. A matriz é construída da seguinte forma: os elementos da diagonal principal têm valor um, e os demais elementos da matriz são zero.
Uma matriz identidade se apresenta da seguinte forma:
 


### 5. A CORRIDA DE AQUILES
Escreva um programa que calcule e exiba a soma da seguinte série : 
 1*x + 2*x^2 + 3*x^3 + 4*x^4 + 5*x^5 + … + n*xn
Em matemática, o conceito de série, ou ainda, série infinita, surgiu da tentativa de generalizar o conceito de soma para uma sequência de infinitos termos. Esta generalização, longe de acontecer de forma impune, traz diversas dificuldades:
nem sempre é possível definir um valor resultante da soma para uma série;
não é possível em geral trocar a ordem dos termos da série;
Algumas séries possuem soma infinita.
Embora a ideia de soma infinita seja bastante antiga, uma formulação matemática rigorosa só veio a surgir no século XVIII, com o advento da análise real, que denota e define uma série de termos  da seguinte forma:
 


### 6. CONVERSÕES
Escreva um programa que usando a instrução switch e que a partir de um valor informado pelo usuário realize as seguintes conversões :
P -> Polegadas para Centímetros
G -> Galão para Litros
M -> Milhas para Quilômetros
Para a primeira conversão o usuário deverá informar a opção P , para a segunda deve informar G e para a terceira deve informar M.
1 milha é igual a 1,609 Km ou 1609 metros ou 160934 centímetros
1 polegada é igual a 2,54 cm, ou 0,0254 metros ou 25,4 milímetros
1 galão é igual a 3,78 litros

### 7. BUSCA
Escreva um programa que receba n valores do usuário e em seguida ordene os valores em ordem ascendente. Na linguagem C#,  os arrays possuem o índice com base zero, ou seja, o primeiro elemento do array possui o índice zero (0).
Um array de uma dimensão é declarado informando o tipo de dados do array seguido do nome do array, lembrando que devemos colocar colchetes ([]) depois do tipo do array e não após o seu nome:
Ex:  int[] tabela; ==> correto     int tabela[];  ==> incorreto
Na linguagem C#, o tamanho do array não é parte do seu tipo, isso permite declarar uma array e em seguida atribuir qualquer array de objetos int a ele, sem considerar o seu tamanho. Além de arrays de uma dimensão a linguagem C# suporta os seguintes tipos de arrays:
- Arrays com mais de uma dimensão :
    string[,] names;      
    int[,] array = new int[2, 2];
-  Array-of-arrays (jagged):
     byte[][] resultados;
     int[][] numArray = new int[][] { new int[] {1,3,5}, new int[] {2,4,6,8,10} };
Em C# declaramos um array assim :
string[] nomes;                 //array nomes de qualquer tamanho
mas isso não cria o array para fazer isso devemos declarar:
nomes = new string[5];        //array de strings de 5 elementos 
finalmente para inicializar o array fazemos assim:
nomes[0] = "José";
nomes[1] = "Carlos";
nomes[2] = "Macoratti";
nomes[3] = "Miriam";
nomes[4] = "Estela";
Observe o índice indicando a posição do elemento no array. O primeiro elemento é o zero e o último é o 4. Assim temos 5 elementos no array com posições : 0,1,2,3 e 4.

### 8. ACUSAÇÕES
Escreva um programa que receba 2 números de um usuário e retorne qual dos números é o maior e depois verifique se esse número é primo ou não. Um método é um bloco de código que contém uma série de instruções. Um programa faz com que as instruções sejam executadas chamando o método e especificando todos os argumentos necessários do método. Em C#, todas instruções são executadas por métodos. O método Main é o ponto de entrada para cada aplicativo C# e ele é chamado pelo CLR (Common Language Runtime) quando o programa é iniciado.
Métodos são declarados em uma classe ou struct, especificando o nível de acesso como public, private, abstract ou sealed, o valor de retorno, o nome do método. Essas partes juntas compõem a assinatura de método.
Os parâmetros do método são colocados entre parênteses e são separados por vírgulas. Os parênteses vazios indicam que o método não requer nenhum parâmetro.
Chamar um método em um objeto é como acessar um campo. Após o nome do objeto, adicione um ponto, o nome do método e parênteses. Os argumentos são listados dentro dos parênteses, e separados por vírgulas. 

### 9. VALOR OU REFERÊNCIA
Escreva um programa que mostre a diferença entre um parâmetro por valor e um parâmetro por referência. Em C#, os argumentos podem ser passados os parâmetros por valor ou por referência. A passagem por referência permite que membros da função, métodos, propriedades, indexadores, operadores e construtores alterem o valor dos parâmetros fazendo com que essa alteração persista no ambiente de chamada.
Uma variável de um tipo por referência não contém seus dados diretamente. Ele contém uma referência a seus dados. Quando você passa um parâmetro de tipo de referência por valor, é possível alterar os dados apontados por referência, como, por exemplo, o valor de um membro da classe. No entanto, você não pode alterar o valor da referência propriamente dito; ou seja, você não pode usar a mesma referência alocando memória para uma nova classe. Para isso, passe o parâmetro usando a palavra-chave ref ou  out.
Existem três modificadores de parâmetros que podem ser usados para alterar a forma como os parâmetros são passados para as funções :
(nenhum): Se um parâmetro não é marcado com um modificador de parâmetro, ele será passado por valor, ou seja, o método chamado recebe uma cópia do dado original.
out: Parâmetros out devem ser atribuídos pelo método sendo chamado, e portanto são passados por referência. Se o método chamado não atribuir os parâmetros out, haverá um erro de compilação.
ref: O valor é atribuído pelo chamador e pode ser opcionalmente reatribuído pelo método chamado.  Se o método chamado não atribuir um parâmetro ref nenhum erro de compilação será gerado.
params: Este modificador de parâmetro permite a enviar um número variável de argumentos como um único parâmetro lógico. Um método pode ter somente um modificador params, e ele deve ser o último parâmetro do método. O modificador params não é muito usado, mas existem vários métodos na biblioteca base da .NET Framework que fazem uso deste recurso.
A forma padrão de enviar um parâmetro é por valor. Os parâmetros de referência são necessários quando você quer permitir a um método operar em vários pontos de dados declarados dentro do escopo do chamador. Observe a diferença entre parâmetros de saída e parâmetros de referência:
Parâmetros de saída não precisam ser inicializados antes de serem passados para o método, pois o método deve atribuir valores a esses parâmetros antes de finalizar.
Parâmetros de referência devem ser inicializados antes de serem passados para o método. O motivo é que você está passando uma referência para uma variável existente. Se você não atribuir um valor inicial, isso seria equivalente a operar com uma variável local não atribuída.

### 10. A SOMA DE TODOS NÓS
Escreva um programa que receba um número de um usuário e exiba a soma dos dígitos deste número. Ex: Se o usuário informar 142 o valor exibido será: 1+4+2 = 7. 
O C# fornece um grande conjunto de operadores, que são os símbolos que especificam quais operações executar em uma expressão. No C#, um operador é um elemento de programa que é aplicado a um ou mais operandos em uma expressão ou instrução. Operadores que usam um operando, como, por exemplo, o operador de incremento (++) ou new, são chamados de Unário operadores.
Operadores que usam dois operandos, como, por exemplo, operadores aritméticos (+,-,*,/), são chamados de binário operadores. Um operador, o operador condicional (?:), usa três operandos e é o único operador Ternário em C#.
Operações em tipos integrais como ==, !=, <, >, <=, >=, binary +, binary -, ^, &, |, ~, ++, --, e sizeof() geralmente são permitidos em enumerações. Além disso, muitos operadores podem ser sobrecarregados pelo usuário, alterando, portanto, seu sentido quando aplicado a um tipo definido pelo usuário.
Cada operador tem uma precedência definida. Em uma expressão que contém vários operadores que têm níveis diferentes de precedência, a precedência dos operadores determina a ordem na qual os operadores são avaliados.

### 11. HERON
Escreva um programa que calcule a área de um triângulo quando são fornecidos pelo usuário  o valor dos 3 lados A, B e C. O programa deve verificar se o triângulo existe. Heron de Alexandria é o responsável por elaborar uma fórmula matemática que calcula a área de um triângulo em função das medidas dos seus três lados. A fórmula de Heron de Alexandria é muito útil nos casos em que não sabemos a altura do triângulo, mas temos a medida dos lados.
Em um triângulo de lados medindo a, b e c podemos calcular a sua área utilizando a fórmula de Heron:

P = (a + b + c) / 2;
Área = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
Sabemos que um triângulo é formado por três lados que possuem uma determinada medida, mas essas não podem ser escolhidas aleatoriamente como os lados de um quadrado ou de um retângulo, é preciso seguir uma regra.

Só irá existir um triângulo se, somente se, os seus lados obedeceram à seguinte regra:
Um de seus lados deve ser maior que o valor absoluto (módulo) da diferença dos outros dois lados e menor que a soma dos outros dois lados. Veja o resumo da regra abaixo:
| b - c | < a < b + c
| a - c | < b < a + c
| a - b | < c < a + b

### 12. RECURSOS
Escreva um programa que exiba uma lista dos serviços instalados no computador local e ao final informe o número total de serviços instalados.