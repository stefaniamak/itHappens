-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Φιλοξενητής: 127.0.0.1
-- Χρόνος δημιουργίας: 10 Δεκ 2019 στις 19:57:33
-- Έκδοση διακομιστή: 10.4.8-MariaDB
-- Έκδοση PHP: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Βάση δεδομένων: `event_project`
--

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `area`
--

CREATE TABLE `area` (
  `id` int(11) NOT NULL,
  `continent` text NOT NULL,
  `country` text NOT NULL,
  `city` text NOT NULL,
  `zip_code` int(11) NOT NULL,
  `address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `categories` varchar(11) NOT NULL,
  `parent` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `event`
--

CREATE TABLE `event` (
  `id` int(11) NOT NULL,
  `ownerID` int(11) NOT NULL,
  `venueID` int(11) NOT NULL,
  `categoryID` int(11) NOT NULL,
  `startingDate` date NOT NULL,
  `endingDate` date NOT NULL,
  `description` text NOT NULL,
  `tags` text NOT NULL,
  `ticketprice` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `event_list`
--

CREATE TABLE `event_list` (
  `id` int(11) NOT NULL,
  `title` text NOT NULL,
  `creatorID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `areaID` int(11) NOT NULL,
  `Username` text NOT NULL,
  `password` text NOT NULL,
  `email` text NOT NULL,
  `name` text NOT NULL,
  `surname` text NOT NULL,
  `age` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `venues`
--

CREATE TABLE `venues` (
  `id` int(11) NOT NULL,
  `accID` int(11) NOT NULL,
  `areaID` int(11) NOT NULL,
  `name` text NOT NULL,
  `capacity` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Ευρετήρια για άχρηστους πίνακες
--

--
-- Ευρετήρια για πίνακα `area`
--
ALTER TABLE `area`
  ADD PRIMARY KEY (`id`);

--
-- Ευρετήρια για πίνακα `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`id`);

--
-- Ευρετήρια για πίνακα `event`
--
ALTER TABLE `event`
  ADD PRIMARY KEY (`id`),
  ADD KEY `owner_id` (`ownerID`),
  ADD KEY `venue_id` (`venueID`),
  ADD KEY `categories` (`categoryID`);

--
-- Ευρετήρια για πίνακα `event_list`
--
ALTER TABLE `event_list`
  ADD PRIMARY KEY (`id`),
  ADD KEY `creator_id` (`creatorID`);

--
-- Ευρετήρια για πίνακα `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD KEY `area_id` (`areaID`);

--
-- Ευρετήρια για πίνακα `venues`
--
ALTER TABLE `venues`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT για άχρηστους πίνακες
--

--
-- AUTO_INCREMENT για πίνακα `area`
--
ALTER TABLE `area`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT για πίνακα `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT για πίνακα `event`
--
ALTER TABLE `event`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT για πίνακα `event_list`
--
ALTER TABLE `event_list`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT για πίνακα `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT για πίνακα `venues`
--
ALTER TABLE `venues`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- Περιορισμοί για άχρηστους πίνακες
--

--
-- Περιορισμοί για πίνακα `event`
--
ALTER TABLE `event`
  ADD CONSTRAINT `categories` FOREIGN KEY (`categoryID`) REFERENCES `categories` (`id`),
  ADD CONSTRAINT `owner_id` FOREIGN KEY (`ownerID`) REFERENCES `users` (`id`),
  ADD CONSTRAINT `venue_id` FOREIGN KEY (`venueID`) REFERENCES `venues` (`id`);

--
-- Περιορισμοί για πίνακα `event_list`
--
ALTER TABLE `event_list`
  ADD CONSTRAINT `creator_id` FOREIGN KEY (`creatorID`) REFERENCES `users` (`id`);

--
-- Περιορισμοί για πίνακα `users`
--
ALTER TABLE `users`
  ADD CONSTRAINT `area_id` FOREIGN KEY (`areaID`) REFERENCES `area` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
