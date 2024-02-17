CREATE DATABASE IF NOT EXISTS esbd;
USE esbd;

CREATE TABLE IF NOT EXISTS tbl_funcionario (
    fun_codigo INT PRIMARY KEY AUTO_INCREMENT,
    fun_nome VARCHAR(255) NOT NULL,
    fun_salario DECIMAL(10, 2) NOT NULL,
    fun_cracha VARCHAR(10) NOT NULL
);

CREATE TABLE IF NOT EXISTS tbl_membro(
    mem_codigo INT PRIMARY KEY AUTO_INCREMENT UNIQUE,
    mem_nome VARCHAR(255) NOT NULL,
    mem_contrato MEDIUMTEXT NOT NULL,
    mem_tipo INT NOT NULL,
    mem_crea VARCHAR(255),
    mem_altura DECIMAL(6,2),
    mem_peso DECIMAL(6,2)
);
