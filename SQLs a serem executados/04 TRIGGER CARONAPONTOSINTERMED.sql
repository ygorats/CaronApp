CREATE TRIGGER TRG_CONVERSOR_PONTOS_INTERMEDIARIOS
ON CARONAPONTOSINTERMEDIARIOS
AFTER INSERT
AS BEGIN
	SET NOCOUNT ON;

	DECLARE
	@ID UNIQUEIDENTIFIER,
	@LATITUDE VARCHAR(10),
	@LONGITUDE VARCHAR(10)
	DECLARE CURSOR_PONTOS CURSOR FOR 
		SELECT IDCARONA
		FROM CARONAPONTOSINTERMEDIARIOS
		
	--DEFININDO O CURSOR
	OPEN CURSOR_PONTOS

	FETCH NEXT FROM CURSOR_PONTOS INTO @ID

	--PERCORRENDO OS REGISTROS INSERIDOS
	WHILE @@FETCH_STATUS = 0
	BEGIN
		SELECT @ID = IDCARONA, 
		   @LATITUDE = LATITUDE,
		   @LONGITUDE = LONGITUDE 
		   FROM INSERTED;



		FETCH NEXT FROM CURSOR_PONTOS INTO @ID
	END;
END;


--DROP TRIGGER TRG_CONVERSOR_PONTOS_INTERMEDIARIOS;
