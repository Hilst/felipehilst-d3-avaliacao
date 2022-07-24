IF OBJECT_ID (N'dbo.users', N'U') IS NULL
BEGIN
	CREATE TABLE users (
	  id INT NOT NULL PRIMARY KEY,
	  nome VARCHAR(250) NOT NULL,
	  email VARCHAR(250) NOT NULL,
	  senha CHAR(60) NOT NULL
	);
END;

IF (SELECT COUNT(*) FROM users WHERE id = 1) = 0
BEGIN
	INSERT INTO users (id, nome, email, senha)
	VALUES (1, 'admin', 'admin@email.com', '$2a$14$STkstinmQGYsPPo04EKBd.yhsI8.qY0qiB3rsBwaU7o4HVuerieku');
END;
-- admin123

IF (SELECT COUNT(*) FROM users WHERE id = 2) = 0
BEGIN
	INSERT INTO users (id, nome, email, senha)
	VALUES (2, 'hilst', 'hilst@email.com', '$2a$14$Gk/Eoh4D..8zC7okpmdfMOvrdekydiLBOIWanVn7VjMYr6MigQeRu')
END;
-- hilst0987

SELECT * FROM users;