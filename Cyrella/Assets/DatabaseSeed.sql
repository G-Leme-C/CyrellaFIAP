INSERT INTO Empreendimentos
(Id, PercentualCompleto, FaseAtual, DtLancamento, QtUnidadesDisponiveis, ValorInicial, DtInicioVistoria, 
	DtAssembleia, PautaAssembleia, DtEntregaChaves, DtDuracaoGarantia, CoberturaGarantia)
VALUES(10, 35, 'Obra iniciada', '10-08-2021', 200, 150000, '10-08-2023', '10-11-2023', 'Eleição do síndico e equipe condominial',
 '10-12-2023', '10-12-2028', 'Alvenaria/Elétrica/Hidráulica');

--Afetações
INSERT INTO Afetacoes
(Bem, ValorBem, EmpreendimentoId)
VALUES('Imóvel 1', 100000, 10);

INSERT INTO Afetacoes
(Bem, ValorBem, EmpreendimentoId)
VALUES('Imóvel 2', 200000, 10);

--Fases da obra
INSERT INTO FasesObra
(Fase, Percentual, EmpreendimentoId)
VALUES('Lançamento', 10, 10);

INSERT INTO FasesObra
(Fase, Percentual, EmpreendimentoId)
VALUES('Aprovação da planta', 15, 10);

INSERT INTO FasesObra
(Fase, Percentual, EmpreendimentoId)
VALUES('Obra iniciada', 10, 10);

--Itens personalizados
INSERT INTO ItensPersonalizacao
(Item, Valor, EmpreendimentoId)
VALUES('Piso completo banheiro', 5000, 10);

INSERT INTO ItensPersonalizacao
(Item, Valor, EmpreendimentoId)
VALUES('Piso completo cozinha', 7000, 10);