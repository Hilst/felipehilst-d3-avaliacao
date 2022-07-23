
CREATE TABLE IF NOT EXISTS users (
  user_id INT NOT NULL PRIMARY KEY,
  nickname VARCHAR(250) NOT NULL,
  email VARCHAR(250) NOT NULL,
  psw CHAR(60) NOT NULL
);

INSERT INTO users (user_id, nickname, email, psw)
VALUES (1, 'admin', 'admin@email.com', '$2a$14$STkstinmQGYsPPo04EKBd.yhsI8.qY0qiB3rsBwaU7o4HVuerieku')
ON CONFLICT DO NOTHING;
-- admin123

INSERT INTO users (user_id, nickname, email, psw)
VALUES (2, 'hilst', 'hilst@email.com', '$2a$14$Gk/Eoh4D..8zC7okpmdfMOvrdekydiLBOIWanVn7VjMYr6MigQeRu')
ON CONFLICT DO NOTHING;
-- hilst0987