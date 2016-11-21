CREATE TRIGGER ALTERA_USUARIO_POSSUIVEICULO
ON VEICULO
AFTER INSERT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE
	@IDUSUARIO UNIQUEIDENTIFIER

	SELECT @IDUSUARIO = IDUSUARIO FROM INSERTED;

	UPDATE USUARIO
	SET POSSUIVEICULO = 1
	WHERE ID = @IDUSUARIO;
END;

--DROP TRIGGER ALTERA_USUARIO_POSSUIVEICULO