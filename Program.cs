Console.Clear();

double fatura, 
    minimoporcentagem, 
    jurosmensais, 
    pagamentominimo, 
    vlnaopago, 
    juros, 
    iofmensal = 0.0038,
    iofdiario = 0.000082,
    proximafatura, 
    creditorotativo;


Console.WriteLine("--- Crédito Rotativo de Cartão de Crédito ---");

Console.Write("Valor total da fatura (R$)...: ");
fatura = Convert.ToDouble(Console.ReadLine());

Console.Write("Pagamento mínimo (%).........: ");
minimoporcentagem = Convert.ToDouble(Console.ReadLine());

Console.Write("Taxa de juros mensais (%)....: ");
jurosmensais = Convert.ToDouble(Console.ReadLine());

minimoporcentagem = minimoporcentagem / 100;

pagamentominimo = fatura * minimoporcentagem;

Console.WriteLine($"\nPagamento mínimo..................: R${pagamentominimo}");

Console.WriteLine("\nCaso seja pago o valor mínimo:");

vlnaopago = fatura - pagamentominimo;

jurosmensais = jurosmensais / 100;

Console.WriteLine($"\nValor não pago....................: R${vlnaopago}");

juros = vlnaopago * jurosmensais;

Console.WriteLine($"Juros.............................: R${juros}");

iofmensal = vlnaopago * iofmensal;

Console.WriteLine($"IOF mensal........................: R${iofmensal}");

iofdiario = vlnaopago * (iofdiario * 30);

Console.WriteLine($"IOF diário........................: R${iofdiario}");

proximafatura = vlnaopago + juros + iofmensal;

Console.WriteLine($"\nValor a pagar na próxima fatura...: R${proximafatura}");

creditorotativo = juros + iofmensal + iofdiario;

Console.WriteLine($"Custo do crédito rotativo.........: R${creditorotativo}");

