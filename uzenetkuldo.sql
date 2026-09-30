-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Gép: 127.0.0.1
-- Létrehozás ideje: 2026. Sze 30. 13:56
-- Kiszolgáló verziója: 10.4.32-MariaDB
-- PHP verzió: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Adatbázis: `uzenetkuldo`
--

-- --------------------------------------------------------

--
-- Tábla szerkezet ehhez a táblához `uzenet`
--

CREATE TABLE `uzenet` (
  `Id` int(11) NOT NULL,
  `Szoveg` text NOT NULL,
  `KüldesiIdo` datetime NOT NULL,
  `UzenetTipus` varchar(8) NOT NULL,
  `Telefon` varchar(16) NOT NULL,
  `Email` varchar(64) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_hungarian_ci;

--
-- A tábla adatainak kiíratása `uzenet`
--

INSERT INTO `uzenet` (`Id`, `Szoveg`, `KüldesiIdo`, `UzenetTipus`, `Telefon`, `Email`) VALUES
(1, 'azaz', '1999-05-31 11:20:00', 'SMS', '70-es', 'UJDONSÁG'),
(4, 'Vigyázat, csalók!!!\r\nIsmeretlenek a cégünk nevével visszaélve bizalmas információk (jelszavak, szerződésadatok) megadását kérhetik öntől teefonon vagy emailben. Felhívjuk figyelmét, hogy ilyen információt senkitől sem kérünk, ezért ne dőljön be a csalóknak!', '2026-09-13 10:07:19', 'Email', '', 'kiemeltugyfel@mail.com'),
(5, 'Üdvözlet', '2021-07-11 11:20:00', 'Email', '20141536363', 'valaki@gmail.com'),
(6, 'Üdvözlet', '2021-07-11 11:20:00', 'Email', '20141536363', 'valaki@gmail.com'),
(7, 'Üdvözlet', '2021-07-11 11:20:00', 'Email', '20141536363', 'valaki@gmail.com'),
(8, 'Üdvözlet', '2021-07-11 11:20:00', 'Email', '20141536363', 'valaki@gmail.com'),
(9, 'Üdvözlet', '2021-07-11 11:20:00', 'Email', '20141536363', 'valaki@gmail.com'),
(10, 'SZIAAAAAAAAA TESZTELEEEEEK!', '2021-07-11 11:20:00', 'Email', '20141536363', 'valaki@gmail.com');

--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `uzenet`
--
ALTER TABLE `uzenet`
  ADD PRIMARY KEY (`Id`);

--
-- A kiírt táblák AUTO_INCREMENT értéke
--

--
-- AUTO_INCREMENT a táblához `uzenet`
--
ALTER TABLE `uzenet`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
