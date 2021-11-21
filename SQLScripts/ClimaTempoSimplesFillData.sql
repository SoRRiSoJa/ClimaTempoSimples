USE [ClimaTempoSimples]
GO

INSERT INTO Estado VALUES (1, 'Acre', 'AC');
INSERT INTO Estado VALUES (2, 'Alagoas', 'AL');
INSERT INTO Estado VALUES (3, 'Amazonas', 'AM');
INSERT INTO Estado VALUES (4, 'Amapá', 'AP');
INSERT INTO Estado VALUES (5, 'Bahia', 'BA');
INSERT INTO Estado VALUES (6, 'Ceará', 'CE');
INSERT INTO Estado VALUES (7, 'Distrito Federal', 'DF');
INSERT INTO Estado VALUES (8, 'Espirito Santo', 'ES');
INSERT INTO Estado VALUES (9, 'Goiás', 'GO');
INSERT INTO Estado VALUES (10, 'Maranhão', 'MA');
INSERT INTO Estado VALUES (11, 'Minas Gerais', 'MG');
INSERT INTO Estado VALUES (12, 'Mato Grosso do Sul', 'MS');
INSERT INTO Estado VALUES (13, 'Mato Grosso', 'MT');
INSERT INTO Estado VALUES (14, 'Pará', 'PA');
INSERT INTO Estado VALUES (15, 'Paraíba', 'PB');
INSERT INTO Estado VALUES (16, 'Pernambuco', 'PE');
INSERT INTO Estado VALUES (17, 'Piauí', 'PI');
INSERT INTO Estado VALUES (18, 'Paraná', 'PR');
INSERT INTO Estado VALUES (19, 'Rio de Janeiro', 'RJ');
INSERT INTO Estado VALUES (20, 'Rio Grande do Norte', 'RN');
INSERT INTO Estado VALUES (21, 'Rondônia', 'RO');
INSERT INTO Estado VALUES (22, 'Roraima', 'RR');
INSERT INTO Estado VALUES (23, 'Rio Grande do Sul', 'RS');
INSERT INTO Estado VALUES (24, 'Santa Catarina', 'SC');
INSERT INTO Estado VALUES (25, 'Sergipe', 'SE');
INSERT INTO Estado VALUES (26, 'São Paulo', 'SP');
INSERT INTO Estado VALUES (27, 'Tocantins', 'TO');

INSERT INTO [dbo].[Cidade] ([Id],[Nome],[EstadoId]) VALUES   (1,'São Paulo',26);
INSERT INTO [dbo].[Cidade] ([Id],[Nome],[EstadoId]) VALUES   (1,'Rio de Janeiro',19);
INSERT INTO [dbo].[Cidade] ([Id],[Nome],[EstadoId]) VALUES   (1,'Goiânea',9);


DECLARE @TEMP_RND_MAX decimal 
DECLARE @TEMP_RND_MIN decimal 
DECLARE @CLIMA varchar(20)='ENSOLARADO' 
DECLARE @I INT = 1;
DECLARE @J INT = 1;
DECLARE @CID_IDS INT = 3;
DECLARE @TOTAL_DIAS INT = 30;
  WHILE @I <= @CID_IDS
  BEGIN
  SET @TEMP_RND_MAX = (select 28 + 45*rand());
  SET @TEMP_RND_MIN = (select 12 + 21*rand());
  INSERT INTO [dbo].[PrevisaoClima] ([CidadeId],[DataPrevisao],[Clima],[TemperaturaMinima],[TemperaturaMaxima])
  VALUES (@I, GETDATE(),@CLIMA,@TEMP_RND_MIN,@TEMP_RND_MAX);      
      WHILE @J <= @TOTAL_DIAS
	  BEGIN
	  SET @TEMP_RND_MAX = (select 28 + 45*rand());
	  SET @TEMP_RND_MIN = (select 12 + 21*rand());
	  IF @J%2 = 0
                     SET @CLIMA='ENSOLARADO';
	  IF @J%2 <> 0
                  SET @CLIMA='NUBLADO';
					 
			 PRINT 'Contador dias: ' + cast(@J as varchar(10));
             INSERT INTO [dbo].[PrevisaoClima] ([CidadeId],[DataPrevisao],[Clima],[TemperaturaMinima],[TemperaturaMaxima])
			 VALUES (@I, DATEADD(DAY,  @J, GETDATE()),@CLIMA,@TEMP_RND_MIN,@TEMP_RND_MAX);      
		     SET @J += 1;
	  END
  SET @J = 1;
  SET @I += 1;
  END
GO