CREATE TRIGGER TRG_INATIVA_USUARIO
ON USUARIO
INSTEAD OF DELETE
AS
BEGIN
	SET NOCOUNT ON;

	DECLARE
	@IDUSUR UNIQUEIDENTIFIER;

	SELECT @IDUSUR = ID FROM DELETED;

	UPDATE USUARIO
	SET ATIVO = 0
	WHERE ID = @IDUSUR;

END;