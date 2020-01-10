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
  `title` VARCHAR(50) NOT NULL,
  `color` VARCHAR(50) NOT NULL,
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

INSERT into categories (id,categories,title,color, parent) values (1,'Entertainment','ENTERTAINMENT','Red', 0);
INSERT into categories (id,categories,title,color, parent) values (2,'Educational','EDUCATIONAL','Blue', 0);
INSERT into categories (id,categories,title,color, parent) values (3,'Health and General','HEALTH & GENERAL','GreenYellow', 0);

INSERT into categories (id,categories,title,color, parent) values (4,'music','MUSIC','Maroon', 1);
INSERT into categories (id,categories,title,color, parent) values (5,'dance','DANCING','Violet', 1);
INSERT into categories (id,categories,title,color, parent) values (6,'food','FOOD & DRINK','Chocolate', 1);
INSERT into categories (id,categories,title,color, parent) values (7,'sales','SHOPPING','Goldenrod', 1);
INSERT into categories (id,categories,title,color, parent) values (8,'comedy','COMEDY','MediumVioletRed', 1);
INSERT into categories (id,categories,title,color, parent) values (9,'movies_film','FILM','Orchid', 1);
INSERT into categories (id,categories,title,color, parent) values (10,'theatric_plays','THEATRE','Plum', 1);
INSERT into categories (id,categories,title,color, parent) values (11,'club_associations','CLUB ASSOCIATIONS','Firebrick', 1);
INSERT into categories (id,categories,title,color, parent) values (12,'singles_social','SOCIAL','IndianRed', 1);
INSERT into categories (id,categories,title,color, parent) values (13,'parties','PARTIES','DarkRed', 1);
INSERT into categories (id,categories,title,color, parent) values (14,'festivals_parades','FESTIVALS','HotPink', 1);
INSERT into categories (id,categories,title,color, parent) values (15,'performing_arts','PERFORMING ARTS','PaleVioletRed', 1);
INSERT into categories (id,categories,title,color, parent) values (16,'holiday','HOLIDAYS','OrangeRed', 1);

INSERT into categories (id,categories,title,color, parent) values (17,'business','BUSINESS','DarkBlue', 2);
INSERT into categories (id,categories,title,color, parent) values (18,'learning_education','EDUCATION','DarkTurquoise', 2);
INSERT into categories (id,categories,title,color, parent) values (19,'attractions','ATTRACTIONS','DarkSlateBlue', 2);
INSERT into categories (id,categories,title,color, parent) values (20,'art','ART','BlueViolet', 2);
INSERT into categories (id,categories,title,color, parent) values (21,'conference','CONFERENCE','MediumBlue', 2);
INSERT into categories (id,categories,title,color, parent) values (22,'seminars','SEMINARS','RoyalBlue', 2);
INSERT into categories (id,categories,title,color, parent) values (23,'books','BOOKS','MediumSlateBlue', 2);
INSERT into categories (id,categories,title,color, parent) values (24,'politics_activism','ACTIVISM','MidnightBlue', 2);
INSERT into categories (id,categories,title,color, parent) values (25,'science','SCIENCE','CadetBlue', 2);
INSERT into categories (id,categories,title,color, parent) values (26,'technology','TECHNOLOGY','SteelBlue', 2);

INSERT into categories (id,categories,title,color, parent) values (27,'family_fun_kids','FAMILY','OliveDrab', 3);
INSERT into categories (id,categories,title,color, parent) values (28,'fundraisers','FUNDRAISERS','Yellow', 3);
INSERT into categories (id,categories,title,color, parent) values (29,'support','SUPPORT','Gold', 3);
INSERT into categories (id,categories,title,color, parent) values (30,'community','COMMUNITY','YellowGreen', 3);
INSERT into categories (id,categories,title,color, parent) values (31,'schools_alumni','SCHOOL','MediumSeaGreen', 3);
INSERT into categories (id,categories,title,color, parent) values (32,'outdoors_recreation','OUTDOORS','DarkGreen', 3);
INSERT into categories (id,categories,title,color, parent) values (33,'animals','ANIMALS','Green', 3);
INSERT into categories (id,categories,title,color, parent) values (34,'religion_spirituality','RELIGION','LimeGreen', 3);
INSERT into categories (id,categories,title,color, parent) values (35,'sports','SPORTS','ForestGreen', 3);
INSERT into categories (id,categories,title,color, parent) values (36,'other','OTHER','DarkGray', 3);



SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
