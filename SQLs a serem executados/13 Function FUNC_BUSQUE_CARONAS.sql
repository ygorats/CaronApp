CREATE FUNCTION FUNC_BUSQUE_CARONAS (@DESTINO VARCHAR(15), @ORIGEM VARCHAR(15))
RETURNS TABLE
AS 
RETURN (

SELECT U.NOME, U.TELEFONE, U.EMAILINSTITUCIONAL, V.PLACA, V.MARCA, V.MODELO, C.DESCRICAO 
	FROM CARONA C, USUARIO U, VEICULO V
WHERE PONTODESTINO.STDistance(geography::STPointFromText('POINT(" + destinoSql + ")', 4618)) <= 2000
  AND PONTOSINTERMEDIARIOS.STDistance(geography::STPointFromText('POINT(" + origemSql + ")', 4618)) <= 2000
  AND C.IDUSUARIO = U.ID
  AND V.IDUSUARIO = U.ID
  AND U.ATIVO = 1

);