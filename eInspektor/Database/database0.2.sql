-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema is-proj
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `is-proj` ;

-- -----------------------------------------------------
-- Schema is-proj
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `is-proj` DEFAULT CHARACTER SET utf8 ;
USE `is-proj` ;

-- -----------------------------------------------------
-- Table `is-proj`.`COMPANY`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`COMPANY` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`COMPANY` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `jib` INT(13) NOT NULL,
  `name` VARCHAR(255) NOT NULL,
  `location` VARCHAR(1000) NOT NULL,
  `owner` VARCHAR(255) NOT NULL,
  `bookkeeper` VARCHAR(255) NULL,
  `last_control` DATE NULL,
  `last_control_type` VARCHAR(255) NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `idCOMPANY_UNIQUE` (`id` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`INSPECTOR`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`INSPECTOR` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`INSPECTOR` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `first_name` VARCHAR(255) NOT NULL,
  `last_name` VARCHAR(255) NOT NULL,
  `department` VARCHAR(255) NOT NULL,
  `unavailable` INT NOT NULL DEFAULT 0,
  `shift` INT NOT NULL,
  `is_coordinator` TINYINT NOT NULL DEFAULT 0,
  `username` VARCHAR(45) NOT NULL,
  `salt` VARCHAR(45) NOT NULL,
  `password_hash` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE INDEX `username_UNIQUE` (`username` ASC) VISIBLE)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`VEHICLE`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`VEHICLE` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`VEHICLE` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `registration_num` VARCHAR(45) NOT NULL,
  `max_capacity` INT NOT NULL DEFAULT 99,
  `tag` VARCHAR(45) NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`ABSENCE`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`ABSENCE` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`ABSENCE` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `inspector_id` INT NOT NULL,
  `date_from` DATE NOT NULL,
  `date_to` DATE NULL,
  `duration_days` INT NULL,
  `absence_purpose` VARCHAR(255) NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_ABSENCE_INSPECTOR1_idx` (`inspector_id` ASC) VISIBLE,
  CONSTRAINT `fk_ABSENCE_INSPECTOR1`
    FOREIGN KEY (`inspector_id`)
    REFERENCES `is-proj`.`INSPECTOR` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`CONTROL`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`CONTROL` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`CONTROL` (
  `id` INT NOT NULL auto_increment,
  `company_id` INT NOT NULL,
  `start_date` DATE NOT NULL,
  `finish_date` DATE NULL,
  `is_finished` TINYINT NOT NULL DEFAULT 0,
  `is_regular` TINYINT NOT NULL,
  `report_content` TEXT NULL,
  `control_justified` TINYINT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_COMPANY_has_INSPECTOR_COMPANY1_idx` (`company_id` ASC) VISIBLE,
  CONSTRAINT `fk_COMPANY_has_INSPECTOR_COMPANY1`
    FOREIGN KEY (`company_id`)
    REFERENCES `is-proj`.`COMPANY` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`VEHICLE_RESPONSIBILITY`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`VEHICLE_RESPONSIBILITY` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`VEHICLE_RESPONSIBILITY` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `vehicle_id` INT NOT NULL,
  `inspector_id` INT NOT NULL,
  `control_id` INT NULL,
  `date` DATE NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_VEHICLE_has_CONTROL_VEHICLE1_idx` (`vehicle_id` ASC) VISIBLE,
  INDEX `fk_VEHICLE_RESPONSIBILITY_INSPECTOR1_idx` (`inspector_id` ASC) VISIBLE,
  INDEX `fk_VEHICLE_RESPONSIBILITY_CONTROL1_idx` (`control_id` ASC) VISIBLE,
  CONSTRAINT `fk_VEHICLE_has_CONTROL_VEHICLE1`
    FOREIGN KEY (`vehicle_id`)
    REFERENCES `is-proj`.`VEHICLE` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_VEHICLE_RESPONSIBILITY_INSPECTOR1`
    FOREIGN KEY (`inspector_id`)
    REFERENCES `is-proj`.`INSPECTOR` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_VEHICLE_RESPONSIBILITY_CONTROL1`
    FOREIGN KEY (`control_id`)
    REFERENCES `is-proj`.`CONTROL` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`LAB_SAMPLE`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`LAB_SAMPLE` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`LAB_SAMPLE` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `company_id` INT NOT NULL,
  `inspector_id` INT NOT NULL,
  `date` DATE NOT NULL,
  `description` TEXT NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_LAB_SAMPLE_COMPANY1_idx` (`company_id` ASC) VISIBLE,
  INDEX `fk_LAB_SAMPLE_INSPECTOR1_idx` (`inspector_id` ASC) VISIBLE,
  CONSTRAINT `fk_LAB_SAMPLE_COMPANY1`
    FOREIGN KEY (`company_id`)
    REFERENCES `is-proj`.`COMPANY` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_LAB_SAMPLE_INSPECTOR1`
    FOREIGN KEY (`inspector_id`)
    REFERENCES `is-proj`.`INSPECTOR` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`COMPLAINT`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`COMPLAINT` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`COMPLAINT` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `company_id` INT NOT NULL,
  `text` TEXT NOT NULL,
  `issuer` VARCHAR(255) NULL,
  `is_justified` TINYINT NULL,
  `date` DATE NOT NULL,
  `control_id` INT NULL,
  `is_resolved` TINYINT NULL,
  PRIMARY KEY (`id`),
  INDEX `fk_COMPLAINT_COMPANY1_idx` (`company_id` ASC) VISIBLE,
  INDEX `fk_COMPLAINT_CONTROL1_idx` (`control_id` ASC) VISIBLE,
  CONSTRAINT `fk_COMPLAINT_COMPANY1`
    FOREIGN KEY (`company_id`)
    REFERENCES `is-proj`.`COMPANY` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_COMPLAINT_CONTROL1`
    FOREIGN KEY (`control_id`)
    REFERENCES `is-proj`.`CONTROL` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`CONTROL_has_INSPECTOR`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`CONTROL_has_INSPECTOR` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`CONTROL_has_INSPECTOR` (
  `control_id` INT NOT NULL,
  `inspector_id` INT NOT NULL,
  PRIMARY KEY (`control_id`, `inspector_id`),
  INDEX `fk_CONTROL_has_INSPECTOR_INSPECTOR1_idx` (`inspector_id` ASC) VISIBLE,
  INDEX `fk_CONTROL_has_INSPECTOR_CONTROL1_idx` (`control_id` ASC) VISIBLE,
  CONSTRAINT `fk_CONTROL_has_INSPECTOR_CONTROL1`
    FOREIGN KEY (`control_id`)
    REFERENCES `is-proj`.`CONTROL` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_CONTROL_has_INSPECTOR_INSPECTOR1`
    FOREIGN KEY (`inspector_id`)
    REFERENCES `is-proj`.`INSPECTOR` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`DEPARTMENT`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`DEPARTMENT` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`DEPARTMENT` (
  `id` INT NOT NULL AUTO_INCREMENT,
  `name` VARCHAR(255) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `is-proj`.`JOINT_CONTROL`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `is-proj`.`JOINT_CONTROL` ;

CREATE TABLE IF NOT EXISTS `is-proj`.`JOINT_CONTROL` (
  `control_id` INT NOT NULL,
  `department_id` INT NOT NULL,
  INDEX `fk_JOINT_CONTROL_DEPARTMENT1_idx` (`department_id` ASC) VISIBLE,
  INDEX `fk_JOINT_CONTROL_CONTROL1_idx` (`control_id` ASC) VISIBLE,
  PRIMARY KEY (`control_id`),
  CONSTRAINT `fk_JOINT_CONTROL_DEPARTMENT1`
    FOREIGN KEY (`department_id`)
    REFERENCES `is-proj`.`DEPARTMENT` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_JOINT_CONTROL_CONTROL1`
    FOREIGN KEY (`control_id`)
    REFERENCES `is-proj`.`CONTROL` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
