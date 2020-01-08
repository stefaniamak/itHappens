-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema mydb
-- -----------------------------------------------------
-- -----------------------------------------------------
-- Schema it_happens
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `it_happens` ;

-- -----------------------------------------------------
-- Schema it_happens
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `it_happens` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci ;
USE `it_happens` ;

-- -----------------------------------------------------
-- Table `it_happens`.`area`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `it_happens`.`area` ;

CREATE TABLE IF NOT EXISTS `it_happens`.`area` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `continent` TEXT NOT NULL,
  `country` TEXT NOT NULL,
  `city` TEXT NOT NULL,
  `zip_code` VARCHAR(50) NULL DEFAULT NULL,
  `address` TEXT NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 88
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it_happens`.`categories`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `it_happens`.`categories` ;

CREATE TABLE IF NOT EXISTS `it_happens`.`categories` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `categories` VARCHAR(50) NOT NULL,
  `parent` INT(11) NOT NULL,
  PRIMARY KEY (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 42
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it_happens`.`venues`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `it_happens`.`venues` ;

CREATE TABLE IF NOT EXISTS `it_happens`.`venues` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `accID` INT(11) NOT NULL,
  `areaID` INT(11) NOT NULL,
  `name` TEXT NOT NULL,
  `capacity` DOUBLE NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `areaID_idx` (`areaID` ASC) VISIBLE,
  CONSTRAINT `areaID`
    FOREIGN KEY (`areaID`)
    REFERENCES `it_happens`.`area` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 106
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it_happens`.`users`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `it_happens`.`users` ;

CREATE TABLE IF NOT EXISTS `it_happens`.`users` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `areaID` INT(11) NOT NULL,
  `username` TEXT NOT NULL,
  `password` TEXT NOT NULL,
  `email` TEXT NOT NULL,
  `name` TEXT NOT NULL,
  `surname` TEXT NOT NULL,
  `age` INT(11) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `area_id` (`areaID` ASC) VISIBLE,
  CONSTRAINT `area_id`
    FOREIGN KEY (`areaID`)
    REFERENCES `it_happens`.`area` (`id`))
ENGINE = InnoDB
AUTO_INCREMENT = 2
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it_happens`.`event`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `it_happens`.`event` ;

CREATE TABLE IF NOT EXISTS `it_happens`.`event` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `title` VARCHAR(200) NOT NULL,
  `ownerID` INT(11) NOT NULL,
  `venueID` INT(11) NOT NULL,
  `categoryID` INT(11) NOT NULL,
  `startingDate` DATETIME NOT NULL,
  `endingDate` DATETIME NULL DEFAULT NULL,
  `description` TEXT NOT NULL,
  `tags` TEXT NULL DEFAULT NULL,
  `ticketprice` DOUBLE NULL DEFAULT NULL,
  PRIMARY KEY (`id`),
  INDEX `categoryID_idx` (`categoryID` ASC) VISIBLE,
  INDEX `venueID_idx` (`venueID` ASC) VISIBLE,
  INDEX `ownerID_idx` (`ownerID` ASC) VISIBLE,
  CONSTRAINT `categoryID`
    FOREIGN KEY (`categoryID`)
    REFERENCES `it_happens`.`categories` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `venueID`
    FOREIGN KEY (`venueID`)
    REFERENCES `it_happens`.`venues` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `ownerID`
    FOREIGN KEY (`ownerID`)
    REFERENCES `it_happens`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB
AUTO_INCREMENT = 41
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it_happens`.`event_list`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `it_happens`.`event_list` ;

CREATE TABLE IF NOT EXISTS `it_happens`.`event_list` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `title` TEXT NOT NULL,
  `creatorID` INT(11) NOT NULL,
  PRIMARY KEY (`id`),
  INDEX `creator_id` (`creatorID` ASC) VISIBLE,
  CONSTRAINT `creator_id`
    FOREIGN KEY (`creatorID`)
    REFERENCES `it_happens`.`users` (`id`))
ENGINE = InnoDB
DEFAULT CHARACTER SET = utf8mb4
COLLATE = utf8mb4_0900_ai_ci;


-- -----------------------------------------------------
-- Table `it_happens`.`attendants`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `it_happens`.`attendants` ;

CREATE TABLE IF NOT EXISTS `it_happens`.`attendants` (
  `eventListID` INT NOT NULL,
  `eventID` INT NOT NULL,
  INDEX `eventListID_idx` (`eventListID` ASC) VISIBLE,
  INDEX `eventID_idx` (`eventID` ASC) VISIBLE,
  CONSTRAINT `eventListID`
    FOREIGN KEY (`eventListID`)
    REFERENCES `it_happens`.`event_list` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `eventID`
    FOREIGN KEY (`eventID`)
    REFERENCES `it_happens`.`event` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `it_happens`.`following`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `it_happens`.`following` ;

CREATE TABLE IF NOT EXISTS `it_happens`.`following` (
  `following_user_id` INT NOT NULL,
  `followed_user_id` INT NOT NULL,
  INDEX `following_user_ID_idx` (`following_user_id` ASC) VISIBLE,
  INDEX `followed_user_ID_idx` (`followed_user_id` ASC) VISIBLE,
  CONSTRAINT `following_user_ID`
    FOREIGN KEY (`following_user_id`)
    REFERENCES `it_happens`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `followed_user_ID`
    FOREIGN KEY (`followed_user_id`)
    REFERENCES `it_happens`.`users` (`id`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;



INSERT into Users (id,areaID,Username,password,email,name,surname,age) values (1,1,1,1,1,1,1,1);

INSERT into categories (id,categories, parent) values (1,'Entertainment', 0);
INSERT into categories (id,categories, parent) values (2,'Educational', 0);
INSERT into categories (id,categories, parent) values (3,'Health and General', 0);

INSERT into categories (categories, parent) values ('music', 1);
INSERT into categories (categories, parent) values ('dance', 1);
INSERT into categories (categories, parent) values ('food', 1);
INSERT into categories (categories, parent) values ('sales', 1);
INSERT into categories (categories, parent) values ('comedy', 1);
INSERT into categories (categories, parent) values ('movies_film', 1);
INSERT into categories (categories, parent) values ('theatric_plays', 1);
INSERT into categories (categories, parent) values ('club_associations', 1);
INSERT into categories (categories, parent) values ('singles_social', 1);
INSERT into categories (categories, parent) values ('parties', 1);
INSERT into categories (categories, parent) values ('festivals_parades', 1);
INSERT into categories (categories, parent) values ('performing_arts', 1);
INSERT into categories (categories, parent) values ('holiday', 1);

INSERT into categories (categories, parent) values ('business', 2);
INSERT into categories (categories, parent) values ('learning_education', 2);
INSERT into categories (categories, parent) values ('attractions', 2);
INSERT into categories (categories, parent) values ('art', 2);
INSERT into categories (categories, parent) values ('conference', 2);
INSERT into categories (categories, parent) values ('seminars', 2);
INSERT into categories (categories, parent) values ('books', 2);
INSERT into categories (categories, parent) values ('politics_activism', 2);
INSERT into categories (categories, parent) values ('science', 2);
INSERT into categories (categories, parent) values ('technology', 2);

INSERT into categories (categories, parent) values ('family_fun_kids', 3);
INSERT into categories (categories, parent) values ('fundraisers', 3);
INSERT into categories (categories, parent) values ('support', 3);
INSERT into categories (categories, parent) values ('community', 3);
INSERT into categories (categories, parent) values ('schools_alumni', 3);
INSERT into categories (categories, parent) values ('outdoors_recreation', 3);
INSERT into categories (categories, parent) values ('animals', 3);
INSERT into categories (categories, parent) values ('religion_spirituality', 3);
INSERT into categories (categories, parent) values ('sports', 3);
INSERT into categories (categories, parent) values ('other', 3);



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
