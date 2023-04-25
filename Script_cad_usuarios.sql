  id_nivel int  primary key NOT NULL identity(1,1),
  nome varchar(50) NOT NULL,
 
); 
INSERT INTO nivel(id_nivel,nome) VALUES (1,'Administrador');
INSERT INTO nivel(id_nivel,nome) VALUES (3,'Desenvolvedor');
INSERT INTO nivel(id_nivel,nome) VALUES(2,'Usuário');


CREATE TABLE usuario (
 id_usuario int primary key  NOT NULL identity(1,1),
  nome varchar(50) DEFAULT NULL,
  email varchar(50) DEFAULT NULL,
  senha varchar(25) DEFAULT NULL,
  nivel int DEFAULT NULL,
 

  
);
ALTER TABLE usuario
 ADD CONSTRAINT fk_nivel FOREIGN KEY (nivel) REFERENCES nivel (id_nivel)
INSERT INTO usuario() VALUES (1,'admin','admin@fabiana.dayla.com.br','123456',1);