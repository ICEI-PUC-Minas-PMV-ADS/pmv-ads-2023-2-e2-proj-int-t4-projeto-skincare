CREATE DATABASE IF NOT EXISTS softcaredb;

USE softcaredb;

CREATE TABLE IF NOT EXISTS users (
    user_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(40) NOT NULL,
    last_name VARCHAR(40) NOT NULL,
    birth_date DATE NOT NULL,
    email VARCHAR(255) NOT NULL,
    password_key VARCHAR(255) NOT NULL
);

CREATE TABLE IF NOT EXISTS routines ( 
    routine_id INT AUTO_INCREMENT PRIMARY KEY,
    routine_text VARCHAR(5000) NOT NULL,
    created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    user_id INT,
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
);

CREATE TABLE IF NOT EXISTS questions (
   question_id INT AUTO_INCREMENT PRIMARY KEY,
   question_text VARCHAR(150) NOT NULL,
   answer_text VARCHAR(100) NOT NULL,
   user_id INT,
   routine_id INT,
   FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE,
   FOREIGN KEY (routine_id) REFERENCES routines(routine_id) ON DELETE CASCADE
);


CREATE USER 'username'@'localhost' IDENTIFIED BY 'password';

GRANT SELECT, CREATE, DELETE ON softcaredb.routines TO 'username'@'localhost';



