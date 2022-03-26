-- MySQL Script generated by MySQL Workbench
-- Thu Mar 24 15:23:51 2022
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema BaseDatos
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Schema BaseDatos
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `BaseDatos` DEFAULT CHARACTER SET utf8 ;
USE `BaseDatos` ;

-- -----------------------------------------------------
-- Table `BaseDatos`.`Usuario`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BaseDatos`.`Usuario` (
  `Codigo` VARCHAR(15) NOT NULL,
  `Nombre` VARCHAR(45) NULL,
  `roll` VARCHAR(45) NULL,
  `clave` VARCHAR(45) NULL,
  `EstaActivo` TINYINT NULL,
  PRIMARY KEY (`Codigo`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `BaseDatos`.`Producto`
-- -----------------------------------------------------
CREATE TABLE IF NOT EXISTS `BaseDatos`.`Producto` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `Codigo` VARCHAR(45) NULL,
  `Descripcion` VARCHAR(45) NULL,
  `Precio` DECIMAL(18,2) NULL,
  `Existencia` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
