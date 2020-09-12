# Alpes Suínos Lang
Linguagem de programação criada a partir da metalinguagem utilizado por membros de um time de desenvolvimento

# Extensão de arquivo utilizado:
.asl

# Palavras reservadas
gitConsole - escrever na tela
vacaRemoendo - while
preteouAGaitada - erro de compilação
lubridiou - compiou
fiqueiRessabioso - if
naoVamosLevarAoPeDaRisca - else
podeConforsar - return
Comer hamburguer no mandinga - sleep
aperitiscos - bool
quanPlanty - double 
steveMagal - string
tiroNaBota - void
atualizaAsIdentidades - ler mensagem na tela
ambienteAmigoso - begin
soltarOPulmaoDoAr - end
prodoction - function

# Exemplo 1 de utilização
``` asl
prodoction OlaMundo() : tiroNaBota
ambienteAmigoso
    gitConsole("Olá mundo");
soltarOPulmaoDoAr

OlaMundo();
```

# Exemplo 2 de utilização
``` asl
prodoction Maior(valor1 : quanPlanty, valor2 : quanPlanty) : quanPlanty
ambienteAmigoso
    fiqueiRessabioso(valor1 < valor2)
        podeConforsar valor2;
    naoVamosLevarAoPeDaRisca
        podeConforsar valor1;
soltarOPulmaoDoAr


//ler valor da tela e exibir o maior deles
valorRecebido1 : quanPlanty = atualizaAsIdentidades("Digite um valor"))
valorRecebido2 : quanPlanty = atualizaAsIdentidades("Digite outro valor"))

maiorValor : quanPlanty = Maior(valorRecebido1, valorRecebido2);

gitConsole "O maior valor é " + (steveMagal)maiorValor;
```
