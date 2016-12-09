#------------------------------------------------------------
#        Script SQLite  
#------------------------------------------------------------


#------------------------------------------------------------
# Table: Utilisateurs
#------------------------------------------------------------
CREATE TABLE Utilisateurs(
	idutilisateur   INTEGER autoincrement NOT NULL ,
	nomUtilisateur  TEXT NOT NULL ,
	mdpUtilisateur  TEXT NOT NULL ,
	PRIMARY KEY (idutilisateur)
);


#------------------------------------------------------------
# Table: Questions
#------------------------------------------------------------
CREATE TABLE Questions(
	idQuestion    INTEGER autoincrement NOT NULL ,
	listQuestion  TEXT NOT NULL ,
	PRIMARY KEY (idQuestion)
);


#------------------------------------------------------------
# Table: Reponses
#------------------------------------------------------------
CREATE TABLE Reponses(
	idReponse    INTEGER autoincrement NOT NULL ,
	listReponse  TEXT NOT NULL ,
	PRIMARY KEY (idReponse)
);


#------------------------------------------------------------
# Table: Questionnaires
#------------------------------------------------------------
CREATE TABLE Questionnaires(
	idQuestionnaire  INTEGER autoincrement NOT NULL ,
	PRIMARY KEY (idQuestionnaire)
);


#------------------------------------------------------------
# Table: poser
#------------------------------------------------------------
CREATE TABLE poser(
	score               INTEGER NOT NULL ,
	dateEnregistrement  NUMERIC NOT NULL ,
	idutilisateur       INTEGER NOT NULL ,
	idQuestionnaire     INTEGER NOT NULL ,
	PRIMARY KEY (idutilisateur,idQuestionnaire) ,
	
	FOREIGN KEY (idutilisateur) REFERENCES Utilisateurs(idutilisateur),
	FOREIGN KEY (idQuestionnaire) REFERENCES Questionnaires(idQuestionnaire)
);


#------------------------------------------------------------
# Table: lier
#------------------------------------------------------------
CREATE TABLE lier(
	idQuestion  INTEGER NOT NULL ,
	idReponse   INTEGER NOT NULL ,
	PRIMARY KEY (idQuestion,idReponse) ,
	
	FOREIGN KEY (idQuestion) REFERENCES Questions(idQuestion),
	FOREIGN KEY (idReponse) REFERENCES Reponses(idReponse)
);


#------------------------------------------------------------
# Table: composer
#------------------------------------------------------------
CREATE TABLE composer(
	idQuestion       INTEGER NOT NULL ,
	idQuestionnaire  INTEGER NOT NULL ,
	PRIMARY KEY (idQuestion,idQuestionnaire) ,
	
	FOREIGN KEY (idQuestion) REFERENCES Questions(idQuestion),
	FOREIGN KEY (idQuestionnaire) REFERENCES Questionnaires(idQuestionnaire)
);


