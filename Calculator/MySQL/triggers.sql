	
DROP TRIGGER IF EXISTS insert_t;
DROP TRIGGER IF EXISTS insert_t_two;
	
	--------------- Triggers-----------------------------
	CREATE TRIGGER insert_t BEFORE 
	INSERT ON calc
	 FOR EACH ROW 
	 SET NEW.sum=NEW.number1+NEW.number2
	 
---------------------------------------------------------
	CREATE TRIGGER insert_t_two BEFORE 
	UPDATE ON calc
	 FOR EACH ROW 
	 SET NEW.sum=NEW.number1+NEW.number2;