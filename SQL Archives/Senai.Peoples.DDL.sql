CREATE	DATABASE M_PEOPLES
GO

USE M_PEOPLES

CREATE TABLE TBL_FUNCIONARIOS
(
	ID_FUNCIONARIO		INT PRIMARY KEY IDENTITY
	,NOME				VARCHAR(255) NOT NULL
	,SOBRENOME			VARCHAR(255) NOT NULL
);
GO