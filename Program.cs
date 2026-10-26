

using Adapter_Padrao;

PagamentoAntigo pagamentoAntigo = new PagamentoAntigo();

IPagamento pagamento = new PagamentoAdapter(pagamentoAntigo);

pagamento.Pagar(12532);