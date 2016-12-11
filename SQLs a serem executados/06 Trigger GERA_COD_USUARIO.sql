CREATE TRIGGER TRG_GERA_COD_USUARIO
ON USUARIO
INSTEAD OF INSERT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE 
	@IDUSUR UNIQUEIDENTIFIER,
	@EMAILINST VARCHAR(40),
	@CODIGOUSUARIO VARCHAR(8);

	SELECT @CODIGOUSUARIO = NEXT VALUE FOR SEQ_CODIGO_USUARIO;

	SELECT 
		@IDUSUR = ID,
		@EMAILINST = EMAILINSTITUCIONAL
	FROM INSERTED;

	EXEC PROC_GERA_CODIGO_USUARIO @IDUSUR, @EMAILINST, @CODIGOUSUARIO OUTPUT;

	INSERT INTO USUARIO (ID, CODIGO, CPF, NOME, DTNASCIMENTO, EMAILINSTITUCIONAL, EMAILSECUNDARIO, POSSUIVEICULO, TELEFONE, ATIVO, SENHA)
						
							
							SELECT @IDUSUR, @CODIGOUSUARIO,
									   I.CPF,
									   I.NOME,
									   I.DTNASCIMENTO,
									   I.EMAILINSTITUCIONAL,
									   I.EMAILSECUNDARIO,
									   1,
									   I.TELEFONE,
									   I.ATIVO,
									   I.SENHA
								FROM INSERTED I;
END;

--DROP TRIGGER TRG_GERA_COD_USUARIO


