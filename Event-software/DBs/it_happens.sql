-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Φιλοξενητής: localhost
-- Χρόνος δημιουργίας: 27 Δεκ 2019 στις 20:44:53
-- Έκδοση διακομιστή: 10.1.37-MariaDB
-- Έκδοση PHP: 5.6.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Βάση δεδομένων: `it_happens`
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

--
-- Άδειασμα δεδομένων του πίνακα `area`
--

INSERT INTO `area` (`id`, `continent`, `country`, `city`, `zip_code`, `address`) VALUES
(1, 'EU', 'Greece', 'Athens', 12345, 'Kallitheas 57'),
(2, 'EU', 'Spain', 'Madrid', 21345, 'Rodeo 78'),
(3, 'Asia', 'China', 'Beijing', 78945, 'ChinaTown 123');

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `categories`
--

CREATE TABLE `categories` (
  `id` int(11) NOT NULL,
  `categories` varchar(11) NOT NULL,
  `parent` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Άδειασμα δεδομένων του πίνακα `categories`
--

INSERT INTO `categories` (`id`, `categories`, `parent`) VALUES
(1, 'Sports', 0),
(2, 'Technology', 0),
(3, 'Music', 0);

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

--
-- Άδειασμα δεδομένων του πίνακα `event`
--

INSERT INTO `event` (`id`, `ownerID`, `venueID`, `categoryID`, `startingDate`, `endingDate`, `description`, `tags`, `ticketprice`) VALUES
(1, 2, 1, 1, '2020-04-20', '2020-04-20', 'Podosfairikos Agwnas Olumpiakou-Paok', 'football', 20),
(2, 3, 3, 3, '2020-03-15', '2020-03-17', 'Sunaulia tou Saki Rouva', 'music', 10),
(3, 2, 3, 3, '2020-02-21', '2020-02-23', 'Sunaulia tis Natassas Mpofiliou', 'mpofiliou', 12);

-- --------------------------------------------------------

--
-- Δομή πίνακα για τον πίνακα `event_list`
--

CREATE TABLE `event_list` (
  `id` int(11) NOT NULL,
  `title` text NOT NULL,
  `creatorID` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Άδειασμα δεδομένων του πίνακα `event_list`
--

INSERT INTO `event_list` (`id`, `title`, `creatorID`) VALUES
(1, 'Music Concert', 2),
(2, 'Football Event', 3),
(3, 'Music Concert2', 2);

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

--
-- Άδειασμα δεδομένων του πίνακα `users`
--

INSERT INTO `users` (`id`, `areaID`, `Username`, `password`, `email`, `name`, `surname`, `age`) VALUES
(2, 2, 'aleksisA', 'awsEdfa', 'aleksisA@gmail.com', 'Aleksandros', 'Athinaiou', 23),
(3, 1, 'itHappens', '123465', 'itHappens@gmail.com', 'itHappens', 'itHappens2', 25),
(4, 3, 'EiriniPa', 'eirinaki32', 'eiriniPapad@gmail.com', 'Eirini', 'Papadopoulou', 32);

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
-- Άδειασμα δεδομένων του πίνακα `venues`
--

INSERT INTO `venues` (`id`, `accID`, `areaID`, `name`, `capacity`) VALUES
(1, 2, 1, 'OAKA', 70000),
(2, 3, 2, 'Camp Nou', 99000),
(3, 1, 1, 'Barbarella', 500);

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
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT για πίνακα `categories`
--
ALTER TABLE `categories`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT για πίνακα `event`
--
ALTER TABLE `event`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT για πίνακα `event_list`
--
ALTER TABLE `event_list`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT για πίνακα `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT για πίνακα `venues`
--
ALTER TABLE `venues`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

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
